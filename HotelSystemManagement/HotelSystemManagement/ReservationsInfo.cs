using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HotelSystemManagement
{
    public partial class ReservationsInfo : Form
    {
        public ReservationsInfo()
        {
            InitializeComponent();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            DateHms.Text = DateTime.Now.ToLongTimeString();
        }

        private void ReservationsInfo_Load(object sender, EventArgs e)
        {
            DateHms.Text = DateTime.Now.ToLongTimeString();
            timer.Start();
            today = DateIn.Value;
        }
        DateTime today;
        
        private void ReservationGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DateIn_ValueChanged(object sender, EventArgs e)
        {
            int newDate = DateTime.Compare(DateIn.Value, today);   
            if(newDate < 0)
            {
                MessageBox.Show("Wrong Date For Reservation");
            }
        }

        private void DateOut_ValueChanged(object sender, EventArgs e)
        {
            int newDate = DateTime.Compare(DateOut.Value, DateIn.Value);
            if (newDate < 0)
            {
                MessageBox.Show("Wrong Date For Reservation");
            }
        }
    }
}
