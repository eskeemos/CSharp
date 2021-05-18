using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HotelSystemManagement
{
    public partial class ReservationsInfo : Form
    {
        SqlConnection Con = new SqlConnection(@"Data Source=DESKTOP-DABF71C;Initial Catalog=hotel_db;Integrated Security=True");
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
                MessageBox.Show("Enter correct DateIn");
            }
        }

        private void DateOut_ValueChanged(object sender, EventArgs e)
        {
            int newDate = DateTime.Compare(DateOut.Value, DateIn.Value);
            if (newDate < 0)
            {
                MessageBox.Show("Enter correct DateOut");
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand sql = new SqlCommand($"INSERT INTO Reservation_tab VALUES('{ClientName.Text}',{RoomNumber.Text},'{DateIn.Text}','{DateOut.Text}')", Con);
            sql.ExecuteNonQuery();
            Con.Close();
            MessageBox.Show("Reservation Added successfully");
        }
    }
}
