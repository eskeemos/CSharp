using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace ClassLibrary3
{
    public static class TournamentLogic
    {
        public static void CreateRounds(ModelTournament model)
        {
            List<ModelTeam> randomizedTeams = RandomizeTeamOrder(model.EnteredTeams);
            int rounds = FindNumberOfRounds(randomizedTeams.Count);
            int byes = FindNumberOfByes(rounds, randomizedTeams.Count);
            model.Rounds.Add(CreateFirstRound(byes, randomizedTeams));
            CreateOtherRounds(model, rounds);
        }
        private static void CreateOtherRounds(ModelTournament model, int rounds)
        {
            int round = 2;
            List<ModelMatchup> previousRound = model.Rounds[0];
            List<ModelMatchup> currRound = new List<ModelMatchup>();
            ModelMatchup currMatchup = new ModelMatchup();

            while(round <= rounds)
            {
                foreach (ModelMatchup matchup in previousRound)
                {
                    currMatchup.Entries.Add(new ModelMatchupEntry { ParentMatchup = matchup });

                    if(currMatchup.Entries.Count > 1)
                    {
                        currMatchup.MatchupRound = round;
                        currRound.Add(currMatchup);
                        currMatchup = new ModelMatchup();
                    }
                }
                model.Rounds.Add(currRound);
                previousRound = currRound;
                currRound = new List<ModelMatchup>();
                round += 1;
            }
        }
        private static List<ModelMatchup> CreateFirstRound(int byes, List<ModelTeam> randomizedTeams)
        {
            List<ModelMatchup> output = new List<ModelMatchup>();
            ModelMatchup curr = new ModelMatchup();
            foreach (ModelTeam team in randomizedTeams)
            {
                curr.Entries.Add(new ModelMatchupEntry { TeamCompeting = team });
                if((byes > 0) || (curr.Entries.Count > 1))
                {
                    curr.MatchupRound = 1;
                    output.Add(curr);
                    curr = new ModelMatchup();

                    if (byes > 0) byes -= 1;
                }
            }
            return output;
        }
        private static int FindNumberOfByes(int rounds, int numberOfTeams)
        {
            int output = 0;
            int totalTeams = 1;
            for (int i = 1; i <= rounds; i++)
            {
                totalTeams *= 2;
            }
            output = totalTeams - numberOfTeams;

            return output;
        }
        private static int FindNumberOfRounds(int teamsCount)
        {

            int output = 1;
            int value = 2;

            while(value < teamsCount)
            {
                output += 1;
                value *= 2;
            }
            return output;
        }
        private static List<ModelTeam> RandomizeTeamOrder(List<ModelTeam> enteredTeams)
        {
            return enteredTeams.OrderBy((x) => Guid.NewGuid()).ToList();
        }
        public static void UpdateTournamentResults(ModelTournament model)
        {
            List<ModelMatchup> toScore = new List<ModelMatchup>();

            foreach (List<ModelMatchup> matchupList in model.Rounds)
            {
                foreach (ModelMatchup matchup in matchupList)
                {
                    if((matchup.Winner == null)&&(matchup.Entries.Any((x) => x.Score != 0))||(matchup.Entries.Count == 1))
                    {
                        toScore.Add(matchup);
                    }
                }
            }

            ScoreMatchups(toScore);
            
            

            //foreach (List<ModelMatchup> matchupList in model.Rounds)
            //{
            //    foreach (ModelMatchup matchup in matchupList)
            //    {
            //        foreach (ModelMatchupEntry entry in matchup.Entries)
            //        {
            //            if (entry.ParentMatchup != null)
            //            {
            //                if (entry.ParentMatchup.Id == model.Id)
            //                {
            //                    entry.TeamCompeting = model.Winner;
            //                    GlobalConfig.Connection.UpdateMatchup(matchup);
            //                }
            //            }
            //        }
            //    }
            //}
            //GlobalConfig.Connection.UpdateMatchup(model);
        }
        private static void ScoreMatchups(List<ModelMatchup> models)
        {
            string scoreDirection = ConfigurationManager.AppSettings["greatherWins"];

            foreach (ModelMatchup matchup in models)
            {
                if(matchup.Entries.Count == 1)
                {
                    matchup.Winner = matchup.Entries[0].TeamCompeting;
                    continue;
                }
                if (scoreDirection == "0")
                {
                    if (matchup.Entries[0].Score < matchup.Entries[1].Score)
                    {
                        matchup.Winner = matchup.Entries[0].TeamCompeting;
                    }
                    else if (matchup.Entries[1].Score < matchup.Entries[0].Score)
                    {
                        matchup.Winner = matchup.Entries[0].TeamCompeting;
                    }
                    else
                    {

                    }
                }
                else
                {

                }
            }
            
            //if (teamOneScore > teamTwoScore)
            //{
            //    model.Winner = model.Entries[0].TeamCompeting;
            //}
            //else if (teamOneScore < teamTwoScore)
            //{
            //    model.Winner = model.Entries[1].TeamCompeting;
            //}
            //else
            //{
            //    MessageBox.Show("I don't hanle tie games");
            //}
        }
    }
}
