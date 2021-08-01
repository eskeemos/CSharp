namespace TrackerLibrary.Models
{
    public class ModelMatchupEntry // REFACTORED
    {
        public int Id { get; set; }
        public int TeamCompetingId { get; set; }
        public ModelTeam TeamCompeting { get; set; }
        public double Score { get; set; }
        public int ParentMatchupId { get; set; }
        public ModelMatchup ParentMatchup { get; set; }
    }
}