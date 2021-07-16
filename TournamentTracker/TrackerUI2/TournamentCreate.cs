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
    public partial class TournamentCreate : BaseSets
    {
        List<ModelTeam> availTeams = GlobalConfig.Connection.GetTeamAll();
        List<ModelTeam> selectedTeams = new List<ModelTeam>();
        List<ModelPrize> selectedPrizes = new List<ModelPrize>();

        public TournamentCreate()
        {
            InitializeComponent();
            InitializeLists();
        }
        private void InitializeLists()
        {
            cbTeams.DataSource = availTeams;
            cbTeams.DisplayMember = "TeamName";

            lbTeams.DataSource = selectedTeams;
            lbTeams.DisplayMember = "TeamName";

            lbPrizes.DataSource = selectedPrizes;
            lbPrizes.DisplayMember = "PrizeName";
        }

        private void bAddTeam_Click(object sender, EventArgs e)
        {
            ModelTeam m = (ModelTeam)cbTeams.SelectedItem;

            if(m != null)
            {
                availTeams.Remove(m);
                selectedTeams.Add(m);

                WireUpLists();
            }
        }

        private void WireUpLists()
        {
            cbTeams.DataSource = null;
            cbTeams.DataSource = availTeams;
            cbTeams.DisplayMember = "TeamName";

            lbTeams.DataSource = null;
            lbTeams.DataSource = selectedTeams;
            lbTeams.DisplayMember = "TeamName";

            lbPrizes.DataSource = null;
            lbPrizes.DataSource = selectedPrizes;
            lbPrizes.DisplayMember = "PrizeName";
        }
    }
}
