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

namespace TrackerUI
{
    public partial class TeamCreate : BaseSets
    {
        public TeamCreate()
        {
            InitializeComponent();
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

                GlobalConfig.Connection.CreatePerson(m);

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
    }
}
