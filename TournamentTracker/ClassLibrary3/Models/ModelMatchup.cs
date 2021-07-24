using System.Collections.Generic;

namespace TrackerLibrary.Models
{
    public class ModelMatchup
    {
        public int Id { get; set; }
        public List<ModelMatchupEntry> Entries { get; set; } = new List<ModelMatchupEntry>();
        public int WinnerId { get; set; }
        public ModelTeam Winner { get; set; }
        public int MatchupRound { get; set; }
        public string DisplayName 
        {
            get
            {
                string output = "";
                foreach (ModelMatchupEntry model in Entries)
                {
                    if(model.TeamCompeting != null)
                    {
                        if (output.Length == 0)
                        {
                            output = model.TeamCompeting.TeamName;
                        }
                        else
                        {
                            output += $" vs. {model.TeamCompeting.TeamName}";
                        }
                    }
                    else
                    {
                        output = "Matchup Not Yet Determined";
                        break;
                    }
                }
                return output;
            }
        }
    }
}