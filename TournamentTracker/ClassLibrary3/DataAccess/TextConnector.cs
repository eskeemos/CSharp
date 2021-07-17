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
        private const string TeamFile   = "TeamModel.csv";

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

        public ModelTeam CreateTeam(ModelTeam model)
        {
            List<ModelTeam> teams = TeamFile.FullFilePath().LoadFile().ConvertToTeamModel(PeopleFile);

            int currentID = 1;
            if (teams.Count > 0) currentID = teams.OrderByDescending((x) => x.ID).First().ID + 1;

            model.ID = currentID;

            teams.Add(model);

            teams.SaveToTeamFile(TeamFile);

            return model;
        }

        public List<ModelPerson> GetPersonAll()
        {
            return PeopleFile.FullFilePath().LoadFile().ConvertToPersonModel();
        }

        public List<ModelTeam> GetTeamAll()
        {
            return TeamFile.FullFilePath().LoadFile().ConvertToTeamModel(PeopleFile);
        }
    }
}
