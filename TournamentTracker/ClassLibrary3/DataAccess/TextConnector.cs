using TrackerLibrary.Models;
using LogicLibrary.DataAccess.TextHelpers;
using System.Collections.Generic;
using System.Linq;
using LogicLibrary;

namespace TrackerLibrary.DataAccess
{
    public class TextConnector : IDataConnection // Refactored
    {
        public void CreatePerson(ModelPerson person)
        {
            List<ModelPerson> peoples = GlobalConfig.PeopleFile.FullFilePath().LoadFile().ConvertToPersonModel();

            person.Id = (peoples.Count > 0) ? GlobalConfig.PeopleFile.FullFilePath().LoadFile().ConvertToPersonModel().First().Id + 1 : 1;

            peoples.Add(person);
            peoples.SaveToPeopleFile();
        }
        public void CreatePrize(ModelPrize prize)
        {
            List<ModelPrize> prizes = GlobalConfig.PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModel();

            prize.ID = (prizes.Count > 0) ? prizes.OrderByDescending((x) => x.ID).First().ID + 1 : 1;

            prizes.Add(prize);
            prizes.SaveToPrizeFile();
        }
        public void CreateTeam(ModelTeam team)
        {
            List<ModelTeam> teams = GlobalConfig.TeamFile.FullFilePath().LoadFile().ConvertToTeamModel();

            team.ID = (teams.Count > 0) ? teams.OrderByDescending((x) => x.ID).First().ID + 1 : 1;

            teams.Add(team);
            teams.SaveToTeamFile();
        }
        public void CreateTournament(ModelTournament tournament)
        {
            List<ModelTournament> tournaments = GlobalConfig.TournamentFile.FullFilePath().LoadFile().ConvertToTournamentModels();

            tournament.Id = (tournaments.Count > 0) ? tournaments.OrderByDescending((x) => x.Id).First().Id + 1 : 1;

            tournament.SaveRoundsToFile();

            tournaments.Add(tournament);

            tournaments.SaveToTournamentFile();

            TournamentLogic.UpdateTournamentResults(tournament);
        }
        public void UpdateMatchup(ModelMatchup matchup)
        {
            matchup.UpdateMatchupToFile();
        }
        public List<ModelPerson> GetPersons()
        {
            return GlobalConfig.PeopleFile.FullFilePath().LoadFile().ConvertToPersonModel();
        }
        public List<ModelTeam> GetTeams()
        {
            return GlobalConfig.TeamFile.FullFilePath().LoadFile().ConvertToTeamModel();
        }
        public List<ModelTournament> GetTournaments()
        {
            return GlobalConfig.TournamentFile.FullFilePath().LoadFile().ConvertToTournamentModels();
        }
        
    }
}
