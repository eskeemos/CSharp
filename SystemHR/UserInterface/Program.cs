using SysetemHR.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using SystemHR.UserInterface.Forms;
using SystemHR.UserInterface.Forms.Employees;

namespace UserInterface
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ConnectionType cnnType = GlobalConfig.CnnType;
            GlobalConfig.InitializeConnection(ConnectionType.Sql);

            Application.Run(new MainForm());
        }
    }
}