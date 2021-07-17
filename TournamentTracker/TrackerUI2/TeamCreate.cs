using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;
using TrackerUI2;

namespace TrackerUI
{
    public partial class TeamCreate : BaseSets
    {
        private List<ModelPerson> availTeamMembers = GlobalConfig.Connection.GetPersonAll();
        private List<ModelPerson> selectedTeamMembers = new List<ModelPerson>();
        private ITeamRequestor _caller;

        public TeamCreate(ITeamRequestor caller)
        {
            InitializeComponent();

            // CreateSampleData();
            _caller = caller;
            WireUpLists();
        }
        private void CreateSampleData()
        {
            availTeamMembers.Add(new ModelPerson { FirstName = "Tim", LastName = "Barney" });
            availTeamMembers.Add(new ModelPerson { FirstName = "BIM", LastName = "Swedea" });

            selectedTeamMembers.Add(new ModelPerson { FirstName = "Kakren", LastName = "Wires" });
            selectedTeamMembers.Add(new ModelPerson { FirstName = "Madia", LastName = "Olkiem" });
        }
        private void WireUpLists()
        {
            cbSelectTeamMember.DataSource = null;
            cbSelectTeamMember.DataSource = availTeamMembers;
            cbSelectTeamMember.DisplayMember = "FullName";

            lbTeamMembers.DataSource = null;
            lbTeamMembers.DataSource = selectedTeamMembers;
            lbTeamMembers.DisplayMember = "FullName";
        }

        private void bCreateMember_Click(object sender, EventArgs e)
        {
            if (ValidateForm())
            {
                ModelPerson m = new ModelPerson();

                m.FirstName = tbFirstName.Text;
                m.LastName = tbLastName.Text;
                m.EmailAddress = tbEmailAddress.Text;
                m.PhoneNumber = tbPhoneNumber.Text;

                m = GlobalConfig.Connection.CreatePerson(m);

                selectedTeamMembers.Add(m);
                WireUpLists();

                tbFirstName.Text = tbLastName.Text = tbEmailAddress.Text = tbPhoneNumber.Text = "";
            }
            else
            {
                MessageBox.Show("You need to fill in all of the fields!");
            }
        }
        private bool ValidateForm()
        {
            if(tbFirstName.Text.Length == 0)
            {
                return false;
            }
            if (tbLastName.Text.Length == 0)
            {
                return false;
            }
            if (tbEmailAddress.Text.Length == 0)
            {
                return false;
            }
            if (tbPhoneNumber.Text.Length == 0)
            {
                return false;
            }


            return true;
        }

        private void bAddMember_Click(object sender, EventArgs e)
        {
            ModelPerson m = (ModelPerson) cbSelectTeamMember.SelectedItem;

            if (m != null)
            {
                availTeamMembers.Remove(m);
                selectedTeamMembers.Add(m);

                WireUpLists();
            }
        }

        private void bDeleteSelected_Click(object sender, EventArgs e)
        {
            ModelPerson m = (ModelPerson)lbTeamMembers.SelectedItem;

            if (m != null)
            {
                selectedTeamMembers.Remove(m);
                availTeamMembers.Add(m);

                WireUpLists();
            }
        }

        private void bCreateTeam_Click(object sender, EventArgs e)
        {
            ModelTeam m = new ModelTeam();

            m.TeamName = tbTeamName.Text;
            m.TeamMembers = selectedTeamMembers;

            GlobalConfig.Connection.CreateTeam(m);

            _caller.TeamComplete(m);

            this.Close();
        }
    }
}
