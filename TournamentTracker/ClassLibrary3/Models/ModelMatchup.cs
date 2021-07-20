﻿using System.Collections.Generic;

namespace TrackerLibrary.Models
{
    public class ModelMatchup
    {
        public int Id { get; set; }
        public List<ModelMatchupEntry> Entries { get; set; } = new List<ModelMatchupEntry>();
        public ModelTeam Winner { get; set; }
        public int MatchupRound { get; set; }
    }
}