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
