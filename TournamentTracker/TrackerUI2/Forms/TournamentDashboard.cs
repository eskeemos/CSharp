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
    public partial class TournamentDashboard : BaseSets // Refactored
    {
        readonly List<ModelTournament> tournaments = GlobalConfig.Connection.GetTournaments();
        public TournamentDashboard()
        {
            InitializeComponent();

            WireUpLists();
        }
        private void WireUpLists()
        {
            if(tournaments != null)
            {
                cbLoadTournaments.DataSource = tournaments;
                cbLoadTournaments.DisplayMember = "TournamentName";
            }
        }

        private void BCreateTournament_Click(object sender, EventArgs e)
        {
            TournamentCreate form = new TournamentCreate();
            form.Show();
        }

        private void BloadTournament_Click(object sender, EventArgs e)
        {
            
            ModelTournament tournament = (ModelTournament)cbLoadTournaments.SelectedItem;
            if(tournament != null)
            {
                TournamentViewer form = new TournamentViewer(tournament);
                form.Show();
            }
        }
    }
}
