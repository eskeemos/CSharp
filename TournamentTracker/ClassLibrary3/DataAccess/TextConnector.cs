using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        public ModelPrize CreatePrize(ModelPrize model)
        {
            model.ID = 1;

            return model;
        }
    }
}
