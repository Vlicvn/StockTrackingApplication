using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.OleDb;

namespace StokTakipveSatisUygulamasi
{
    public partial class Login : Form
    {


        OleDbConnection con;
        OleDbDataReader dr;
        OleDbCommand cmd;

      
        public Login()
        {
            InitializeComponent();
        }

       
        private void SignUpBtn_Click(object sender, EventArgs e)
        {
            frmSignUp signup = new frmSignUp();
            signup.Show();
            this.Hide();
        }

        private void gunaCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            // CheckBox'ın durumuna göre şifre karakterini göster veya gizle
            if (loginCheckBox.Checked) //true
            {
                loginPassTxt.PasswordChar = '\0'; // Şifre karakterini göster
            }
            else //false
            {
                loginPassTxt.PasswordChar = '*'; // Şifre karakterini gizle
            }
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string user = loginUserTxt.Text;
            string pass = loginPassTxt.Text;

            // Kullanıcı adı ve şifre kutularının boş olup olmadığını kontrol edin
            if (string.IsNullOrWhiteSpace(user) || string.IsNullOrWhiteSpace(pass))
            {
                this.Alert("Username or password cannot be empty!", FormAlert.enmType.Warning);
            }
            else
            {
                con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=AppData.accdb");
                cmd = new OleDbCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "SELECT * FROM UsersInfo WHERE Username='" + user + "' AND Password='" + pass + "'";
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    this.Alert("Successfully logged in, Welcome!", FormAlert.enmType.Success);
                    HomePage transition = new HomePage(user);
                    transition.Show();
                    this.Hide();
                }
                else
                {
                    this.Alert("Incorrect username or password, Try Again!", FormAlert.enmType.Error);
                }

                con.Close();
            }
        }

        public void Alert(string msg, FormAlert.enmType type)
        {
            FormAlert frm = new FormAlert();
            frm.showAlert(msg, type);
        }

        
    }
}
