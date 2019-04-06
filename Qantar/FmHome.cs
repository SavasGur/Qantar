using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qantar
{
    public partial class FmHome : Form
    {
        string connectionString = @"Data Source=IDEAPAD-SAV;Initial Catalog=QantarDB;Integrated Security=True";
        public FmHome()
        {
            InitializeComponent();

            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlData = new SqlDataAdapter("Select * from VehiclesIN",sqlCon);
                DataTable dtbl = new DataTable();
                sqlData.Fill(dtbl);

                dgVecIN.DataSource = dtbl;

            }

            timer1.Start();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            FmLogin objFmLogin = new FmLogin();
            this.Close();
            objFmLogin.Show();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            FmAdd objFmAdd = new FmAdd();
            this.Close();
            objFmAdd.Show();
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            FmOut objFmOut = new FmOut();
            this.Close();
            objFmOut.Show();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            FmReport objFmReport = new FmReport();
            this.Close();
            objFmReport.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime t = DateTime.Now;
            this.labeldt.Text = t.ToString("MM/dd/yyyy HH:mm:ss");
        }
    }
}
