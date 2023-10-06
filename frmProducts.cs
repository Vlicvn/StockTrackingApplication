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
    public partial class frmProducts : Form
    {
        public frmProducts()
        {
            InitializeComponent();
        }
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Ace.Oledb.12.0;Data Source=AppData.accdb");
        int selectedRow;
        int selectedProductId;

        public void Alert(string msg, FormAlert.enmType type)
        {
            FormAlert frm = new FormAlert();
            frm.showAlert(msg, type);
        }

        public void list()
        {
            DataTable table = new DataTable();
            OleDbCommand cmd = new OleDbCommand();

            table.Clear();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            OleDbDataAdapter adtr = new OleDbDataAdapter("select ID,stockName,stockModel,stockSerialNumber,stockQuantity,stockDate,stockRecordedBy From ProductsStock", con);
            adtr.Fill(table);
            guna2DataGridView1.DataSource = table;
            adtr.Dispose();

            try
            {
                guna2DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                guna2DataGridView1.Columns[0].HeaderText = "ID";
                guna2DataGridView1.Columns[1].HeaderText = "NAME";
                guna2DataGridView1.Columns[2].HeaderText = "MODEL";
                guna2DataGridView1.Columns[3].HeaderText = "SERIAL NUMBER";
                guna2DataGridView1.Columns[4].HeaderText = "QUANTITY";
                guna2DataGridView1.Columns[5].HeaderText = "DATE";
                guna2DataGridView1.Columns[6].HeaderText = "RECORDED BY";
            }
            catch  
            {
                ;
            }

            con.Close();
        }

        private void frmProducts_Load(object sender, EventArgs e)
        {
            list();
            productRecordedDate.Value = DateTime.Now;
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            productNameTxt.Text = guna2DataGridView1.CurrentRow.Cells[1].Value.ToString(); // datagridview1'deki seçili satırdaki o. hücreyi form3'ün textbox1'e yaz
            productModelTxt.Text = guna2DataGridView1.CurrentRow.Cells[2].Value.ToString();  // datagridview1'deki seçili satırdaki 1.hücreyi form3'ün textbox2'ye yaz
            productSerialNoTxt.Text = guna2DataGridView1.CurrentRow.Cells[3].Value.ToString();  //datagridview1'deki seçili satırdaki 2.hücreyi form3'ün textbox3'e yaz
            productQuantityTxt.Text = guna2DataGridView1.CurrentRow.Cells[4].Value.ToString();
            productRecordedDate.Text = guna2DataGridView1.CurrentRow.Cells[5].Value.ToString();
            productRecordedByTxt.Text = guna2DataGridView1.CurrentRow.Cells[6].Value.ToString();
          
        }

        private void productsAddBtn_Click(object sender, EventArgs e)
        {
            if (productNameTxt.Text.Trim() != "" && productModelTxt.Text.Trim() != "" && productSerialNoTxt.Text.Trim() != "" && productRecordedDate.Text.Trim() != "" && productRecordedByTxt.Text.Trim() != "")
            {
                if (int.TryParse(productQuantityTxt.Text, out int quantity) && quantity >= 0)
                {
                    con.Open();

                    string sqlQuery = "INSERT INTO ProductsStock (stockName, stockModel, stockSerialNumber, stockQuantity, stockDate, stockRecordedBy) " +
                                      "VALUES (@stockName, @stockModel, @stockSerialNumber, @stockQuantity, @stockDate, @stockRecordedBy)";

                    using (OleDbCommand cmd = new OleDbCommand(sqlQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@stockName", productNameTxt.Text);
                        cmd.Parameters.AddWithValue("@stockModel", productModelTxt.Text);
                        cmd.Parameters.AddWithValue("@stockSerialNumber", productSerialNoTxt.Text);
                        cmd.Parameters.AddWithValue("@stockQuantity", quantity);
                        cmd.Parameters.AddWithValue("@stockDate", productRecordedDate.Text);
                        cmd.Parameters.AddWithValue("@stockRecordedBy", productRecordedByTxt.Text);

                        cmd.ExecuteNonQuery();
                        this.Alert("Product has been added successfully.", FormAlert.enmType.Success);
                        list();
                        con.Close();
                        productNameTxt.Text = "";
                        productModelTxt.Text = "";
                        productSerialNoTxt.Text = "";
                        productQuantityTxt.Text = "";
                        productRecordedDate.Text = "";
                        productRecordedByTxt.Text = "";
                        guna2DataGridView1.ClearSelection();
                    }
                }
                else
                {
                    this.Alert("Please enter a valid quantity.", FormAlert.enmType.Warning);
                }
            }
            else
            {
                this.Alert("Please fill in all the required information.", FormAlert.enmType.Warning);
            }

        }

        private void productsUpdateBtn_Click(object sender, EventArgs e)
        {
            if (productNameTxt.Text.Trim() != "" && productModelTxt.Text.Trim() != "" && productSerialNoTxt.Text.Trim() != "" && productRecordedDate.Text.Trim() != "" && productRecordedByTxt.Text.Trim() != "")
            {
                if (int.TryParse(productQuantityTxt.Text, out int quantity) && quantity >= 0)
                {
                    if (guna2DataGridView1.SelectedRows.Count > 0)
                    {
                        selectedRow = guna2DataGridView1.SelectedRows[0].Index;
                        selectedProductId = Convert.ToInt32(guna2DataGridView1.Rows[selectedRow].Cells["ID"].Value);

                        con.Open();

                        string sqlUpdateQuery = "UPDATE ProductsStock SET stockName = @stockName, stockModel = @stockModel, stockSerialNumber = @stockSerialNumber, stockQuantity = @stockQuantity, stockDate = @stockDate, stockRecordedBy = @stockRecordedBy WHERE ID = @stockID";

                        using (OleDbCommand cmd = new OleDbCommand(sqlUpdateQuery, con))
                        {
                            cmd.Parameters.AddWithValue("@stockName", productNameTxt.Text);
                            cmd.Parameters.AddWithValue("@stockModel", productModelTxt.Text);
                            cmd.Parameters.AddWithValue("@stockSerialNumber", productSerialNoTxt.Text);
                            cmd.Parameters.AddWithValue("@stockQuantity", quantity);
                            cmd.Parameters.AddWithValue("@stockDate", productRecordedDate.Text);
                            cmd.Parameters.AddWithValue("@stockRecordedBy", productRecordedByTxt.Text);
                            cmd.Parameters.AddWithValue("@stockID", selectedProductId);

                            cmd.ExecuteNonQuery();
                            this.Alert("Product has been updated successfully.", FormAlert.enmType.Success);
                            list();
                            con.Close();
                            productNameTxt.Text = "";
                            productModelTxt.Text = "";
                            productSerialNoTxt.Text = "";
                            productQuantityTxt.Text = "";
                            productRecordedDate.Text = "";
                            productRecordedByTxt.Text = "";
                            guna2DataGridView1.ClearSelection();
                        }
                    }
                }
                else
                {
                    this.Alert("Please enter a valid quantity.", FormAlert.enmType.Warning);
                }
            }
            else
            {
                this.Alert("Please fill in all the required information.", FormAlert.enmType.Warning);
            }


        }

        private void productsDeleteBtn_Click(object sender, EventArgs e)
        {
            if (guna2DataGridView1.SelectedRows.Count > 0)
            {
                selectedRow = guna2DataGridView1.SelectedRows[0].Index;
                selectedProductId = Convert.ToInt32(guna2DataGridView1.Rows[selectedRow].Cells["ID"].Value);
          

                if (selectedProductId > 0) 
                {
                    con.Open();

                    string sqlDeleteQuery = "DELETE FROM ProductsStock WHERE ID = @stockID";

                    using (OleDbCommand cmd = new OleDbCommand(sqlDeleteQuery, con))
                    {
                        cmd.Parameters.AddWithValue("@stockID", selectedProductId); 

                        cmd.ExecuteNonQuery();
                        this.Alert("Product has been deleted successfully.", FormAlert.enmType.Success);
                        list();
                        con.Close();

                        productNameTxt.Text = "";
                        productModelTxt.Text = "";
                        productSerialNoTxt.Text = "";
                        productQuantityTxt.Text = "";
                        productRecordedDate.Text = "";
                        productRecordedByTxt.Text = "";
                        guna2DataGridView1.ClearSelection();
                    }   
                }
            }
            else
            {
                this.Alert("Please select a product to delete.", FormAlert.enmType.Warning);
            }


        }
    }

       
        
    
}
