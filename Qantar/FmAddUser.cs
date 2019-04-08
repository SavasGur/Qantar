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
    public partial class FmAddUser : Form
    {
        public FmAddUser()
        {
            InitializeComponent();

            timer1.Start();
            txtPassword.PasswordChar = '*';
        }

        private void btnSave_Click(object sender, EventArgs e)
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
                sqlcon.Open();
                SqlCommand quseradd = new SqlCommand("INSERT INTO LoginCred(username, password) VALUES('" + txtUsername.Text.Trim() + "', '" + txtPassword.Text.Trim() + "')", sqlcon);

                quseradd.ExecuteNonQuery();
                
                MessageBox.Show(txtUsername.Text.Trim() + " kullanıcısı başarıyla kaydedildi.");

                txtUsername.Text = String.Empty;
                txtPassword.Text = String.Empty;

            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            FmHome objFmHome = new FmHome();
            this.Close();
            objFmHome.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime t = DateTime.Now;
            this.labeldt.Text = t.ToString("MM/dd/yyyy HH:mm:ss");
        }
    }
}
