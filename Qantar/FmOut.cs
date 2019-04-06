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
    public partial class FmOut : Form
    {
        string connectionString = @"Data Source=IDEAPAD-SAV;Initial Catalog=QantarDB;Integrated Security=True";
        public FmOut()
        {
            InitializeComponent();
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                sqlCon.Open();
                SqlDataAdapter sqlData = new SqlDataAdapter("Select * from VehiclesIN", sqlCon);
                DataTable dtbl = new DataTable();
                sqlData.Fill(dtbl);

                dgVecIN.DataSource = dtbl;

            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            FmHome objFmHome = new FmHome();
            this.Close();
            objFmHome.Show();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            FmAdd objFmAdd = new FmAdd();
            this.Close();
            objFmAdd.Show();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPlate.Text))
            {
                MessageBox.Show("Lütfen Boş Alan Bırakmayınız.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrWhiteSpace(txtDriver.Text))
            {
                MessageBox.Show("Lütfen Boş Alan Bırakmayınız.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrWhiteSpace(txtWi.Text))
            {
                MessageBox.Show("Lütfen Boş Alan Bırakmayınız.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrWhiteSpace(txtWo.Text))
            {
                MessageBox.Show("Lütfen Boş Alan Bırakmayınız.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrWhiteSpace(txtPw.Text))
            {
                MessageBox.Show("Lütfen Boş Alan Bırakmayınız.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlConnection sqlcon = new SqlConnection(@"Data Source=IDEAPAD-SAV;Initial Catalog=QantarDB;Integrated Security=True");
                sqlcon.Open();
                SqlCommand qadd = new SqlCommand("INSERT INTO VehiclesOUT(plate, driver, dateO, userS, weightI, weightO, productW) VALUES('" + txtPlate.Text.Trim() + "', '" + txtDriver.Text.Trim() + "', getdate(), 'user', '" + txtWi.Text.Trim() + "', '" + txtWi.Text.Trim() + "', '" + txtWo.Text.Trim() + "', '" + txtPw.Text.Trim() + "'); ", sqlcon);
                SqlCommand qdel = new SqlCommand("DELETE FROM VehiclesIN WHERE plate = '" + txtPlate + "'; ", sqlcon);
                qadd.ExecuteNonQuery();
                qdel.ExecuteNonQuery();

                FmHome objFmHome = new FmHome();
                this.Close();
                objFmHome.Show();
            }
        }
    }
}
