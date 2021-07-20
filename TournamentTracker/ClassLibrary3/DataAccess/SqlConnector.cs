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
        private const string db = "db_TournamentTracker";
        public ModelPerson CreatePerson(ModelPerson model)
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

                return model;
            }
        }
        public ModelPrize CreatePrize(ModelPrize model)
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

                return model;
            }
        }
        public ModelTeam CreateTeam(ModelTeam model)
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
                    dp.Add("TeamID",model.ID);
                    dp.Add("PersonID", tm.ID);

                    conn.Execute("dbo.procTeamMembers_insert", dp, commandType: CommandType.StoredProcedure);
                }

                return model;
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
            }
        }
        private void SaveTournamentRounds(IDbConnection conn, ModelTournament model)
         {
            foreach (List<ModelMatchup> round in model.Rounds)
            {
                foreach (ModelMatchup matchup in round)
                {
                    var dp = new DynamicParameters();
                    dp.Add("@TournamentId",model.Id);
                    dp.Add("@MatchupRound",matchup.MatchupRound);
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
    }
}