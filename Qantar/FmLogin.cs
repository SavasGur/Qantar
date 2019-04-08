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
    public partial class FmLogin : Form
    {
        public FmLogin()
        {
            InitializeComponent();
            timer1.Start();
            txtPassword.PasswordChar = '*';
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Tab))
            {
                txtUsername.Focus();
            }
        }

        public string VarUsername;
        

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtUsername.Text) && string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Lütfen Kullanıcı Adı ve Şifre Girin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrWhiteSpace(txtUsername.Text))
            {
                MessageBox.Show("Lütfen Kullanıcı Adı Girin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Lütfen Şifre Girin.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                SqlConnection sqlcon = new SqlConnection(@"Data Source=IDEAPAD-SAV;Initial Catalog=QantarDB;Integrated Security=True");
                string query = "Select * from dbo.LoginCred Where username = '" + txtUsername.Text.Trim() + "' and password ='" + txtPassword.Text.Trim() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                if (dtbl.Rows.Count == 1)
                {
                    FmHome objFmHome = new FmHome();
                    this.Hide();
                    objFmHome.Show();

                    VarUsername = txtUsername.Text.Trim();
                    MessageBox.Show( VarUsername + " kullanıcısı olarak giriş yaptınız.");
                }
                else
                {
                    MessageBox.Show("Kullanıcı Adı veya Şifre Yanlış!");
                }

            }

        }
   
     

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime t = DateTime.Now;
            this.labeldt.Text = t.ToString("MM/dd/yyyy HH:mm:ss");
        }

        private void FmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
