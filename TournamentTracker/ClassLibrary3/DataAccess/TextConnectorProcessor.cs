using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace LogicLibrary.DataAccess.TextHelpers
{
    public static class TextConnectorProcessor
    {
        #region ConvertDataToModel

        public static List<ModelPrize> ConvertToPrizeModel(this List<string> lines)
        {
            List<ModelPrize> output = new List<ModelPrize>();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                ModelPrize m = new ModelPrize
                {
                    ID = int.Parse(cols[0]),
                    PlaceNumber = int.Parse(cols[1]),
                    PlaceName = cols[2],
                    PrizeAmount = decimal.Parse(cols[3]),
                    PrizePercentage = double.Parse(cols[4])
                };
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

                ModelPerson m = new ModelPerson
                {
                    ID = int.Parse(cols[0]),
                    FirstName = cols[1],
                    LastName = cols[2],
                    EmailAddress = cols[3],
                    PhoneNumber = cols[4]
                };
                output.Add(m);
            }

            return output;
        }
        public static List<ModelTeam> ConvertToTeamModel(this List<string> lines)
        {
            List<ModelTeam> output = new List<ModelTeam>();
            List<ModelPerson> people = GlobalConfig.PeopleFile.FullFilePath().LoadFile().ConvertToPersonModel();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                ModelTeam m = new ModelTeam
                {
                    ID = int.Parse(cols[0]),
                    TeamName = cols[1]
                };

                string[] personIDs = cols[2].Split('|');

                foreach (string ID in personIDs)
                {
                    m.TeamMembers.Add(people.Where((x) => x.ID == int.Parse(ID)).FirstOrDefault());
                }
                output.Add(m);
            }
            return output;
        }
        public static List<ModelTournament> ConvertToTournamentModels(this List<string> lines)
        {
            List<ModelTournament> output = new List<ModelTournament>();
            List<ModelTeam> teams = GlobalConfig.TeamFile.FullFilePath().LoadFile().ConvertToTeamModel();
            List<ModelPrize> prizes = GlobalConfig.PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModel();
            List<ModelMatchup> matchups = GlobalConfig.MatchupFile.FullFilePath().LoadFile().ConvertToMatchupModels();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                ModelTournament mt = new ModelTournament
                {
                    Id = int.Parse(cols[0]),
                    TournamentName = cols[1],
                    EntryFee = decimal.Parse(cols[2])
                };

                string[] teamIds = cols[3].Split('|');
                foreach (string id in teamIds)
                {
                    mt.EnteredTeams.Add(teams.Where((x) => x.ID == int.Parse(id)).First());
                }

                {
                    string[] prizeIds = cols[4].Split('|');
                    if (int.Parse(prizeIds[0]) != 0)
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
        private static List<ModelMatchup> ConvertToMatchupModels(this List<string> lines)
        {
            List<ModelMatchup> output = new List<ModelMatchup>();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                ModelMatchup mm = new ModelMatchup
                {
                    Id = int.Parse(cols[0]),
                    Entries = ConvertStringToMatchupEntryModel(cols[1]),
                    Winner = LookeupTeamId(cols[2]),
                    MatchupRound = int.Parse(cols[3])
                };
                output.Add(mm);
            }

            return output;
        }
        private static List<ModelMatchupEntry> ConvertToMatchupEntryModels(this List<string> lines)
        {
            List<ModelMatchupEntry> output = new List<ModelMatchupEntry>();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');
                ModelMatchupEntry m = new ModelMatchupEntry
                {
                    Id = int.Parse(cols[0])
                };

                if (cols[1].Length == 0)
                {
                    m.TeamCompeting = null;
                }
                else
                {
                    m.TeamCompeting = LookeupTeamId(cols[1]);
                }

                m.Score = double.Parse(cols[2]);

                if (int.TryParse(cols[3], out int pId))
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

        #endregion

        #region ConvertListToModel

        private static string ConvertPeopleListToString(List<ModelPerson> people)
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
        private static string ConvertRoundListToString(List<List<ModelMatchup>> rounds)
        {
            string output = "";
            if (rounds.Count == 0)
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
            if (matchups.Count == 0)
            {
                return output;
            }
            foreach (ModelMatchup matchup in matchups)
            {
                output += $"{matchup.Id}^";
            }
            return output.Substring(0, output.Length - 1);
        }
        private static string ConvertMatchupEntryListToString(List<ModelMatchupEntry> entries)
        {
            string output = "";
            if (entries.Count == 0) return output;

            foreach (ModelMatchupEntry entry in entries)
            {
                output += $"{entry.Id}|";
            }

            return output.Substring(0, output.Length - 1);
        }

        #endregion

        #region SaveToFile

        public static void SaveToPrizeFile(this List<ModelPrize> models)
        {
            List<string> lines = new List<string>();

            foreach (ModelPrize m in models)
            {
                lines.Add($"{m.ID},{m.PlaceNumber},{m.PlaceName},{m.PrizeAmount},{m.PrizePercentage}");
            }

            File.WriteAllLines(GlobalConfig.PrizesFile.FullFilePath(), lines);
        }
        public static void SaveToTournamentFile(this List<ModelTournament> models)
        {
            List<string> lines = new List<string>();

            foreach (ModelTournament mt in models)
            {
                // 1,TournamentName,25,1|2|3,1|2,1^2|3
                lines.Add($"{ mt.Id },{mt.TournamentName},{mt.EntryFee},{ConvertTeamListToString(mt.EnteredTeams)},{ConvertPrizeListToString(mt.Prizes)},{ConvertRoundListToString(mt.Rounds)}");
            }

            File.WriteAllLines(GlobalConfig.TournamentFile.FullFilePath(), lines);
        }
        public static void SaveToPeopleFile(this List<ModelPerson> models)
        {
            List<string> lines = new List<string>();

            foreach (ModelPerson m in models)
            {
                lines.Add($"{m.ID},{m.FirstName},{m.LastName},{m.EmailAddress},{m.PhoneNumber}");
            }

            File.WriteAllLines(GlobalConfig.PeopleFile.FullFilePath(), lines);
        }
        public static void SaveToTeamFile(this List<ModelTeam> models)
        {
            List<string> lines = new List<string>();

            foreach (ModelTeam m in models)
            {
                lines.Add($"{m.ID},{m.TeamName},{ConvertPeopleListToString(m.TeamMembers)}");
            }

            File.WriteAllLines(GlobalConfig.TeamFile.FullFilePath(), lines);
        }
        public static void SaveRoundsToFile(this ModelTournament model)
        {
            foreach (List<ModelMatchup> round in model.Rounds)
            {
                foreach (ModelMatchup matchup in round)
                {
                    matchup.SaveMatchupToFile();
                }
            }
        }
        private static void SaveMatchupToFile(this ModelMatchup matchup)
        {
            List<ModelMatchup> matchups = GlobalConfig.MatchupFile.FullFilePath().LoadFile().ConvertToMatchupModels();

            int currentId = 1;

            if (matchups.Count > 0)
            {
                currentId = matchups.OrderByDescending((x) => x.Id).First().Id + 1;
            }

            matchup.Id = currentId;
            matchups.Add(matchup);

            foreach (ModelMatchupEntry entry in matchup.Entries)
            {
                entry.SaveEntryToFile();
            }

            List<string> lines = new List<string>();
            foreach (ModelMatchup m in matchups)
            {
                string winnerId = "0";
                if (m.Winner != null) winnerId = m.Winner.ID.ToString();
                lines.Add($"{m.Id},{ConvertMatchupEntryListToString(m.Entries)},{winnerId},{m.MatchupRound}");
            }
            File.WriteAllLines(GlobalConfig.MatchupFile.FullFilePath(), lines);
        }
        private static void SaveEntryToFile(this ModelMatchupEntry entry)
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

        #endregion

        #region UpdateToFile

        public static void UpdateMatchupToFile(this ModelMatchup matchup)
        {
            List<ModelMatchup> matchups = GlobalConfig.MatchupFile.FullFilePath().LoadFile().ConvertToMatchupModels();
            ModelMatchup oldMatchup = new ModelMatchup();

            foreach (ModelMatchup mm in matchups)
            {
                if (mm.Id == matchup.Id)
                {
                    oldMatchup = mm;
                }
            }

            matchups.Remove(oldMatchup);
            matchups.Add(matchup);

            foreach (ModelMatchupEntry entry in matchup.Entries)
            {
                entry.UpdateEntryToFile();
            }

            List<string> lines = new List<string>();
            foreach (ModelMatchup m in matchups)
            {
                string winnerId = "0";
                if (m.Winner != null) winnerId = m.Winner.ID.ToString();
                lines.Add($"{m.Id},{ConvertMatchupEntryListToString(m.Entries)},{winnerId},{m.MatchupRound}");
            }
            File.WriteAllLines(GlobalConfig.MatchupFile.FullFilePath(), lines);
        }
        public static void UpdateEntryToFile(this ModelMatchupEntry entry)
        {
            List<ModelMatchupEntry> entries = GlobalConfig.MatchupEntryModels.FullFilePath().LoadFile().ConvertToMatchupEntryModels();
            ModelMatchupEntry oldEntry = new ModelMatchupEntry();

            foreach (ModelMatchupEntry item in entries)
            {
                if (item.Id == entry.Id)
                {
                    oldEntry = item;
                }
            }
            entries.Remove(oldEntry);
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

        #endregion

        #region Helpers

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
        private static List<ModelMatchupEntry> ConvertStringToMatchupEntryModel(string input)
        {
            string[] ids = input.Split('|');
            List<string> entries = GlobalConfig.MatchupEntryModels.FullFilePath().LoadFile();
            List<string> matchingEntries = new List<string>();

            foreach (string id in ids)
            {
                foreach (string entry in entries)
                {
                    string[] cols = entry.Split(',');

                    if (cols[0] == id)
                    {
                        matchingEntries.Add(entry);
                    }
                }
            }

            List<ModelMatchupEntry> output = matchingEntries.ConvertToMatchupEntryModels();

            return output;
        }
        private static ModelTeam LookeupTeamId(string id)
        {
            List<string> teams = GlobalConfig.TeamFile.FullFilePath().LoadFile();

            foreach (string team in teams)
            {
                string[] cols = team.Split(',');

                if (cols[0] == id)
                {
                    List<string> matchItem = new List<string>
                    {
                        team
                    };
                    return matchItem.ConvertToTeamModel().First();
                }
            }

            return null;
        }
        private static ModelMatchup LookupMatchupId(int id)
        {
            List<string> matchups = GlobalConfig.MatchupFile.FullFilePath().LoadFile();

            foreach (string match in matchups)
            {
                string[] cols = match.Split(',');

                if (cols[0] == Convert.ToString(id))
                {
                    List<string> matchItem = new List<string>
                    {
                        match
                    };
                    return matchItem.ConvertToMatchupModels().First();
                }
            }

            return null;
        }

        #endregion
    }
}
