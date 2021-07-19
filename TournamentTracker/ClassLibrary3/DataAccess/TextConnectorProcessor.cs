using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
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

            if (prizes.Count == 0) return output;

            foreach (ModelPrize prize in prizes)
            {
                output += $"{prize.ID}";
            }
            return output;
        }
        public static List<ModelTournament> ConvertToTournamentModels(this List<string> lines, string teamFile, string peopleFile, string prizesFile)
        {
            // id,tourName,entryeFee,(id|id- teams), (id|id - prizes), (rounds - id^id|id^id)
            List<ModelTournament> output = new List<ModelTournament>();
            List<ModelTeam> teams = teamFile.FullFilePath().LoadFile().ConvertToTeamModel(peopleFile);
            List<ModelPrize> prizes = prizesFile.FullFilePath().LoadFile().ConvertToPrizeModel();

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
                
                string[] prizeIds = cols[4].Split('|');
                foreach (string id in prizeIds)
                {
                    mt.Prizes.Add(prizes.Where((x) => x.ID == int.Parse(id)).First());
                }
            }
            return output;
        }
        public static void SaveToTournamentFile(this List<ModelTournament> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (ModelTournament mt in models)
            {
                lines.Add($@"{ mt.Id },
                    {mt.TournamentName},
                    {mt.EntryFee},
                    {ConvertTeamListToString(mt.EnteredTeams)},
                    {ConvertPrizeListToString(mt.Prizes)},
                    {ConvertRoundListToString(mt.Rounds)}");
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
                output += $"{matchup}^";
            }
            return output.Substring(0, output.Length - 1);
        }
        public static void SaveToPrizeFile(this List<ModelPrize> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (ModelPrize m in models)
            {
                lines.Add($"{m.ID}, {m.PlaceNumber}, {m.PlaceName}, {m.PrizeAmount}, {m.PrizePercentage}");
            }

            File.WriteAllLines(fileName.FullFilePath(), lines);
        }
        public static void SaveToPeopleFile(this List<ModelPerson> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (ModelPerson m in models)
            {
                lines.Add($"{m.ID}, {m.FirstName}, {m.LastName}, {m.EmailAddress}, {m.PhoneNumber}");
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
        
    }
}
