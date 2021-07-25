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
        BindingList<int> rounds = new BindingList<int>();
        BindingList<ModelMatchup> selectedMatchups = new BindingList<ModelMatchup>();

        public TournamentViewer(ModelTournament tournament)
        {
            InitializeComponent();

            _tournament = tournament;

            WireUpLists();

            LoadFormData();

            LoadRounds();
        }
        private void LoadFormData()
        {
            lTournamentName.Text = _tournament.TournamentName;

        }
        private void WireUpLists()
        {
            cbRounds.DataSource = rounds;
            lbRounds.DataSource = selectedMatchups;
            lbRounds.DisplayMember = "DisplayName";
        }
        private void LoadRounds()
        {
            rounds.Clear();

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
            LoadMatchupList(1);
        }
        private void LoadMatchupList(int round)
        {
            foreach (List<ModelMatchup> matchups in _tournament.Rounds)
            {
                if (matchups.First().MatchupRound == round)
                {
                    selectedMatchups.Clear();
                    foreach (ModelMatchup model in matchups)
                    {
                        selectedMatchups.Add(model);
                    }
                }
            }

            LoadMatchup(selectedMatchups.First());
        }

        private void cbRounds_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMatchupList((int)cbRounds.SelectedItem);
        }
        private void lbRounds_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMatchup((ModelMatchup)lbRounds.SelectedItem);
        }
        private void LoadMatchup(ModelMatchup model)
        {
            for (int i = 0; i < model.Entries.Count; i++)
            {
                if (i == 0) 
                { 
                    if(model.Entries[0].TeamCompeting != null)
                    {
                        lteamOne.Text = model.Entries[0].TeamCompeting.TeamName;
                        tbTeamOne.Text = model.Entries[0].Score.ToString();

                        lTeamTwo.Text = "<bot>";
                        tbTeamTwo.Text = "0";
                    }
                    else
                    {
                        lteamOne.Text = "Not Yet Set";
                        tbTeamOne.Text = "";
                    }
                }
                if (i == 1)
                {
                    if (model.Entries[1].TeamCompeting != null)
                    {
                        lTeamTwo.Text = model.Entries[1].TeamCompeting.TeamName; ;
                        tbTeamTwo.Text = model.Entries[1].Score.ToString();
                    }
                    else
                    {
                        lTeamTwo.Text = "Not Yet Set";
                        tbTeamTwo.Text = "";
                    }
                }
            }
        }
    }
}
