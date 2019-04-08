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
        public int numRows;

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

                numRows = dgVecIN.Rows.Count;
            }

            timer1.Start();
   
        }

        string port;
        int reciveddata;

        private void FmHome_Load(object sender, EventArgs e)
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

            this.label3.Text = numRows.ToString();

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

            FmLogin objfmLogin = new FmLogin();
            string hun = objfmLogin.VarUsername;
            this.labelUsername.Text = hun;
    
        }

        private void btnCon_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Write("1");
                reciveddata = Convert.ToInt16(serialPort1.ReadLine());
                labelW.Text = reciveddata.ToString() + " Kg";




            }
            catch (Exception ex)
            {
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FmLogin objfmLogin = new FmLogin();
            string hun = objfmLogin.VarUsername;
            MessageBox.Show(hun);
        }
    }
    
}
