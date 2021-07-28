using TrackerLibrary.Models;
using ClassLibrary3.DataAccess.TextHelpers;
using System.Collections.Generic;
using System.Linq;
using ClassLibrary3;

namespace TrackerLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        public void CreatePerson(ModelPerson model)
        {
            List<ModelPerson> peoples = GlobalConfig.PeopleFile.FullFilePath().LoadFile().ConvertToPersonModel();

            int currentID = 1;
            if (peoples.Count > 0) currentID = GlobalConfig.PeopleFile.FullFilePath().LoadFile().ConvertToPersonModel().First().ID + 1;

            model.ID = currentID;

            peoples.Add(model);

            peoples.SaveToPeopleFile();
        }
        public void CreatePrize(ModelPrize model)
        {
            List<ModelPrize> prizes = GlobalConfig.PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModel();

            int currentID = 1;
            if (prizes.Count > 0) currentID = prizes.OrderByDescending((x) => x.ID).First().ID + 1;

            model.ID = currentID;

            prizes.Add(model);

            prizes.SaveToPrizeFile();
        }
        public void CreateTeam(ModelTeam model)
        {
            List<ModelTeam> teams = GlobalConfig.TeamFile.FullFilePath().LoadFile().ConvertToTeamModel();

            int currentID = 1;
            if (teams.Count > 0) currentID = teams.OrderByDescending((x) => x.ID).First().ID + 1;

            model.ID = currentID;

            teams.Add(model);

            teams.SaveToTeamFile();
        }
        public void CreateTournament(ModelTournament model)
        {
            List<ModelTournament> tournaments = GlobalConfig.TournamentFile.FullFilePath().LoadFile().ConvertToTournamentModels();

            int currentId = 1;

            if(tournaments.Count > 0)
            {
                currentId = tournaments.OrderByDescending((x) => x.Id).First().Id + 1;
            }

            model.Id = currentId;

            model.SaveRoundsToFile();

            tournaments.Add(model);

            tournaments.SaveToTournamentFile();

            TournamentLogic.UpdateTournamentResults(model);
        }
        public void UpdateMatchup(ModelMatchup model)
        {
            model.UpdateMatchupToFile();
        }
        public List<ModelPerson> GetPersonAll()
        {
            return GlobalConfig.PeopleFile.FullFilePath().LoadFile().ConvertToPersonModel();
        }
        public List<ModelTeam> GetTeamAll()
        {
            return GlobalConfig.TeamFile.FullFilePath().LoadFile().ConvertToTeamModel();
        }
        public List<ModelTournament> GetTournamentsAll()
        {
            return GlobalConfig.TournamentFile.FullFilePath().LoadFile().ConvertToTournamentModels();
        }
        
    }
}
