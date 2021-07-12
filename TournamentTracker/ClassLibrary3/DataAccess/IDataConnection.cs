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
        List<ModelPerson> GetPersonAll();
        ModelTeam CreateTeam(ModelTeam model);
    }
}
