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
        ModelPrize CreatePrize(ModelPrize model);
        ModelPerson CreatePerson(ModelPerson model);
        ModelTeam CreateTeam(ModelTeam model);
        ModelTournament CreateTournament(ModelTournament model);
        List<ModelPerson> GetPersonAll();
        List<ModelTeam> GetTeamAll();
    }
}
