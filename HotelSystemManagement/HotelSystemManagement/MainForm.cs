using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HotelSystemManagement
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void Exit(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void Logout(object sender, EventArgs e)
        {
            Start login = new Start();
            login.Show();
            this.Hide();
        }
        private void ClientInfo(object sender, EventArgs e)
        {
            ClientInfo clientInfo = new ClientInfo();
            clientInfo.Show();
            this.Hide();
        }
        private void StaffInfo(object sender, EventArgs e)
        {
            StaffInfo staffInfo = new StaffInfo();
            staffInfo.Show();
            this.Hide();
        }
        private void ReservationInfo(object sender, EventArgs e)
        {
            ReservationsInfo resInfo = new ReservationsInfo();
            resInfo.Show();
            this.Hide();
        }
        private void RoomInfo(object sender, EventArgs e)
        {
            RoomInfo roomInfo = new RoomInfo();
            roomInfo.Show();
            this.Hide();
        }
    }
}
