using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Qantar
{
    public partial class FmAdd : Form
    {
        public FmAdd()
        {
            InitializeComponent();

            timer1.Start();

        }

        string port;
        int reciveddata;
       
        private void FmAdd_Load(object sender, EventArgs e)
        {
        
            for (int i = 0; i < System.IO.Ports.SerialPort.GetPortNames().Length;i++)
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

        private void btnOut_Click(object sender, EventArgs e)
        {
            FmOut objFmOut = new FmOut();
            this.Close();
            objFmOut.Show();
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
            else if (string.IsNullOrWhiteSpace(txtWeight.Text))
            {
                MessageBox.Show("Lütfen Boş Alan Bırakmayınız.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlConnection sqlcon = new SqlConnection(@"Data Source=IDEAPAD-SAV;Initial Catalog=QantarDB;Integrated Security=True");
                sqlcon.Open();
                SqlCommand qadd = new SqlCommand("INSERT INTO VehiclesIN(plate, driver, dateI, userS, weightI) VALUES('" + txtPlate.Text.Trim() + "', '" + txtDriver.Text.Trim() + "', getdate(), 'user', '" + txtWeight.Text.Trim() + "'); ", sqlcon);

                qadd.ExecuteNonQuery();

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
                labelW.Text = reciveddata.ToString()+ " Kg";

                

                
            }
            catch (Exception ex)
            {
            }

            txtWeight.Text = reciveddata.ToString();
        }
    }
}
