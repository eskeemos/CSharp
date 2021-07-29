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

namespace TrackerUI
{
    public partial class TournamentViewer : BaseSets // Refactored
    {
        private readonly ModelTournament tournament;
        readonly BindingList<int> rounds = new BindingList<int>();
        readonly BindingList<ModelMatchup> selectedMatchups = new BindingList<ModelMatchup>();

        public TournamentViewer(ModelTournament _tournament)
        {
            InitializeComponent();

            tournament = _tournament;

            WireUpLists();

            LoadFormData();

            LoadRounds();
        }
        private void LoadFormData()
        {
            lTournamentName.Text = tournament.TournamentName;
        }
        private void WireUpLists()
        {
            CbRounds.DataSource = rounds;
            LbRounds.DataSource = selectedMatchups;
            LbRounds.DisplayMember = "DisplayName";
        }
        private void LoadRounds()
        {
            rounds.Clear();

            rounds.Add(1);
            int currRound = 1;

            foreach (List<ModelMatchup> matchups in tournament.Rounds)
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
            foreach (List<ModelMatchup> matchups in tournament.Rounds)
            {
                if (matchups.First().MatchupRound == round)
                {
                    selectedMatchups.Clear();
                    foreach (ModelMatchup model in matchups)
                    {
                        if(model.Winner == null || !CbUnplayedOnly.Checked)
                        {
                            selectedMatchups.Add(model);
                        }
                        
                    }
                }
            }
            if(selectedMatchups.Count > 0)
            {
                LoadMatchup(selectedMatchups.First());
            }
            DisplayMatchupInfo();
        }

        private void DisplayMatchupInfo()
        {
            bool isVisible = (selectedMatchups.Count > 0);

            lteamOne.Visible = tbTeamOne.Visible = isVisible;
            lTeamTwo.Visible = tbTeamTwo.Visible = isVisible;
            lNoneSelected.Visible = !isVisible;

        }

        private void CbRounds_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMatchupList((int)CbRounds.SelectedItem);
        }
        private void LbRounds_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadMatchup((ModelMatchup)LbRounds.SelectedItem);
        }
        private void LoadMatchup(ModelMatchup model)
        {
            if(model != null)
            {
                for (int i = 0; i < model.Entries.Count; i++)
                {
                    if (i == 0)
                    {
                        if (model.Entries[0].TeamCompeting != null)
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

        private void CbUnplayedOnly_CheckedChanged(object sender, EventArgs e)
        {
            LoadMatchupList((int)CbRounds.SelectedItem);
        }

        private void Bscore_Click(object sender, EventArgs e)
        {
            ModelMatchup model = (ModelMatchup)LbRounds.SelectedItem;

            for (int i = 0; i < model.Entries.Count; i++)
            {
                if (i == 0)
                {
                    if(model.Entries[0].TeamCompeting != null)
                    {
                        bool validScore = double.TryParse(tbTeamOne.Text, out double teamOneScore);
                        if (validScore)
                        {
                            model.Entries[0].Score = teamOneScore;
                        }
                        else
                        {
                            MessageBox.Show($"Please Enter A Valid Score For {lteamOne.Text}");
                            return;
                        }
                    }
                }
                if (i == 1)
                {
                    if (model.Entries[1].TeamCompeting != null)
                    {
                        bool validScore = double.TryParse(tbTeamTwo.Text, out double teamTwoScore);
                        if (validScore)
                        {
                            model.Entries[1].Score = teamTwoScore;
                        }
                        else
                        {
                            MessageBox.Show($"Please Enter A Valid Score For {lTeamTwo.Text}");
                        }
                    }
                }
            }
            TournamentLogic.UpdateTournamentResults(tournament);

            LoadMatchupList((int)CbRounds.SelectedItem);
        }
    }
}
