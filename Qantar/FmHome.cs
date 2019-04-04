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
        public FmHome()
        {
            InitializeComponent();
            //SqlConnection con = new SqlConnection();
            //con.ConnectionString = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FmLogin objFmLogin = new FmLogin();
            this.Close();
            objFmLogin.Show();
        }
    }
}
