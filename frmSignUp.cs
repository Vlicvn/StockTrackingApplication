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
    public partial class frmSignUp : Form
    {

        OleDbConnection con;
        OleDbDataReader dr;
        OleDbCommand cmd;


        public frmSignUp()
        {
            InitializeComponent();
        }

        private void signupcheckbox_CheckedChanged(object sender, EventArgs e)
        {
            // CheckBox'ın durumuna göre şifre karakterini göster veya gizle
            if (signupCheckBox.Checked) //true
            {
                signupPassTxt.PasswordChar = '\0'; // Şifre karakterini göster
            }
            else //false
            {
                signupPassTxt.PasswordChar = '*'; // Şifre karakterini gizle
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            Login back = new Login();
            back.Show();
            this.Hide();
        }

        public void Alert(string msg, FormAlert.enmType type)
        {
            FormAlert frm = new FormAlert();
            frm.showAlert(msg, type);
        }

        private void SignUpBtn_Click(object sender, EventArgs e)
        {

            // Kullanıcının girdiği bilgileri alın
            string email = signupMailTxt.Text;
            string phone = signupPhoneTxt.Text;
            string username = signupUserTxt.Text;
            string password = signupPassTxt.Text;

            // Bilgi eksikliğini ve benzersizliği kontrol edin
            if (string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(phone) ||
                string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                this.Alert("Please fill in all the required information.", FormAlert.enmType.Warning);
            }
            else
            {
                try
                {
                    con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0; Data Source=AppData.accdb");
                    con.Open();

                    // E-posta, telefon veya kullanıcı adı veritabanında var mı kontrol et
                    string checkQuery = "SELECT COUNT(*) FROM UsersInfo WHERE [E-mail] = @Email OR Phone = @Phone OR Username = @Username";
                    OleDbCommand checkCommand = new OleDbCommand(checkQuery, con);
                    checkCommand.Parameters.AddWithValue("@Email", email);
                    checkCommand.Parameters.AddWithValue("@Phone", phone);
                    checkCommand.Parameters.AddWithValue("@Username", username);
                    int existingCount = (int)checkCommand.ExecuteScalar();

                    if (existingCount > 0)
                    {
                        this.Alert("An account with the same email, phone, or \n username already exists.", FormAlert.enmType.Error);
                    }
                    else
                    {
                        // Benzersiz kayıt ekle
                        OleDbCommand signUpCommand = new OleDbCommand("INSERT INTO UsersInfo([E-mail], Phone, Username, [Password]) VALUES (@Email, @Phone, @Username, @Password)", con);
                        signUpCommand.Parameters.AddWithValue("@Email", email);
                        signUpCommand.Parameters.AddWithValue("@Phone", phone);
                        signUpCommand.Parameters.AddWithValue("@Username", username);
                        signUpCommand.Parameters.AddWithValue("@Password", password);
                        signUpCommand.ExecuteNonQuery();
                        this.Alert("Your registration has been successfully \n completed. Welcome!", FormAlert.enmType.Success);
                        signupMailTxt.Text = "";
                        signupPhoneTxt.Text = "";
                        signupUserTxt.Text = "";
                        signupPassTxt.Text = "";
                    }

                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


        }
    }
}
