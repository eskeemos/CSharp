using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace ClassLibrary3.DataAccess.TextHelpers
{
    public static class TextConnectorProcessor
    {
        public static string FullFilePath(this string fileName)
        {
            return $"{ConfigurationManager.AppSettings["filePath"]}\\{fileName}";
        }
        public static List<string> LoadFile(this string fileName)
        {
            if (!File.Exists(fileName))
            {
                return new List<string>();
            }

            return File.ReadAllLines(fileName).ToList();
        }
        public static List<ModelPrize> ConvertToPrizeModel(this List<string> lines)
        {
            List<ModelPrize> output = new List<ModelPrize>();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                ModelPrize m = new ModelPrize();
                m.ID = int.Parse(cols[0]);
                m.PlaceNumber = int.Parse(cols[1]);
                m.PlaceName = cols[2];
                m.PrizeAmount = decimal.Parse(cols[3]);
                m.PrizePercentage = double.Parse(cols[4]);
                output.Add(m);
            }

            return output;
        }
        public static List<ModelPerson> ConvertToPersonModel(this List<string> lines)
        {
            List<ModelPerson> output = new List<ModelPerson>();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                ModelPerson m = new ModelPerson();
                m.ID = int.Parse(cols[0]);
                m.FirstName = cols[1];
                m.LastName = cols[2];
                m.EmailAddress = cols[3];
                m.PhoneNumber = cols[4];
                output.Add(m);
            }

            return output;
        }
        public static List<ModelTeam> ConvertToTeamModel(this List<string> lines, string peopleFile)
        {
            List<ModelTeam> output = new List<ModelTeam>();
            List<ModelPerson> people = peopleFile.FullFilePath().LoadFile().ConvertToPersonModel();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                ModelTeam m = new ModelTeam();
                m.ID = int.Parse(cols[0]);
                m.TeamName = cols[1];

                string[] personIDs = cols[2].Split('|');

                foreach (string ID in personIDs)
                {
                    m.TeamMembers.Add(people.Where((x) => x.ID == int.Parse(ID)).FirstOrDefault());
                }
                output.Add(m);
            }
            return output;
        }
        private static string ConvertPeopleListString(List<ModelPerson> people)
        {
            string output = "";

            if (people.Count == 0)
            {
                return output;
            }

            foreach (ModelPerson m in people)
            {
                output += $"{m.ID}|";
            }

            return output.Substring(0, output.Length - 1);
        }
        private static string ConvertTeamListToString(List<ModelTeam> teams)
        {
            string output = "";

            if (teams.Count == 0)
            {
                return output;
            }

            foreach (ModelTeam m in teams)
            {
                output += $"{m.ID}|";
            }

            return output.Substring(0, output.Length - 1);
        }
        private static string ConvertPrizeListToString(List<ModelPrize> prizes)
        {
            string output = "";

            if (prizes.Count == 0) return "0";

            foreach (ModelPrize prize in prizes)
            {
                output += $"{prize.ID}";
            }
            return output;
        }
        public static List<ModelTournament> ConvertToTournamentModels(this List<string> lines, string teamFile, string peopleFile, string prizesFile)
        {
            List<ModelTournament> output = new List<ModelTournament>();
            List<ModelTeam> teams = teamFile.FullFilePath().LoadFile().ConvertToTeamModel(peopleFile);
            List<ModelPrize> prizes = prizesFile.FullFilePath().LoadFile().ConvertToPrizeModel();
            List<ModelMatchup> matchups = GlobalConfig.MatchupFile.FullFilePath().LoadFile().ConvertToMatchupModels();

            foreach(string line in lines)
            {
                string[] cols = line.Split(',');

                ModelTournament mt = new ModelTournament();
                mt.Id = int.Parse(cols[0]);
                mt.TournamentName = cols[1];
                mt.EntryFee = decimal.Parse(cols[2]);

                string[] teamIds = cols[3].Split('|');
                foreach(string id in teamIds)
                {
                    mt.EnteredTeams.Add(teams.Where((x) => x.ID == int.Parse(id)).First());
                }
                
                {
                    string[] prizeIds = cols[4].Split('|');
                    if(int.Parse(prizeIds[0]) != 0)
                    {
                        foreach (string id in prizeIds)
                        {
                            mt.Prizes.Add(prizes.Where((x) => x.ID == int.Parse(id)).First());
                        }
                    }
                }

                string[] rounds = cols[5].Split('|');

                foreach (string round in rounds)
                {
                    string[] msText = round.Split('^');
                    List<ModelMatchup> ms = new List<ModelMatchup>();

                    foreach (string item in msText)
                    {
                        ms.Add(matchups.Where((x) => x.Id == int.Parse(item)).First());
                    }
                    mt.Rounds.Add(ms);
                }

                output.Add(mt);
            }
            return output;
        }
        public static void SaveToTournamentFile(this List<ModelTournament> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (ModelTournament mt in models)
            {
                lines.Add($"{ mt.Id },{mt.TournamentName},{mt.EntryFee},{ConvertTeamListToString(mt.EnteredTeams)},{ConvertPrizeListToString(mt.Prizes)},{ConvertRoundListToString(mt.Rounds)}");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }
        private static string ConvertRoundListToString(List<List<ModelMatchup>> rounds)
        {
            string output = "";
            if(rounds.Count == 0)
            {
                return output;
            }
            foreach (List<ModelMatchup> round in rounds)
            {
                output += $"{ConvertMatchupListToString(round)}|";
            }
            return output.Substring(0, output.Length - 1);
        }
        private static string ConvertMatchupListToString(List<ModelMatchup> matchups)
        {
            string output = "";
            if(matchups.Count == 0)
            {
                return output;
            }
            foreach (ModelMatchup matchup in matchups)
            {
                output += $"{matchup.Id}^";
            }
            return output.Substring(0, output.Length - 1);
        }
        public static void SaveToPrizeFile(this List<ModelPrize> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (ModelPrize m in models)
            {
                lines.Add($"{m.ID},{m.PlaceNumber},{m.PlaceName},{m.PrizeAmount},{m.PrizePercentage}");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }
        public static void SaveToPeopleFile(this List<ModelPerson> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (ModelPerson m in models)
            {
                lines.Add($"{m.ID},{m.FirstName},{m.LastName},{m.EmailAddress},{m.PhoneNumber}");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }
        public static void SaveToTeamFile(this List<ModelTeam> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (ModelTeam m in models)
            {
                lines.Add($"{m.ID},{m.TeamName},{ConvertPeopleListString(m.TeamMembers)}");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }
        public static void SaveRoundsToFile(this ModelTournament model, string MatchupFile, string MatchupEntryModels)
        {
            foreach (List<ModelMatchup> round in model.Rounds)
            {
                foreach (ModelMatchup matchup in round)
                {
                    matchup.SaveMatchupToFile(MatchupFile, MatchupEntryModels);
                }
            }
        }
        private static List<ModelMatchup> ConvertToMatchupModels(this List<string> lines)
        {
            List<ModelMatchup> output = new List<ModelMatchup>();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                ModelMatchup mm = new ModelMatchup();
                mm.Id =  int.Parse(cols[0]);
                mm.Entries = ConvertStringToMatchupEntryModel(cols[1]);
                mm.Winner = LookeupTeamId(cols[2]);
                mm.MatchupRound = int.Parse(cols[3]);
                output.Add(mm);
            }

            return output;
        }    
        private static ModelTeam LookeupTeamId(string id)
        {
            List<string> teams = GlobalConfig.TeamFile.FullFilePath().LoadFile();

            foreach (string team in teams)
            {
                string[] cols = team.Split(',');

                if(cols[0] == id)
                {
                    List<string> matchItem = new List<string>();
                    matchItem.Add(team);
                    return matchItem.ConvertToTeamModel(GlobalConfig.PeopleFile).First();
                }
            }

            return null;
        }
        private static ModelMatchup LookupMatchupId(int id)
        {
            List<string> matchups = GlobalConfig.MatchupFile.FullFilePath().LoadFile();

            foreach (string match in matchups)
            {
                string[] cols = match.Split();

                if(cols[0] == Convert.ToString(id))
                {
                    List<string> matchItem = new List<string>();
                    matchItem.Add(match);
                    return matchItem.ConvertToMatchupModels().First();
                }
            }

            return null;
        }
        private static List<ModelMatchupEntry> ConvertToMatchupEntryModels(this List<string> lines)
        {
            List<ModelMatchupEntry> output = new List<ModelMatchupEntry>();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');
                ModelMatchupEntry m = new ModelMatchupEntry();
                m.Id = int.Parse(cols[0]);

                if(cols[1].Length == 0)
                {
                    m.TeamCompeting = null;
                }
                else
                {
                    m.TeamCompeting = LookeupTeamId(cols[1]);
                }

                m.Score = double.Parse(cols[2]);

                int pId = 0;
                if (int.TryParse(cols[3], out pId))
                {
                    m.ParentMatchup = LookupMatchupId(pId);
                }
                else
                {
                    m.ParentMatchup = null;
                }
                output.Add(m);
               
            }

            return output;
        }
        private static List<ModelMatchupEntry> ConvertStringToMatchupEntryModel(string input)
        {
            string[] ids = input.Split('|');
            List<ModelMatchupEntry> output = new List<ModelMatchupEntry>();
            List<string> entries = GlobalConfig.MatchupEntryModels.FullFilePath().LoadFile();
            List<string> matchingEntries = new List<string>();

            foreach (string id in ids)
            {
                foreach (string entry in entries)
                {
                    string[] cols = entry.Split(',');

                    if(cols[0] == id)
                    {
                        matchingEntries.Add(entry);
                    }
                }
            }

            output = matchingEntries.ConvertToMatchupEntryModels();

            return output;
        }
        private static void SaveMatchupToFile(this ModelMatchup matchup, string matchupFile, string matchupEntryFile)
        {
            List<ModelMatchup> matchups = GlobalConfig.MatchupFile.FullFilePath().LoadFile().ConvertToMatchupModels();

            int currentId = 1;

            if(matchups.Count > 0)
            {
                currentId = matchups.OrderByDescending((x) => x.Id).First().Id + 1;
            }

            matchup.Id = currentId;
            matchups.Add(matchup);

            foreach (ModelMatchupEntry entry in matchup.Entries)
            {
                entry.SaveEntryToFile(matchupEntryFile);
            }

            List<string> lines = new List<string>();
            foreach (ModelMatchup m in matchups)
            {
                string winnerId = "0";
                if (m.Winner != null) winnerId = m.Winner.ID.ToString();
                lines.Add($"{m.Id},{ConvertMatchupEntryListToString(m.Entries)},{winnerId},{m.MatchupRound}");
            }
            File.WriteAllLines(GlobalConfig.MatchupFile.FullFilePath(), lines);
            // Id, EntryIds, WinnerId, RoundId
            // 1, 1|2|3, 0, 1  
        }
        private static object ConvertMatchupEntryListToString(List<ModelMatchupEntry> entries)
        {
            string output = "";
            if (entries.Count == 0) return output;

            foreach (ModelMatchupEntry entry in entries)
            {
                output += $"{entry.Id}|";
            }

            return output.Substring(0, output.Length - 1);
        }
        private static void SaveEntryToFile(this ModelMatchupEntry entry, string fileName)
        {
            List<ModelMatchupEntry> entries = GlobalConfig.MatchupEntryModels.FullFilePath().LoadFile().ConvertToMatchupEntryModels();

            int currentId = 1;

            if (entries.Count > 0)
            {
                currentId = entries.OrderByDescending((x) => x.Id).First().Id + 1;
            }

            entry.Id = currentId;
            entries.Add(entry);

            List<string> lines = new List<string>();

            foreach (ModelMatchupEntry e in entries)
            {
                string parentMatchupId = "0";
                if (e.ParentMatchup != null) parentMatchupId = e.ParentMatchup.Id.ToString();
                string teamCompetingId = "0";
                if (e.TeamCompeting != null) teamCompetingId = e.TeamCompeting.ID.ToString();
                lines.Add($"{e.Id},{teamCompetingId},{e.Score},{parentMatchupId}");
            }

            File.WriteAllLines(GlobalConfig.MatchupEntryModels.FullFilePath(), lines);
            // Id, TeamCompetingId, Score, ParentMatchupId
            //  1, 1, 0, 0
        }
    }
}
