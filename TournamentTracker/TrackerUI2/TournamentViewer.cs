using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class TournamentViewer : BaseSets
    {
        private ModelTournament _tournament;
        List<int> rounds = new List<int>();
        List<ModelMatchup> selectedMatchups = new List<ModelMatchup>();

        public TournamentViewer(ModelTournament tournament)
        {
            InitializeComponent();

            _tournament = tournament;

            LoadFormData();

            LoadRounds();
        }
        private void LoadFormData()
        {
            lTournamentName.Text = _tournament.TournamentName;

        }
        private void WireUpRoundsLists()
        {
            cbRounds.DataSource = null;
            cbRounds.DataSource = rounds;
        }
        private void WireUpMatchupsLists()
        {
            lbRounds.DataSource = null;
            lbRounds.DataSource = selectedMatchups;
            lbRounds.DisplayMember = "DisplayName";
        }
        private void LoadRounds()
        {
            rounds = new List<int>();
            rounds.Add(1);
            int currRound = 1;

            foreach (List<ModelMatchup> matchups in _tournament.Rounds)
            {
                if(matchups.First().MatchupRound > currRound)
                {
                    currRound = matchups.First().MatchupRound;
                    rounds.Add(currRound);
                }
            }

            WireUpRoundsLists();
        }
        private void LoadMatchupList()
        {
            int round = (int)cbRounds.SelectedItem;

            foreach (List<ModelMatchup> matchups in _tournament.Rounds)
            {
                if (matchups.First().MatchupRound == round)
                {
                    selectedMatchups = matchups;
                }
            }

            WireUpMatchupsLists();

        }

        private void cbRounds_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMatchupList();
        }
    }
}
