using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakipveSatisUygulamasi
{
    public partial class frmUsers : Form
    {
        public frmUsers()
        {
            InitializeComponent();
        }
        public OleDbConnection con = new OleDbConnection("Provider=Microsoft.Ace.Oledb.12.0;Data Source=AppData.accdb");
        public DataTable table = new DataTable();
        public OleDbDataAdapter adtr = new OleDbDataAdapter();
        public OleDbCommand cmd = new OleDbCommand();

        public void list()
        {
            table.Clear();
            con.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("select ID,[E-mail],Phone,Username,Password,ProfileImage From UsersInfo", con);
            adtr.Fill(table);
            guna2DataGridView1.DataSource = table;
            adtr.Dispose();
            con.Close();
            try
            {
                guna2DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                guna2DataGridView1.Columns[0].HeaderText = "ID";
                guna2DataGridView1.Columns[1].HeaderText = "E-MAIL";
                guna2DataGridView1.Columns[2].HeaderText = "PHONE";
                guna2DataGridView1.Columns[3].HeaderText = "USERNAME";
                guna2DataGridView1.Columns[4].HeaderText = "PASSWORD";
                guna2DataGridView1.Columns[5].HeaderText = "PROFILE IMAGE";
            }
            catch
            {
                ;
            }
        }
        private void frmUsers_Load(object sender, EventArgs e)
        {
            list();
        }

       
    }
}
