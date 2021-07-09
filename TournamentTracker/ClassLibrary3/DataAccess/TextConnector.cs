using TrackerLibrary.Models;
using ClassLibrary3.DataAccess.TextHelpers;
using System.Collections.Generic;
using System.Linq;

namespace TrackerLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        private const string PrizesFile = "PrizeModels.csv";
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
