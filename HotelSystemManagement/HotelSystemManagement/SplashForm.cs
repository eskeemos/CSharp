using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace HotelSystemManagement
{
    public partial class SplashForm : Form
    {
        public SplashForm()
        {
            InitializeComponent();
        }
        int startPoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startPoint++;
            if(startPoint == 50)
            {
                this.Hide();
                MainForm mf = new MainForm();
                mf.Show();
            }
        }
        private void SplashForm_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
