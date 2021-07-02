﻿using System.Collections.Generic;

namespace TrackerLibrary
{
    public class ModelMatchup
    {
        public List<ModelMatchupEntry> Entries { get; set; } = new List<ModelMatchupEntry>();
        public ModelTeam Winner { get; set; }
        public int MatchupRound { get; set; }
    }
}