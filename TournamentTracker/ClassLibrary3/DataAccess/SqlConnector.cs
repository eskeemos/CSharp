using Dapper;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    public class SqlConnector : IDataConnection // REFACTORED
    {
        #region Readonly

        private readonly string db = "TournamentTracker";

        #endregion

        #region Interface

        public void CreatePerson(ModelPerson person)
        {
            using (IDbConnection conn = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                var dP = new DynamicParameters();

                dP.Add("@FirstName", person.FirstName);
                dP.Add("@LastName", person.LastName);
                dP.Add("@EmailAddress", person.EmailAddress);
                dP.Add("@PhoneNumber", person.PhoneNumber);
                dP.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                conn.Execute("dbo.People_insert", dP, commandType: CommandType.StoredProcedure);

                person.Id = dP.Get<int>("@Id");
            }
        }  
        public void CreatePrize(ModelPrize prize)
        {
            using (IDbConnection conn = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                var dP = new DynamicParameters();

                dP.Add("@PlaceNumber", prize.PlaceNumber);
                dP.Add("@PlaceName", prize.PlaceName);
                dP.Add("@PrizeAmount", prize.PrizeAmount);
                dP.Add("@PrizePercentage", prize.PrizePercentage);
                dP.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                conn.Execute("dbo.Prizes_insert", dP, commandType: CommandType.StoredProcedure);

                prize.ID = dP.Get<int>("@Id");
            }
        }
        public void CreateTeam(ModelTeam team)
        {
            using (IDbConnection conn = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                var dP = new DynamicParameters();

                dP.Add("TeamName", team.TeamName);
                dP.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                conn.Execute("dbo.Teams_insert", dP, commandType: CommandType.StoredProcedure);

                team.Id = dP.Get<int>("@Id");

                foreach (ModelPerson person in team.TeamMembers)
                {
                    dP = new DynamicParameters();

                    dP.Add("TeamId", team.Id);
                    dP.Add("PersonId", person.Id);

                    conn.Execute("dbo.TeamMembers_insert", dP, commandType: CommandType.StoredProcedure);
                }
            }
        }
        public void CreateTournament(ModelTournament tournament)
        {
            using (IDbConnection conn = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                SaveTournament(conn, tournament);

                SaveTournamentPrizes(conn, tournament);

                SaveTournamentEntries(conn, tournament);

                SaveTournamentRounds(conn, tournament);

                Logic.AppLogic.UpdateTournamentResults(tournament);
            }
        }
        public void UpdateMatchup(ModelMatchup matchup)
        {
            using (IDbConnection conn = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                var dP = new DynamicParameters();

                if (matchup.Winner != null)
                {
                    dP.Add("Id", matchup.Id);
                    dP.Add("WinnerId", matchup.Winner.Id);

                    conn.Execute("dbo.Matchups_update", dP, commandType: CommandType.StoredProcedure);
                }

                foreach (ModelMatchupEntry entry in matchup.Entries)
                {
                    if (entry.TeamCompeting != null)
                    {
                        dP = new DynamicParameters();

                        dP.Add("Id", entry.Id);
                        dP.Add("TeamCompetingId", entry.TeamCompeting.Id);
                        dP.Add("Score", entry.Score);

                        conn.Execute("dbo.MatchupEntries_update", dP, commandType: CommandType.StoredProcedure);
                    }
                }
            }
        }
        public void CompleteTournament(ModelTournament model)
        {
            using (IDbConnection conn = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                var dp = new DynamicParameters();

                dp.Add("Id", model.Id);

                conn.Execute("dbo.Tournaments_complete", dp, commandType: CommandType.StoredProcedure);
            }
        }
        public List<ModelPerson> GetPersons()
        {
            using (IDbConnection conn = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                return conn.Query<ModelPerson>("dbo.People_getAll").ToList();
            }
        }
        public List<ModelTeam> GetTeams()
        {
            using (IDbConnection conn = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                List<ModelTeam> teams = conn.Query<ModelTeam>("dbo.Teams_getAll").ToList();

                foreach (ModelTeam team in teams)
                {
                    var data = new DynamicParameters();

                    data.Add("@TeamID", team.Id);
                    team.TeamMembers = conn.Query<ModelPerson>("dbo.TeamMembers_getByTeam", data, commandType: CommandType.StoredProcedure).ToList();
                }

                return teams;
            }
        }
        public List<ModelTournament> GetTournaments()
        {
            using (IDbConnection conn = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                List<ModelTournament> tournaments = conn.Query<ModelTournament>("dbo.Tournaments_getAll").ToList();

                foreach (ModelTournament tournament in tournaments)
                {
                    var data = new DynamicParameters();

                    data.Add("@TournamentId", tournament.Id);
                    tournament.Prizes = conn.Query<ModelPrize>("dbo.Prizes_getByTournament", data, commandType: CommandType.StoredProcedure).ToList();

                    data = new DynamicParameters();

                    data.Add("@TournamentId", tournament.Id);
                    tournament.EnteredTeams = conn.Query<ModelTeam>("dbo.Teams_getByTournament", data, commandType: CommandType.StoredProcedure).ToList();

                    foreach (ModelTeam team in tournament.EnteredTeams)
                    {
                        data = new DynamicParameters();

                        data.Add("@EntryId", team.Id);
                        team.TeamMembers = conn.Query<ModelPerson>("dbo.People_getByTeam", data, commandType: CommandType.StoredProcedure).ToList();
                    }

                    data = new DynamicParameters();

                    data.Add("@TournamentId", tournament.Id);
                    List<ModelMatchup> matchups = conn.Query<ModelMatchup>("dbo.Matchups_getByTournament", data, commandType: CommandType.StoredProcedure).ToList();

                    foreach (ModelMatchup matchup in matchups)
                    {
                        data = new DynamicParameters();

                        data.Add("MatchupId", matchup.Id);
                        matchup.Entries = conn.Query<ModelMatchupEntry>("dbo.MatchupEntries_getByTournament", data, commandType: CommandType.StoredProcedure).ToList();

                        List<ModelTeam> teams = GetTeams();

                        if (matchup.WinnerId > 0)
                        {
                            matchup.Winner = teams.Where((x) => x.Id == matchup.WinnerId).First();
                        }

                        foreach (var team in matchup.Entries)
                        {
                            if (team.TeamCompetingId > 0)
                            {
                                team.TeamCompeting = teams.Where((x) => x.Id == team.TeamCompetingId).First();
                            }
                            if (team.ParentMatchupId > 0)
                            {
                                team.ParentMatchup = matchups.Where((x) => x.Id == team.ParentMatchupId).FirstOrDefault();
                            }
                        }
                    }

                    List<ModelMatchup> Row = new List<ModelMatchup>();
                    int currRound = 1;

                    foreach (ModelMatchup matchup in matchups)
                    {
                        if (matchup.MatchupRound > currRound)
                        {
                            tournament.Rounds.Add(Row);
                            Row = new List<ModelMatchup>();
                            currRound += 1;
                        }
                        Row.Add(matchup);
                    }

                    tournament.Rounds.Add(Row);
                }
                return tournaments;
            }
        }

        #endregion

        #region DataSave

        private void SaveTournamentRounds(IDbConnection conn, ModelTournament tournament)
        {
            foreach (List<ModelMatchup> rounds in tournament.Rounds)
            {
                foreach (ModelMatchup matchup in rounds)
                {
                    var data = new DynamicParameters();

                    data.Add("@TournamentId", tournament.Id);
                    data.Add("@MatchupRound", matchup.MatchupRound);
                    data.Add("@Id", 0, DbType.Int32, direction: ParameterDirection.Output);

                    conn.Execute("dbo.Matchups_insert", data, commandType: CommandType.StoredProcedure);

                    matchup.Id = data.Get<int>("@Id");

                    foreach (ModelMatchupEntry entry in matchup.Entries)
                    {
                        data = new DynamicParameters();

                        data.Add("@MatchupID", matchup.Id);

                        if (entry.ParentMatchup == null) data.Add("@ParentMatchupId", null);
                        else data.Add("@ParentMatchupId", entry.ParentMatchup.Id);

                        if (entry.TeamCompeting == null) data.Add("@TeamCompetingId", null);
                        else data.Add("@TeamCompetingId", entry.TeamCompeting.Id);
                        
                        data.Add("@Id", 0, DbType.Int32, direction: ParameterDirection.Output);

                        conn.Execute("dbo.MatchupEntries_insert", data, commandType: CommandType.StoredProcedure);

                        entry.Id = data.Get<int>("@Id");
                    }
                }
            }
        }
        private void SaveTournament(IDbConnection conn, ModelTournament tournament)
        {
            var data = new DynamicParameters();

            data.Add("@TournamentName", tournament.TournamentName);
            data.Add("@EntryFee", tournament.EntryFee);
            data.Add("@Id", 0, DbType.Int32, direction: ParameterDirection.Output);

            conn.Execute("dbo.Tournaments_insert", data, commandType: CommandType.StoredProcedure);

            tournament.Id = data.Get<int>("@Id");
        }
        private void SaveTournamentPrizes(IDbConnection conn, ModelTournament tournament)
        {
            foreach (ModelPrize prize in tournament.Prizes)
            {
                var data = new DynamicParameters();

                data.Add("@TournamentId", tournament.Id);
                data.Add("PrizeId", prize.ID);
                data.Add("@Id", 0, DbType.Int32, direction: ParameterDirection.Output);

                conn.Execute("dbo.TournamentPrizes_insert", data, commandType: CommandType.StoredProcedure);
            }
        }
        private void SaveTournamentEntries(IDbConnection conn, ModelTournament tournament)
        {
            foreach (ModelTeam team in tournament.EnteredTeams)
            {
                var data = new DynamicParameters();

                data.Add("@TournamentId", tournament.Id);
                data.Add("TeamId", team.Id);
                data.Add("@Id", 0, DbType.Int32, direction: ParameterDirection.Output);

                conn.Execute("dbo.TournamentEntries_insert", data, commandType: CommandType.StoredProcedure);
            }
        }

        #endregion
    }
}