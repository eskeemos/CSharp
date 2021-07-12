using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class ModelTeam
    {
        public int ID { get; set; }
        public string TeamName { get; set; }
        public List<ModelPerson> TeamMembers { get; set; } = new List<ModelPerson>();
    }
}
