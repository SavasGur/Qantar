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
    public partial class FmAdd : Form
    {
        public FmAdd()
        {
            InitializeComponent();
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


            SqlConnection sqlcon = new SqlConnection(@"Data Source=IDEAPAD-SAV;Initial Catalog=QantarDB;Integrated Security=True");
            sqlcon.Open();
            SqlCommand qadd = new SqlCommand("INSERT INTO VehiclesIN(plate, driver, dateI, userS, weightI) VALUES('" + txtPlate.Text.Trim() + "', '" + txtDriver.Text.Trim() + "', getdate(), 'user', '" + txtWeight.Text.Trim() + "'); ", sqlcon);

            qadd.ExecuteNonQuery();

            FmHome objFmHome = new FmHome();
            this.Close();
            objFmHome.Show();


        }
    }
}
