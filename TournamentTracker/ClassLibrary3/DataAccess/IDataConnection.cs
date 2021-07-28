﻿using System.Collections.Generic;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    public interface IDataConnection
    {
        void CreatePrize(ModelPrize model);
        void CreatePerson(ModelPerson model);
        void CreateTeam(ModelTeam model);
        void CreateTournament(ModelTournament model);
        void UpdateMatchup(ModelMatchup model);
        List<ModelPerson> GetPersons();
        List<ModelTeam> GetTeams();
        List<ModelTournament> GetTournaments();
    }
}
