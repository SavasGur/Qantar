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
        int count;

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

        private void btnexchm_Click(object sender, EventArgs e)
        {
            // creating Excel Application  
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            // creating new WorkBook within Excel application  
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            // creating new Excelsheet in workbook  
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // see the excel sheet behind the program  
            app.Visible = true;
            // get the reference of first sheet. By default its name is Sheet1.  
            // store its reference to worksheet  
            worksheet = workbook.Sheets["Sayfa1"];
            worksheet = workbook.ActiveSheet;
            // changing the name of active sheet  
            worksheet.Name = "Exported from gridview";
            // storing header part in Excel  
            for (int i = 1; i < dgVecIN.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dgVecIN.Columns[i - 1].HeaderText;
            }
            // storing Each row and column value to excel sheet  
            for (int i = 0; i < dgVecIN.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dgVecIN.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dgVecIN.Rows[i].Cells[j].Value.ToString();
                }
            }
            // save the application  
            workbook.SaveAs(@"C:\Users\savas\Desktop\output.xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            // Exit from the application  
            app.Quit();
        }
    }
    
}
