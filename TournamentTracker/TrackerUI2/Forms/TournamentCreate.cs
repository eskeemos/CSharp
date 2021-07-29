using LogicLibrary;
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
    public partial class TournamentCreate : BaseSets, IPrizeRequestor, ITeamRequestor // Refactored
    {
        readonly List<ModelTeam> availTeams = GlobalConfig.Connection.GetTeams();
        readonly List<ModelTeam> selectedTeams = new List<ModelTeam>();
        readonly List<ModelPrize> selectedPrizes = new List<ModelPrize>();

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

        private void BaddTeam_Click(object sender, EventArgs e)
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

        private void LlCreateTeam_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TeamCreate form = new TeamCreate(this);
            form.Show();
        }

        private void BcreatePrize_Click(object sender, EventArgs e)
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

        private void BdeletePlayers_Click(object sender, EventArgs e)
        {
            ModelTeam model = (ModelTeam)lbTeams.SelectedItem;
            if(model != null)
            {
                selectedTeams.Remove(model);
                availTeams.Add(model);

                WireUpLists();
            }
        }

        private void BdeletePrizes_Click(object sender, EventArgs e)
        {
            ModelPrize model = (ModelPrize)lbPrizes.SelectedItem;
            if(model != null)
            {
                selectedPrizes.Remove(model);

                WireUpLists();
            }
        }

        private void BcreateTournament_Click(object sender, EventArgs e)
        {
            bool feeAcceptable = decimal.TryParse(tbEntryFee.Text, out decimal fee);
            if (!feeAcceptable)
            {
                MessageBox.Show("You need to enter valid Entry Fee data!", "Invalid Fee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var model = new ModelTournament
            {
                TournamentName = tbTournamentName.Text,
                EntryFee = fee,
                Prizes = selectedPrizes,
                EnteredTeams = selectedTeams
            };

            TournamentLogic.CreateRounds(model);

            GlobalConfig.Connection.CreateTournament(model);

            TournamentViewer form = new TournamentViewer(model);
            form.Show();
            this.Close();
        }
    }
}
