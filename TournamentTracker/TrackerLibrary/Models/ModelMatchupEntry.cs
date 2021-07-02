namespace TrackerLibrary
{
    public class ModelMatchupEntry
    {
        public ModelTeam TeamCompeting { get; set; }
        public double Score { get; set; }
        public ModelMatchup ParentMatchup { get; set; }
    }
}