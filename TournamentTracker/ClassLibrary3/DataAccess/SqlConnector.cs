using Dapper;
using LogicLibrary;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    public class SqlConnector : IDataConnection
    {
        #region Variables

        private readonly IDbConnection conn = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("db_TournamentTracker"));

        #endregion

        #region InterfaceData

        public void CreatePerson(ModelPerson person)
        {
            using (conn)
            {
                var data = new DynamicParameters();

                data.Add("@FirstName", person.FirstName);
                data.Add("@LastName", person.LastName);
                data.Add("@EmailAddress", person.EmailAddress);
                data.Add("@PhoneNumber", person.PhoneNumber);
                data.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                conn.Execute("dbo.procPeople_insert", data, commandType: CommandType.StoredProcedure);

                person.ID = data.Get<int>("@Id");
            }
        }
        public void CreatePrize(ModelPrize prize)
        {
            using (conn)
            {
                var data = new DynamicParameters();
                data.Add("@PlaceNumber", prize.PlaceNumber);
                data.Add("@PlaceName", prize.PlaceName);
                data.Add("@PrizeAmount", prize.PrizeAmount);
                data.Add("@PrizePercentage", prize.PrizePercentage);
                data.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                conn.Execute("dbo.procPrizes_insert", data, commandType: CommandType.StoredProcedure);

                prize.ID = data.Get<int>("@Id");
            }
        }
        public void CreateTeam(ModelTeam team)
        {
            using (conn)
            {
                var data = new DynamicParameters();
                data.Add("TeamName", team.TeamName);
                data.Add("@Id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                conn.Execute("dbo.procTeams_insert", data, commandType: CommandType.StoredProcedure);

                team.ID = data.Get<int>("@Id");

                foreach (ModelPerson person in team.TeamMembers)
                {
                    data = new DynamicParameters();
                    data.Add("TeamId", team.ID);
                    data.Add("PersonId", person.ID);

                    conn.Execute("dbo.procTeamMembers_insert", data, commandType: CommandType.StoredProcedure);
                }
            }
        }
        public void CreateTournament(ModelTournament tournament)
        {
            SaveTournament(conn, tournament);

            SaveTournamentPrizes(conn, tournament);

            SaveTournamentEntries(conn, tournament);

            SaveTournamentRounds(conn, tournament);

            TournamentLogic.UpdateTournamentResults(tournament);
        }
        public void UpdateMatchup(ModelMatchup matchup)
        {
            using (conn)
            {
                var data = new DynamicParameters();
                if (matchup.Winner != null)
                {
                    data.Add("Id", matchup.Id);
                    data.Add("WinnerId", matchup.Winner.ID);
                    conn.Execute("dbo.procMatchups_update", data, commandType: CommandType.StoredProcedure);
                }

                foreach (ModelMatchupEntry entry in matchup.Entries)
                {
                    if (entry.TeamCompeting != null)
                    {
                        data = new DynamicParameters();
                        data.Add("Id", entry.Id);
                        data.Add("TeamCompetingId", entry.TeamCompeting.ID);
                        data.Add("Score", entry.Score);
                        conn.Execute("dbo.MatchupEntries_update", data, commandType: CommandType.StoredProcedure);
                    }
                }
            }
        }
        public List<ModelPerson> GetPersons()
        {
            using (conn)
            {
                return conn.Query<ModelPerson>("dbo.procPeople_getAll").ToList();
            }
        }
        public List<ModelTeam> GetTeams()
        {
            using (conn)
            {
                List<ModelTeam> teams = conn.Query<ModelTeam>("dbo.procTeams_getAll").ToList();

                foreach (ModelTeam team in teams)
                {
                    var data = new DynamicParameters();
                    data.Add("@TeamID", team.ID);
                    team.TeamMembers = conn.Query<ModelPerson>("dbo.procTeamMembers_getByTeam", data, commandType: CommandType.StoredProcedure).ToList();
                }

                return teams;
            }
        }
        public List<ModelTournament> GetTournaments()
        {
            using (conn)
            {
                List<ModelTournament> tournaments = conn.Query<ModelTournament>("dbo.procTournaments_getAll").ToList();
                var data = new DynamicParameters();

                foreach (ModelTournament tournament in tournaments)
                {
                    data.Add("@TournamentId", tournament.Id);
                    tournament.Prizes = conn.Query<ModelPrize>("dbo.procPrizes_getByTournament", data, commandType: CommandType.StoredProcedure).ToList();

                    data = new DynamicParameters();
                    data.Add("@TournamentId", tournament.Id);
                    tournament.EnteredTeams = conn.Query<ModelTeam>("dbo.procTeams_getByTournament", data, commandType: CommandType.StoredProcedure).ToList();

                    foreach (ModelTeam team in tournament.EnteredTeams)
                    {
                        data = new DynamicParameters();
                        data.Add("@TeamID");
                        team.TeamMembers = conn.Query<ModelPerson>("dbo.procTeamMembers_getByTeam", data, commandType: CommandType.StoredProcedure).ToList();
                    }

                    data = new DynamicParameters();
                    data.Add("@TournamentId", tournament.Id);

                    List<ModelMatchup> matchups = conn.Query<ModelMatchup>("dbo.procMatchups_getByTournament", data, commandType: CommandType.StoredProcedure).ToList();

                    foreach (ModelMatchup matchup in matchups)
                    {

                        data = new DynamicParameters();
                        data.Add("MatchupId", matchup.Id);
                        matchup.Entries = conn.Query<ModelMatchupEntry>("dbo.procEntries_getByMatchup", data, commandType: CommandType.StoredProcedure).ToList();

                        List<ModelTeam> teams = GetTeams();

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
                return tournaments;
            }
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