using ClassLibrary3;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    public class SqlConnector : IDataConnection
    {
        #region Variables

        private const string db = "db_TournamentTracker";

        #endregion

        #region InterfaceData

        public void CreatePerson(ModelPerson model)
        {
            using (IDbConnection conn = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                var dp = new DynamicParameters();
                dp.Add("@FirstName", model.FirstName);
                dp.Add("@LastName", model.LastName);
                dp.Add("@EmailAddress", model.EmailAddress);
                dp.Add("@PhoneNumber", model.PhoneNumber);
                dp.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                conn.Execute("dbo.procPeople_insert", dp, commandType: CommandType.StoredProcedure);

                model.ID = dp.Get<int>("@id");
            }
        }
        public void CreatePrize(ModelPrize model)
        {
            using (IDbConnection conn = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                var dp = new DynamicParameters();
                dp.Add("@PlaceNumber", model.PlaceNumber);
                dp.Add("@PlaceName", model.PlaceName);
                dp.Add("@PrizeAmount", model.PrizeAmount);
                dp.Add("@PrizePercentage", model.PrizePercentage);
                dp.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                conn.Execute("dbo.procPrizes_insert", dp, commandType: CommandType.StoredProcedure);

                model.ID = dp.Get<int>("@id");
            }
        }
        public void CreateTeam(ModelTeam model)
        {
            using (IDbConnection conn = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                var dp = new DynamicParameters();
                dp.Add("TeamName", model.TeamName);
                dp.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                conn.Execute("dbo.procTeams_insert", dp, commandType: CommandType.StoredProcedure);

                model.ID = dp.Get<int>("@id");

                foreach (ModelPerson tm in model.TeamMembers)
                {
                    dp = new DynamicParameters();
                    dp.Add("TeamID", model.ID);
                    dp.Add("PersonID", tm.ID);

                    conn.Execute("dbo.procTeamMembers_insert", dp, commandType: CommandType.StoredProcedure);
                }
            }
        }
        public void CreateTournament(ModelTournament model)
        {
            using (IDbConnection conn = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                SaveTournament(conn, model);

                SaveTournamentPrizes(conn, model);

                SaveTournamentEntries(conn, model);

                SaveTournamentRounds(conn, model);

                TournamentLogic.UpdateTournamentResults(model);
            }
        }
        public void UpdateMatchup(ModelMatchup model)
        {
            using (IDbConnection conn = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                var dp = new DynamicParameters();
                if (model.Winner != null)
                {
                    dp.Add("id", model.Id);
                    dp.Add("WinnerId", model.Winner.ID);
                    conn.Execute("dbo.procMatchups_update", dp, commandType: CommandType.StoredProcedure);
                }
                foreach (ModelMatchupEntry mme in model.Entries)
                {
                    if (mme.TeamCompeting != null)
                    {
                        dp = new DynamicParameters();
                        dp.Add("Id", mme.Id);
                        dp.Add("TeamCompetingId", mme.TeamCompeting.ID);
                        dp.Add("Score", mme.Score);
                        conn.Execute("dbo.MatchupEntries_update", dp, commandType: CommandType.StoredProcedure);
                    }
                }
            }
        }
        public List<ModelPerson> GetPersonAll()
        {
            List<ModelPerson> output;
            using (IDbConnection conn = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = conn.Query<ModelPerson>("dbo.procPeople_getAll").ToList();
            }
            return output;
        }
        public List<ModelTeam> GetTeamAll()
        {
            List<ModelTeam> output;

            using (IDbConnection conn = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                output = conn.Query<ModelTeam>("dbo.procTeams_getAll").ToList();

                foreach (ModelTeam team in output)
                {
                    var dp = new DynamicParameters();
                    dp.Add("@TeamID", team.ID);
                    team.TeamMembers = conn.Query<ModelPerson>("dbo.procTeamMembers_getByTeam", dp, commandType: CommandType.StoredProcedure).ToList();

                }
            }

            return output;
        }
        public List<ModelTournament> GetTournamentsAll()
        {
            List<ModelTournament> tournaments;

            using (IDbConnection conn = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString(db)))
            {
                tournaments = conn.Query<ModelTournament>("dbo.procTournaments_getAll").ToList();

                foreach (ModelTournament tournament in tournaments)
                {
                    var dp = new DynamicParameters();
                    dp.Add("@TournamentId", tournament.Id);
                    tournament.Prizes = conn.Query<ModelPrize>("dbo.procPrizes_getByTournament", dp, commandType: CommandType.StoredProcedure).ToList();

                    dp = new DynamicParameters();
                    dp.Add("@TournamentId", tournament.Id);
                    tournament.EnteredTeams = conn.Query<ModelTeam>("dbo.procTeams_getByTournament", dp, commandType: CommandType.StoredProcedure).ToList();

                    foreach (ModelTeam team in tournament.EnteredTeams)
                    {
                        dp = new DynamicParameters();
                        dp.Add("@TeamID");
                        team.TeamMembers = conn.Query<ModelPerson>("dbo.procTeamMembers_getByTeam", dp, commandType: CommandType.StoredProcedure).ToList();
                    }

                    dp = new DynamicParameters();
                    dp.Add("@TournamentId", tournament.Id);

                    List<ModelMatchup> matchups = conn.Query<ModelMatchup>("dbo.procMatchups_getByTournament", dp, commandType: CommandType.StoredProcedure).ToList();

                    foreach (ModelMatchup matchup in matchups)
                    {

                        dp = new DynamicParameters();
                        dp.Add("MatchupId", matchup.Id);
                        matchup.Entries = conn.Query<ModelMatchupEntry>("dbo.procEntries_getByMatchup", dp, commandType: CommandType.StoredProcedure).ToList();

                        List<ModelTeam> teams = GetTeamAll();

                        if (matchup.WinnerId > 0)
                        {
                            matchup.Winner = teams.Where((x) => x.ID == matchup.WinnerId).First();
                        }

                        foreach (var team in matchup.Entries)
                        {
                            if (team.TeamCompetingId > 0)
                            {
                                team.TeamCompeting = teams.Where((x) => x.ID == team.TeamCompetingId).First();
                            }
                            if (team.ParentMatchupId > 0)
                            {
                                team.ParentMatchup = matchups.Where((x) => x.Id == team.ParentMatchupId).First();
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
            }
            return tournaments;
        }

        #endregion

        #region DataSaving

        private void SaveTournamentRounds(IDbConnection conn, ModelTournament model)
        {
            foreach (List<ModelMatchup> round in model.Rounds)
            {
                foreach (ModelMatchup matchup in round)
                {
                    var dp = new DynamicParameters();
                    dp.Add("@TournamentId", model.Id);
                    dp.Add("@MatchupRound", matchup.MatchupRound);
                    dp.Add("@Id", 0, DbType.Int32, direction: ParameterDirection.Output);
                    conn.Execute("dbo.procMatchups_insert", dp, commandType: CommandType.StoredProcedure);

                    matchup.Id = dp.Get<int>("@Id");

                    foreach (ModelMatchupEntry entry in matchup.Entries)
                    {
                        dp = new DynamicParameters();
                        dp.Add("@MatchupID", matchup.Id);

                        if (entry.ParentMatchup == null)
                        {
                            dp.Add("@ParentMatchupID", null);
                        }
                        else
                        {
                            dp.Add("@ParentMatchupID", entry.ParentMatchup.Id);
                        }

                        if (entry.TeamCompeting == null)
                        {
                            dp.Add("@TeamCompetingID", null);
                        }
                        else
                        {
                            dp.Add("@TeamCompetingID", entry.TeamCompeting.ID);
                        }

                        dp.Add("@Id", 0, DbType.Int32, direction: ParameterDirection.Output);
                        conn.Execute("dbo.procMatchupEntries_insert", dp, commandType: CommandType.StoredProcedure);
                    }
                }
            }
        }
        private void SaveTournament(IDbConnection conn, ModelTournament model)
        {
            var dp = new DynamicParameters();
            dp.Add("@TournamentName", model.TournamentName);
            dp.Add("@EntryFee", model.EntryFee);
            dp.Add("@id", 0, DbType.Int32, direction: ParameterDirection.Output);
            conn.Execute("dbo.procTournaments_insert", dp, commandType: CommandType.StoredProcedure);

            model.Id = dp.Get<int>("@id");
        }
        private void SaveTournamentPrizes(IDbConnection conn, ModelTournament model)
        {
            foreach (ModelPrize prize in model.Prizes)
            {
                var dp = new DynamicParameters();
                dp.Add("@TournamentID", model.Id);
                dp.Add("PrizeID", prize.ID);
                dp.Add("@id", 0, DbType.Int32, direction: ParameterDirection.Output);
                conn.Execute("dbo.procTournamentPrizes_insert", dp, commandType: CommandType.StoredProcedure);
            }
        }
        private void SaveTournamentEntries(IDbConnection conn, ModelTournament model)
        {
            foreach (ModelTeam team in model.EnteredTeams)
            {
                var dp = new DynamicParameters();
                dp.Add("@TournamentID", model.Id);
                dp.Add("TeamID", team.ID);
                dp.Add("@id", 0, DbType.Int32, direction: ParameterDirection.Output);
                conn.Execute("dbo.procTournamentEntries_insert", dp, commandType: CommandType.StoredProcedure);
            }
        }

        #endregion

    }
}