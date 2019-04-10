using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Qantar
{
    public partial class FmReport : Form
    {
       List<KantarIn> kantarsI = new List<KantarIn>();
       List<KantarOut> kantarsO = new List<KantarOut>();
        public FmReport()
        {
            InitializeComponent();

        }
        private void UpdateBindingI()
        {
            reportGridview.DataSource = kantarsI ;
        }
        private void UpdateBindingO()
        {
            reportGridview.DataSource = kantarsO;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            FmHome objFmHome = new FmHome();
            this.Close();
            objFmHome.Show();
        }

        private void FmReport_Load(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            plateTextbox.Visible = false;
            driverTextbox.Visible = false;
            girisRadio.Checked = true;
            girisagirlkFilterTextbox.Visible = false;
            tarihFiltreBox.Visible = false;
            DateTime tmr = DateTime.Now;
            timerLabel.Text = tmr.ToString();
        }

        private void driverFilter_CheckedChanged(object sender, EventArgs e)
        {
            driverTextbox.Visible = true;
            if (driverFilter.Checked == false)
            {
                driverTextbox.Visible = false;
                driverTextbox.Text = "";
                if (girisRadio.Checked == true)
                    UpdateBindingI();
                else
                    UpdateBindingO();
            }
        }

        private void plateFilter_CheckedChanged(object sender, EventArgs e)
        {
            plateTextbox.Visible = true;
            if (plateFilter.Checked == false)
            {
                plateTextbox.Visible = false;
                plateTextbox.Text = "";
                if (girisRadio.Checked == true)
                    UpdateBindingI();
                else
                    UpdateBindingO();
            }
        }

        private void plateTextbox_TextChanged(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            if (girisRadio.Checked == true)
            {
                if (driverFilter.Checked == true)
                {
                    kantarsI = db.PDIFilter(plateTextbox.Text, driverTextbox.Text);
                }
                else
                    kantarsI = db.PlakaIFilter(plateTextbox.Text);
                UpdateBindingI();
            }
            else {
                if (driverFilter.Checked == true)
                {
                    kantarsO = db.PDOFilter(plateTextbox.Text, driverTextbox.Text);
                }
                else
                    kantarsO = db.PlakaOFilter(plateTextbox.Text);
                UpdateBindingO();
             }
        }

        private void driverTextbox_TextChanged(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            if (girisRadio.Checked == true)
            {
                if (plateFilter.Checked == true)
                {
                    kantarsI = db.PDIFilter(plateTextbox.Text, driverTextbox.Text);
                }
                else
                    kantarsI = db.driverIFilter(driverTextbox.Text);
                UpdateBindingI();
            }
            else
            {
                if (plateFilter.Checked == true)
                {
                    kantarsO = db.PDOFilter(plateTextbox.Text, driverTextbox.Text);
                }
                else
                    kantarsO = db.PDOFilter(plateTextbox.Text, driverTextbox.Text);
                UpdateBindingO();
            }
        }

        private void cikisRadio_CheckedChanged(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            if (cikisRadio.Checked == true)
            {
                girisRadio.Checked = false;
                kantarsO = db.ShowOut();
                UpdateBindingO();
            }
            else
                girisRadio.Checked = true;


        }

        private void girisRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (girisRadio.Checked == true)
            {
                DataAccess db = new DataAccess();

                kantarsI = db.ShowIn();

                UpdateBindingI();
            }
        }

        
        private void btnExc_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            app.Visible = true;
            worksheet = workbook.Sheets["Sayfa1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "Exported from gridview";
            for (int i = 1; i < reportGridview.Columns.Count +1; i++)
            {
                worksheet.Cells[1, i] = reportGridview.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < reportGridview.Rows.Count ; i++)
            {
                for (int j = 0; j < reportGridview.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = reportGridview.Rows[i].Cells[j].Value.ToString();
                }
            }

            MessageBox.Show("Excel doysanız hazırlandı!", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void girisagirlkFilterTextbox_TextChanged(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            if (girisRadio.Checked == true)
            {
                kantarsI = db.weigthIFilter(girisagirlkFilterTextbox.Text);
                UpdateBindingI();
            }
            else
            {
                kantarsO = db.PlakaOFilter(girisagirlkFilterTextbox.Text);
                UpdateBindingO();
            }
        }

        private void girisAgirlik_CheckedChanged(object sender, EventArgs e)
        {
            girisagirlkFilterTextbox.Visible = true;
            if (girisAgirlik.Checked == false)
            {
                girisagirlkFilterTextbox.Visible = false;
                girisagirlkFilterTextbox.Text = "";
                if (girisRadio.Checked == true)
                    UpdateBindingI();
                else
                    UpdateBindingO();
            }
            else
            {
                if (plateFilter.Checked == true | driverFilter.Checked == true)
                {
                    MessageBox.Show("Lütfen sadece giriş ağırlık kutusunu işaretleyin!","Hata",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    girisAgirlik.Checked = false;
                    plateFilter.Checked = false;
                    driverFilter.Checked = false;
                }
                
            }

        }

        private void tarihFilter_CheckedChanged(object sender, EventArgs e)
        {   
            if(tarihFilter.Checked == true)
                tarihFiltreBox.Visible = true;
            
        }

        private void tarihsearchButton_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();
            if (girisRadio.Checked == true)
            {
                kantarsI = db.tarihIFilter(Convert.ToDateTime(tarihPicker.Text), Convert.ToDateTime(tarihPicker2.Text));
                UpdateBindingI();
            }
            else
            {
                kantarsO = db.tarihOFilter(Convert.ToDateTime(tarihPicker.Text), Convert.ToDateTime(tarihPicker2.Text));
                UpdateBindingO();
               
            }
        }

        private void tarihgeriButton_Click(object sender, EventArgs e)
        {
            tarihFiltreBox.Visible = false;
            tarihFilter.Checked = false;
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
    }
}
