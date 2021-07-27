using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    public interface IDataConnection
    {
        void CreatePrize(ModelPrize model);
        void CreatePerson(ModelPerson model);
        void CreateTeam(ModelTeam model);
        void CreateTournament(ModelTournament model);
        void UpdateMatchup(ModelMatchup model);
        List<ModelPerson> GetPersonAll();
        List<ModelTeam> GetTeamAll();
        List<ModelTournament> GetTournamentsAll();
    }
}
