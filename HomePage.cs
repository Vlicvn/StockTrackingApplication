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
using System.IO;

namespace StokTakipveSatisUygulamasi
{
    public partial class HomePage : Form
    {

        private string loggedInUsername;
        private byte[] userProfileImage; // Profil fotoğrafını saklamak için bir byte dizisi

        public HomePage(string user)
        {
            InitializeComponent();
            loggedInUsername = user;
        }

        public void Alert(string msg, FormAlert.enmType type)
        {
            FormAlert frm = new FormAlert();
            frm.showAlert(msg, type);
        }

        private void logoutBtn_Click(object sender, EventArgs e)
        {
            Login transition = new Login();
            transition.Show();
            this.Hide();
            this.Alert("Successfully logged out, Have a nice day!", FormAlert.enmType.Success);
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
            Form frmHome = new frmHome();
            FormGetir(frmHome);
            homeBtn.FillColor = Color.DeepSkyBlue;
            productsBtn.FillColor = Color.WhiteSmoke;
            usersBtn.FillColor = Color.WhiteSmoke;
            logoutBtn.FillColor = Color.WhiteSmoke;


            // Access veritabanı bağlantısı için bağlantı dizesi
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=AppData.accdb";

            // Veritabanı bağlantısını açın
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                // SQL sorgusunu oluşturun
                string sqlQuery = "SELECT Username, [E-mail], ProfileImage FROM UsersInfo WHERE Username = @Username";

                using (OleDbCommand cmd = new OleDbCommand(sqlQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@Username", loggedInUsername);

                    using (OleDbDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            // Kullanıcının "Username" ve "E-mail" bilgilerini etiketlere yazdırın
                            lblUsername.Text = "Username: " + reader["Username"].ToString();
                            lblMail.Text = "E-mail: " + reader["E-mail"].ToString();

                            // Profil fotoğrafını alın
                            byte[] profileImageBytes = reader["ProfileImage"] as byte[];

                            if (profileImageBytes != null && profileImageBytes.Length > 0)
                            {
                                // Byte dizisini görüntü olarak dönüştürün ve PictureBox'ta gösterin
                                using (MemoryStream ms = new MemoryStream(profileImageBytes))
                                {
                                    pfpPictureBox.Image = Image.FromStream(ms);
                                }
                            }
                            else
                            {
                                // Eğer profil fotoğrafı yoksa bir varsayılan görüntü gösterebilirsiniz
                                pfpPictureBox.Image = null;
                            }
                        }
                    }
                }
            }


        }

        private void pfpPictureBox_Click(object sender, EventArgs e)
        {
            // Fotoğraf yükleme işlemi için bir OpenFileDialog oluşturun
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.png;*.jpg;*.jpeg;*.gif;*.bmp)|*.png;*.jpg;*.jpeg;*.gif;*.bmp";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Kullanıcının seçtiği dosyayı byte dizisine dönüştürün
                    userProfileImage = File.ReadAllBytes(openFileDialog.FileName);

                    // Veritabanına kaydedin
                    SaveUserProfileImageToDatabase(userProfileImage);

                    // PictureBox'ta görüntüleyin
                    pfpPictureBox.Image = Image.FromFile(openFileDialog.FileName);
                }
            }
        }
        private void SaveUserProfileImageToDatabase(byte[] imageBytes)
        {
            // Access veritabanı bağlantısı için bağlantı dizesi
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=AppData.accdb";

            // Veritabanı bağlantısını açın
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                connection.Open();

                // SQL sorgusunu oluşturun
                string sqlQuery = "UPDATE UsersInfo SET ProfileImage = @ProfileImage WHERE Username = @Username";

                using (OleDbCommand cmd = new OleDbCommand(sqlQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@ProfileImage", imageBytes);
                    cmd.Parameters.AddWithValue("@Username", loggedInUsername);

                    // Sorguyu çalıştırın
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void logoutBtn_Click_1(object sender, EventArgs e)
        {
            Login transition = new Login();
            transition.Show();
            this.Hide();
        }

        private void FormGetir(Form frm)
        {
            frm.MdiParent = this;
            panel3.Controls.Add(frm);
            frm.FormBorderStyle = FormBorderStyle.None;
            frm.Show();
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            Form frmHome = new frmHome();
            FormGetir(frmHome);
            homeBtn.FillColor = Color.DeepSkyBlue;
            productsBtn.FillColor = Color.WhiteSmoke;
            usersBtn.FillColor = Color.WhiteSmoke;
            logoutBtn.FillColor = Color.WhiteSmoke;
        }

        private void productsBtn_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            Form frmProducts = new frmProducts();
            FormGetir(frmProducts);
            homeBtn.FillColor = Color.WhiteSmoke;
            productsBtn.FillColor = Color.DeepSkyBlue;
            usersBtn.FillColor = Color.WhiteSmoke;
            logoutBtn.FillColor = Color.WhiteSmoke;
        }

        private void usersBtn_Click(object sender, EventArgs e)
        {
            panel3.Controls.Clear();
            Form frmUsers = new frmUsers();
            FormGetir(frmUsers);
            homeBtn.FillColor = Color.WhiteSmoke;
            productsBtn.FillColor = Color.WhiteSmoke;
            usersBtn.FillColor = Color.DeepSkyBlue;
            logoutBtn.FillColor = Color.WhiteSmoke;
        }

       
    }
}
