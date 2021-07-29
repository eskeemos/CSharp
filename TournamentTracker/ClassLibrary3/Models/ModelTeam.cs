using System.Collections.Generic; // Refactored

namespace TrackerLibrary.Models
{
    public class ModelTeam
    {
        public int ID { get; set; }
        public string TeamName { get; set; }
        public List<ModelPerson> TeamMembers { get; set; } = new List<ModelPerson>();
    }
}
