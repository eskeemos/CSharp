using TrackerLibrary.Models;
using ClassLibrary3.DataAccess.TextHelpers;
using System.Collections.Generic;
using System.Linq;

namespace TrackerLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        private const string PrizesFile = "PrizeModels.csv";
        private const string PeopleFile = "PersonModels.csv";

        public ModelPerson CreatePerson(ModelPerson model)
        {
            List<ModelPerson> peoples = PeopleFile.FullFilePath().LoadFile().ConvertToPersonModel();

            int currentID = 1;
            if (peoples.Count > 0) currentID = PeopleFile.FullFilePath().LoadFile().ConvertToPersonModel().First().ID + 1;

            model.ID = currentID;

            peoples.Add(model);

            peoples.SaveToPeopleFile(PeopleFile);

            return model;
        }

        public ModelPrize CreatePrize(ModelPrize model)
        {
            List<ModelPrize> prizes = PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModel();

            int currentID = 1;
            if (prizes.Count > 0) currentID = prizes.OrderByDescending((x) => x.ID).First().ID + 1;

            model.ID = currentID;

            prizes.Add(model);

            prizes.SaveToPrizeFile(PrizesFile);

            return model;
        }
    }
}
