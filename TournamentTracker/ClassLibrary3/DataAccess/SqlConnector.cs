using Dapper;
using System.Data;
using TrackerLibrary.Models;

namespace TrackerLibrary.DataAccess
{
    public class SqlConnector : IDataConnection
    {
        public ModelPerson CreatePerson(ModelPerson model)
        {
            using (IDbConnection conn = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("db_TournamentTracker")))
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
            using (IDbConnection conn = new System.Data.SqlClient.SqlConnection(GlobalConfig.CnnString("db_TournamentTracker")))
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
    }
}