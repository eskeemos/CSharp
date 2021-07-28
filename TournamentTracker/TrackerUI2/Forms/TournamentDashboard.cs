using LogicLibrary.DataAccess.TextHelpers;
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
        List<ModelTournament> tournaments = GlobalConfig.Connection.GetTournaments();
        public TournamentDashboard()
        {
            InitializeComponent();

            WireUpLists();
        }
        private void WireUpLists()
        {
            cbLoadTournaments.DataSource = tournaments;
            cbLoadTournaments.DisplayMember = "TournamentName";
        }

        private void bCreateTournament_Click(object sender, EventArgs e)
        {
            TournamentCreate form = new TournamentCreate();
            form.Show();
        }

        private void bLoadTournament_Click(object sender, EventArgs e)
        {
            ModelTournament model = (ModelTournament)cbLoadTournaments.SelectedItem;
            TournamentViewer form = new TournamentViewer(model);
            form.Show();
        }
    }
}
