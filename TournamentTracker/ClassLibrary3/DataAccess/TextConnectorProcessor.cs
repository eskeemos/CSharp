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
    }
}
