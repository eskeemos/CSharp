using ClassLibrary3.DataAccess.TextHelpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrackerLibrary;
using TrackerLibrary.Models;

namespace TrackerUI
{
    public partial class TournamentDashboard : BaseSets
    {
        List<ModelTournament> tournaments = GlobalConfig.Connection.getTournamentsAll();
        public TournamentDashboard()
        {
            InitializeComponent();

            WireUpLists();
        }
        private void WireUpLists()
        {
            cbLoadTournamenst.DataSource = tournaments;
            cbLoadTournamenst.DisplayMember = "TournamentName";
        }

        private void bCreateTournament_Click(object sender, EventArgs e)
        {
            TournamentCreate form = new TournamentCreate();
            form.Show();
        }
    }
}
