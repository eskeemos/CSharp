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
        DateTime today;
        public ReservationsInfo()
        {
            InitializeComponent();
        }
        private void ShowRefreshData()
        {
            Con.Open();
            SqlDataAdapter getData = new SqlDataAdapter("SELECT * FROM Reservation_tab",Con);
            var getSpace = new DataSet();
            getData.Fill(getSpace);
            ReservationGridView.DataSource = getSpace.Tables[0];
            Con.Close();
        }
        private void timer_Tick(object sender, EventArgs e)
        {
            DateHms.Text = DateTime.Now.ToLongTimeString();
        }

        private void ReservationsInfo_Load(object sender, EventArgs e)
        {

            DateHms.Text = DateTime.Now.ToLongTimeString();
            ShowRefreshData();
            timer.Start();
            today = DateIn.Value;
            FillNameCombo();
            FillRoomCombo();
        }
        private void ReservationGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                ReservationID.Text = ReservationGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                //s.Text = ReservationGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                //RoomNumbers.Text = ReservationGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                DateIn.Text = ReservationGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
                DateOut.Text = ReservationGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }

        private void FillNameCombo()
        {
            
            Con.Open();
            SqlCommand sql = new SqlCommand("SELECT DISTINCT ClientName FROM Client_tab;", Con);
            SqlDataReader getReader = sql.ExecuteReader();
            DataTable getPlace = new DataTable();
            getPlace.Columns.Add("ClientName", typeof(string));
            getPlace.Load(getReader);
            ClientName.ValueMember = "ClientName";
            ClientName.DataSource = getPlace;
            Con.Close();
            
        }
        private void FillRoomCombo()
        {
            Con.Open();
            SqlCommand sql = new SqlCommand("SELECT RoomID FROM Room_tab;", Con);
            SqlDataReader getReader = sql.ExecuteReader();
            DataTable getPlace = new DataTable();
            getPlace.Columns.Add("RoomID", typeof(string));
            getPlace.Load(getReader);
            RoomNumber.ValueMember = "RoomID";
            RoomNumber.DataSource = getPlace;
            Con.Close();
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            int w1 = DateTime.Compare(DateIn.Value, today);
            int w2 = DateTime.Compare(DateOut.Value, DateIn.Value);
            if((w1 < 0)||(w2 < 0))
            {
                MessageBox.Show("Enter correct Date data");
            }
            else
            {
                Con.Open();
                SqlCommand sql = new SqlCommand($"INSERT INTO Reservation_tab VALUES('{ClientName.SelectedItem.ToString()}',{RoomNumber.SelectedItem.ToString()},'{DateIn.Value.ToShortDateString()}','{DateOut.Value.ToShortDateString()}')", Con);
                sql.ExecuteNonQuery();
                Con.Close();
                ShowRefreshData();
                MessageBox.Show("Reservation Added successfully.");
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            Con.Open();
            SqlCommand sql = new SqlCommand($"DELETE FROM Reservation_tab WHERE ResID = {ReservationID.Text}",Con);
            sql.ExecuteNonQuery();
            Con.Close();
            ShowRefreshData();
            MessageBox.Show("Reservation deleted successfully.");
        }

        private void Reset_Click(object sender, EventArgs e)
        {
            ShowRefreshData();
        }
    }
}
