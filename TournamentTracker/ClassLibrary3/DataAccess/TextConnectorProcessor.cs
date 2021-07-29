using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace LogicLibrary.DataAccess.TextHelpers
{
    public static class TextConnectorProcessor // Refactored
    {
        #region ConvertDataToModel

        public static List<ModelPrize> ConvertToPrizeModel(this List<string> prizeLines)
        {
            List<ModelPrize> prizes = new List<ModelPrize>();

            foreach (string row in prizeLines)
            {
                string[] cols = row.Split(',');

                ModelPrize prize = new ModelPrize
                {
                    ID = int.Parse(cols[0]),
                    PlaceNumber = int.Parse(cols[1]),
                    PlaceName = cols[2],
                    PrizeAmount = decimal.Parse(cols[3]),
                    PrizePercentage = double.Parse(cols[4])
                };
                prizes.Add(prize);
            }

            return prizes;
        }
        public static List<ModelPerson> ConvertToPersonModel(this List<string> personLines)
        {
            List<ModelPerson> persons = new List<ModelPerson>();

            foreach (string row in personLines)
            {
                string[] cols = row.Split(',');

                ModelPerson person = new ModelPerson
                {
                    Id = int.Parse(cols[0]),
                    FirstName = cols[1],
                    LastName = cols[2],
                    EmailAddress = cols[3],
                    PhoneNumber = cols[4]
                };
                persons.Add(person);
            }

            return persons;
        }
        public static List<ModelTeam> ConvertToTeamModel(this List<string> teamLines)
        {
            List<ModelPerson> people = GlobalConfig.PeopleFile.FullFilePath().LoadFile().ConvertToPersonModel();
            List<ModelTeam> teams = new List<ModelTeam>();

            foreach (string row in teamLines)
            {
                string[] cols = row.Split(',');

                ModelTeam team = new ModelTeam
                {
                    ID = int.Parse(cols[0]),
                    TeamName = cols[1]
                };

                string[] personIDs = cols[2].Split('|');

                foreach (string ID in personIDs)
                {
                    team.TeamMembers.Add(people.Where((x) => x.Id == int.Parse(ID)).FirstOrDefault());
                }
                teams.Add(team);
            }
            return teams;
        }
        public static List<ModelTournament> ConvertToTournamentModels(this List<string> tournamentLines)
        {
            List<ModelTeam> teams = GlobalConfig.TeamFile.FullFilePath().LoadFile().ConvertToTeamModel();
            List<ModelPrize> prizes = GlobalConfig.PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModel();
            List<ModelMatchup> matchups = GlobalConfig.MatchupFile.FullFilePath().LoadFile().ConvertToMatchupModels();
            List<ModelTournament> tournaments = new List<ModelTournament>();
            
            foreach (string row in tournamentLines)
            {
                string[] cols = row.Split(',');

                ModelTournament tournament = new ModelTournament
                {
                    Id = int.Parse(cols[0]),
                    TournamentName = cols[1],
                    EntryFee = decimal.Parse(cols[2])
                };

                string[] teamIds = cols[3].Split('|');
                foreach (string id in teamIds)
                {
                    tournament.EnteredTeams.Add(teams.Where((x) => x.ID == int.Parse(id)).First());
                }

                string[] prizeIds = cols[4].Split('|');
                if (int.Parse(prizeIds[0]) != 0)
                {
                    foreach (string Id in prizeIds)
                    {
                        tournament.Prizes.Add(prizes.Where((x) => x.ID == int.Parse(Id)).First());
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
                    tournament.Rounds.Add(ms);
                }

                tournaments.Add(tournament);
            }
            return tournaments;
        }
        private static List<ModelMatchup> ConvertToMatchupModels(this List<string> matchupLines)
        {
            List<ModelMatchup> matchups = new List<ModelMatchup>();

            foreach (string row in matchupLines)
            {
                string[] cols = row.Split(',');

                ModelMatchup matchup = new ModelMatchup
                {
                    Id = int.Parse(cols[0]),
                    Entries = ConvertStringToMatchupEntryModel(cols[1]),
                    Winner = LookeupTeamId(cols[2]),
                    MatchupRound = int.Parse(cols[3])
                };
                matchups.Add(matchup);
            }

            return matchups;
        }
        private static List<ModelMatchupEntry> ConvertToMatchupEntryModels(this List<string> entryLines)
        {
            List<ModelMatchupEntry> entries = new List<ModelMatchupEntry>();

            foreach (string row in entryLines)
            {
                string[] cols = row.Split(',');
                ModelMatchupEntry entry = new ModelMatchupEntry
                {
                    Id = int.Parse(cols[0])
                };

                entry.TeamCompeting = (cols[1].Length == 0) ? null : LookeupTeamId(cols[1]);

                entry.Score = double.Parse(cols[2]);

                entry.ParentMatchup = (int.TryParse(cols[3], out int pId)) ? LookupMatchupId(Convert.ToString(pId)) : null;

                entries.Add(entry);
            }

            return entries;
        }

        #endregion

        #region ConvertListToModel

        private static string ConvertPeopleListToString(List<ModelPerson> persons)
        {
            string peopleList = "";

            if (persons.Count == 0) return peopleList;

            foreach (ModelPerson person in persons)
            {
                peopleList += $"{person.Id}|";
            }

            return peopleList.Substring(0, peopleList.Length - 1);
        }
        private static string ConvertTeamListToString(List<ModelTeam> teams)
        {
            string teamList = "";

            if (teams.Count == 0) return teamList;

            foreach (ModelTeam m in teams)
            {
                teamList += $"{m.ID}|";
            }

            return teamList.Substring(0, teamList.Length - 1);
        }
        private static string ConvertPrizeListToString(List<ModelPrize> prizes)
        {
            string prizeList = "";

            if (prizes.Count == 0) return prizeList;

            foreach (ModelPrize prize in prizes)
            {
                prizeList += $"{prize.ID}";
            }

            return prizeList;
        }
        private static string ConvertRoundListToString(List<List<ModelMatchup>> rounds)
        {
            string roundList = "";

            if (rounds.Count == 0) return roundList;
            
            foreach (List<ModelMatchup> round in rounds)
            {
                roundList += $"{ConvertMatchupListToString(round)}|";
            }

            return roundList.Substring(0, roundList.Length - 1);
        }
        private static string ConvertMatchupListToString(List<ModelMatchup> matchups)
        {
            string matchupList = "";

            if (matchups.Count == 0) return matchupList;
            
            foreach (ModelMatchup matchup in matchups)
            {
                matchupList += $"{matchup.Id}^";
            }

            return matchupList.Substring(0, matchupList.Length - 1);
        }
        private static string ConvertMatchupEntryListToString(List<ModelMatchupEntry> entries)
        {
            string entryList = "";

            if (entries.Count == 0) return entryList;

            foreach (ModelMatchupEntry entry in entries)
            {
                entryList += $"{entry.Id}|";
            }

            return entryList.Substring(0, entryList.Length - 1);
        }

        #endregion

        #region SaveToFile

        public static void SaveToPrizeFile(this List<ModelPrize> prizes)
        {
            List<string> prizeLines = new List<string>();

            foreach (ModelPrize prize in prizes)
            {
                prizeLines.Add($"{prize.ID},{prize.PlaceNumber},{prize.PlaceName},{prize.PrizeAmount},{prize.PrizePercentage}");
            }

            File.WriteAllLines(GlobalConfig.PrizesFile.FullFilePath(), prizeLines);
        }
        public static void SaveToTournamentFile(this List<ModelTournament> tournaments)
        {
            List<string> tournamentLines = new List<string>();

            foreach (ModelTournament tournament in tournaments)
            {
                tournamentLines.Add($"{ tournament.Id },{tournament.TournamentName},{tournament.EntryFee},{ConvertTeamListToString(tournament.EnteredTeams)},{ConvertPrizeListToString(tournament.Prizes)},{ConvertRoundListToString(tournament.Rounds)}");
            }

            File.WriteAllLines(GlobalConfig.TournamentFile.FullFilePath(), tournamentLines);
        }
        public static void SaveToPeopleFile(this List<ModelPerson> persons)
        {
            List<string> personLines = new List<string>();

            foreach (ModelPerson person in persons)
            {
                personLines.Add($"{person.Id},{person.FirstName},{person.LastName},{person.EmailAddress},{person.PhoneNumber}");
            }

            File.WriteAllLines(GlobalConfig.PeopleFile.FullFilePath(), personLines);
        }
        public static void SaveToTeamFile(this List<ModelTeam> teams)
        {
            List<string> teamLines = new List<string>();

            foreach (ModelTeam team in teams)
            {
                teamLines.Add($"{team.ID},{team.TeamName},{ConvertPeopleListToString(team.TeamMembers)}");
            }

            File.WriteAllLines(GlobalConfig.TeamFile.FullFilePath(), teamLines);
        }
        public static void SaveRoundsToFile(this ModelTournament tournament)
        {
            foreach (List<ModelMatchup> rounds in tournament.Rounds)
            {
                foreach (ModelMatchup matchup in rounds)
                {
                    matchup.SaveMatchupToFile();
                }
            }
        }
        private static void SaveMatchupToFile(this ModelMatchup matchup)
        {
            List<ModelMatchup> matchups = GlobalConfig.MatchupFile.FullFilePath().LoadFile().ConvertToMatchupModels();

            matchup.Id = (matchups.Count > 0) ? matchups.OrderByDescending((x) => x.Id).First().Id + 1 : 1;
            
            matchups.Add(matchup);

            foreach (ModelMatchupEntry entry in matchup.Entries)
            {
                entry.SaveEntryToFile();
            }

            List<string> matchupLines = new List<string>();
            foreach (ModelMatchup MatchupN in matchups)
            {
                string winnerId = "0";
                if (MatchupN.Winner != null) winnerId = MatchupN.Winner.ID.ToString();
                matchupLines.Add($"{MatchupN.Id},{ConvertMatchupEntryListToString(MatchupN.Entries)},{winnerId},{MatchupN.MatchupRound}");
            }
            File.WriteAllLines(GlobalConfig.MatchupFile.FullFilePath(), matchupLines);
        }
        private static void SaveEntryToFile(this ModelMatchupEntry entry)
        {
            List<ModelMatchupEntry> entries = GlobalConfig.MatchupEntryModels.FullFilePath().LoadFile().ConvertToMatchupEntryModels();

            entry.Id = (entries.Count > 0)? entries.OrderByDescending((x) => x.Id).First().Id + 1 : 1;

            entries.Add(entry);

            List<string> entryLines = new List<string>();

            foreach (ModelMatchupEntry entryN in entries)
            {
                string parentMatchupId = "0";
                if (entryN.ParentMatchup != null) parentMatchupId = entryN.ParentMatchup.Id.ToString();
                string teamCompetingId = "0";
                if (entryN.TeamCompeting != null) teamCompetingId = entryN.TeamCompeting.ID.ToString();
                entryLines.Add($"{entryN.Id},{teamCompetingId},{entryN.Score},{parentMatchupId}");
            }

            File.WriteAllLines(GlobalConfig.MatchupEntryModels.FullFilePath(), entryLines);
        }

        #endregion

        #region UpdateToFile

        public static void UpdateMatchupToFile(this ModelMatchup matchupM)
        {
            List<ModelMatchup> matchups = GlobalConfig.MatchupFile.FullFilePath().LoadFile().ConvertToMatchupModels();

            foreach (ModelMatchup matchup in matchups)
            {
                if (matchup.Id == matchupM.Id)
                {
                    matchups.Remove(matchup);
                }
            }

            matchups.Add(matchupM);

            foreach (ModelMatchupEntry entry in matchupM.Entries)
            {
                entry.UpdateEntryToFile();
            }

            List<string> matchupLines = new List<string>();
            foreach (ModelMatchup matchupN in matchups)
            {
                string winnerId = "0";
                if (matchupN.Winner != null) winnerId = matchupN.Winner.ID.ToString();
                matchupLines.Add($"{matchupN.Id},{ConvertMatchupEntryListToString(matchupN.Entries)},{winnerId},{matchupN.MatchupRound}");
            }
            File.WriteAllLines(GlobalConfig.MatchupFile.FullFilePath(), matchupLines);
        }
        public static void UpdateEntryToFile(this ModelMatchupEntry entryM)
        {
            List<ModelMatchupEntry> entries = GlobalConfig.MatchupEntryModels.FullFilePath().LoadFile().ConvertToMatchupEntryModels();

            foreach (ModelMatchupEntry entry in entries)
            {
                if (entry.Id == entryM.Id)
                {
                    entries.Remove(entry);
                }
            }
            
            entries.Add(entryM);

            List<string> entryLines = new List<string>();

            foreach (ModelMatchupEntry entry in entries)
            {
                string parentMatchupId = (entry.ParentMatchup != null) ? entry.ParentMatchup.Id.ToString() : "0";
                string teamCompetingId = (entry.TeamCompeting != null) ? entry.TeamCompeting.ID.ToString() : "0";
                entryLines.Add($"{entry.Id},{teamCompetingId},{entry.Score},{parentMatchupId}");
            }

            File.WriteAllLines(GlobalConfig.MatchupEntryModels.FullFilePath(), entryLines);
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
        private static List<ModelMatchupEntry> ConvertStringToMatchupEntryModel(string entryString)
        {
            string[] ids = entryString.Split('|');
            List<string> allEntries = GlobalConfig.MatchupEntryModels.FullFilePath().LoadFile();
            List<string> matchingEntries = new List<string>();

            foreach (string id in ids)
            {
                foreach (string entry in allEntries)
                {
                    string[] cols = entry.Split(',');

                    if (cols[0] == id)
                    {
                        matchingEntries.Add(entry);
                    }
                }
            }

            List<ModelMatchupEntry> entries = matchingEntries.ConvertToMatchupEntryModels();

            return entries;
        }
        private static ModelTeam LookeupTeamId(string teamId)
        {
            List<string> teamLines = GlobalConfig.TeamFile.FullFilePath().LoadFile();

            foreach (string row in teamLines)
            {
                string[] cols = row.Split(',');

                if (cols[0] == teamId)
                {
                    List<string> team = new List<string>
                    {
                        row
                    };
                    return team.ConvertToTeamModel().First();
                }
            }

            return null;
        }
        private static ModelMatchup LookupMatchupId(string matchupId)
        {
            List<string> matchupLines = GlobalConfig.MatchupFile.FullFilePath().LoadFile();

            foreach (string row in matchupLines)
            {
                string[] cols = row.Split(',');

                if (cols[0] == matchupId)
                {
                    List<string> matchup = new List<string>
                    {
                        row
                    };
                    return matchup.ConvertToMatchupModels().First();
                }
            }

            return null;
        }

        #endregion
    }
}
