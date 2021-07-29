using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary.DataAccess;
using static TrackerLibrary.Enums;

namespace TrackerLibrary
{
    
    public static class GlobalConfig // Refactored
    {

        public const string
            PrizesFile = "PrizeModels.csv",
            PeopleFile = "PersonModels.csv",
            TeamFile = "TeamModel.csv",
            TournamentFile = "TournamentModels.csv",
            MatchupFile = "MatchupModels.csv",
            MatchupEntryModels = "MatchupEntryModels.csv";
        public static IDataConnection Connection { get; private set; }
        public static void InitializeConnections(DatabaseType db)
        {
            switch (db)
            {
                case DatabaseType.Sql:
                    SqlConnector sql = new SqlConnector();
                    Connection = sql;
                    break;
                case DatabaseType.TextFiles:
                    TextConnector txt = new TextConnector();
                    Connection = txt;
                    break;
                default:
                    break;
            }
        }
        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }

    }
}
