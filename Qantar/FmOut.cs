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

            timer1.Start();
        }

        string port;
        int reciveddata;

        private void FmOut_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < System.IO.Ports.SerialPort.GetPortNames().Length; i++)
            {
                port = System.IO.Ports.SerialPort.GetPortNames()[i];
                comboBoxPorts.Items.Add(System.IO.Ports.SerialPort.GetPortNames()[i]);
            }
            try
            {
                serialPort1.PortName = port;
                if (!serialPort1.IsOpen)
                    serialPort1.Open();
            }
            catch (Exception)
            {
            }

            SqlConnection con = new SqlConnection(@"Data Source=IDEAPAD-SAV;Initial Catalog=QantarDB;Integrated Security=True");
            con.Open();

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
                SqlCommand qadd = new SqlCommand("INSERT INTO VehiclesOUT(plate, driver, dateO, userS, weightI, weightO, productW) VALUES('" + txtPlate.Text.Trim() + "', '" + txtDriver.Text.Trim() + "', getdate(), 'user', '" + txtWi.Text.Trim() + "', '" + txtWo.Text.Trim() + "', '" + txtPw.Text.Trim() + "'); ", sqlcon);
                SqlCommand qdel = new SqlCommand("DELETE FROM VehiclesIN WHERE plate = '" + txtPlate.Text.Trim() + "'; ", sqlcon);
                qadd.ExecuteNonQuery();
                qdel.ExecuteNonQuery();
                
                FmHome objFmHome = new FmHome();
                this.Close();
                objFmHome.Show();
            }
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

        private void btnCon_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Write("1");
                reciveddata = Convert.ToInt16(serialPort1.ReadLine());
                labelW.Text = reciveddata.ToString() + "Kg";




            }
            catch (Exception ex)
            {
            }
        }

    }
}
