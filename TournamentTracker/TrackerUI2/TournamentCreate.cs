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
    public partial class TournamentCreate : BaseSets, IPrizeRequestor, ITeamRequestor
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
            lbPrizes.DisplayMember = "PlaceName";
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
            lbPrizes.DisplayMember = "PlaceName";
        }

        private void llCreateTeam_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TeamCreate form = new TeamCreate(this);
            form.Show();
        }

        private void bCreatePrize_Click(object sender, EventArgs e)
        {
            PrizeCreate form = new PrizeCreate(this);
            form.Show();
        }

        public void PrizeComplete(ModelPrize model)
        {
            selectedPrizes.Add(model);
            WireUpLists();
        }

        public void TeamComplete(ModelTeam model)
        {
            selectedTeams.Add(model);
            WireUpLists();
        }

        private void bDeletePlayers_Click(object sender, EventArgs e)
        {
            ModelTeam model = (ModelTeam)lbTeams.SelectedItem;
            if(model != null)
            {
                selectedTeams.Remove(model);
                availTeams.Add(model);

                WireUpLists();
            }
        }

        private void bDeletePrizes_Click(object sender, EventArgs e)
        {
            ModelPrize model = (ModelPrize)lbPrizes.SelectedItem;
            if(model != null)
            {
                selectedPrizes.Remove(model);

                WireUpLists();
            }
        }

        private void bCreateTournament_Click(object sender, EventArgs e)
        {
            decimal fee = 0;
            bool feeAcceptable = decimal.TryParse(tbEntryFee.Text, out fee);
            if (!feeAcceptable)
            {
                MessageBox.Show("You need to enter valid Entry Fee data!", "Invalid Fee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var model = new ModelTournament();

            model.TournamentName = tbTournamentName.Text;
            model.EntryFee = fee;
            model.Prizes = selectedPrizes;
            model.EnteredTeams = selectedTeams;



            GlobalConfig.Connection.CreateTournament(model);
        }
    }
}
