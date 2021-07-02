using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class ModelTeam
    {
        public string TeamName { get; set; }
        public List<ModelPerson> TeamMembers { get; set; } = new List<ModelPerson>();
    }
}
