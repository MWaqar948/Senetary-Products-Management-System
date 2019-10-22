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
using System.Configuration;

namespace Project
{
    public partial class Products : MaterialSkin.Controls.MaterialForm
    {
       
        SqlConnection conn;
        private int rows=0;

        public Products()
        {
            InitializeComponent();
            conn = DBConnection.getConnection();
        }

        private void Products_Load(object sender, EventArgs e)
        {
            string query = "select Category,Brand,Quantity,Price from Product";
            display(query);
        }
        public void display(string query)
        {
            conn.Open();

            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            System.Data.SqlClient.SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            using (AddProduct frm=new AddProduct())
            {
                frm.ShowDialog();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (rows == 0)
            {
                MessageBox.Show("Please first select one Product which you want to delete");
            }
            if (rows > 1)
            {
                MessageBox.Show("Please select one Product which you want to delete");
            }
            else if (rows == 1)
            {
                //MessageBox.Show("Selected: " + rows);
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    string catName = row.Cells[0].Value.ToString();
                    string brand = row.Cells[1].Value.ToString();
                    //MessageBox.Show("Select Category:" + catName);
                    deleteProduct(catName,brand);
                    break;
                }
                string query = "select Category,Brand,Quantity,Price from Product";
                display(query);

            }

        }

        private void deleteProduct(string prodName,string brand)
        {
            try
            {
                DialogResult dResult = MessageBox.Show("Are you sure you want to delete the record", "Confirm Deletion", MessageBoxButtons.YesNo);
                if (dResult == DialogResult.Yes)
                {
                    string queryDelete = "delete from [Product] Where Category='" + prodName + "' AND Brand='"+brand+"'";
                    SqlCommand command = new SqlCommand(queryDelete, conn);
                    conn.Open();
                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Product Deleted");
                    }
                    else
                    {
                        MessageBox.Show("Product cannot be Deleted");
                    }
                    conn.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            rows = dataGridView1.SelectedRows.Count;
        }

        private void productUpdateBtn_Click(object sender, EventArgs e)
        {
            if(rows == 0)
            {
                MessageBox.Show("Please first select one Product which you want to update");
            }
            else if (rows > 1)
            {
                MessageBox.Show("Please select one Product which you want to update");
            }
            else if (rows == 1)
            {
                string[] values=new string[4];
                //MessageBox.Show("Selected: " + rows);
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    for(int i=0; i < row.Cells.Count; i++)
                    {
                        values[i] = row.Cells[i].Value.ToString();
                        //MessageBox.Show("Value:"+i+" : "+values[i]);
                       
                    }
                   
                }

                using (UpdateProduct up = new UpdateProduct(values))
                {
                    up.ShowDialog();
                }

            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string query = "select Category,Brand,Quantity,Price from Product where Category LIKE '%" + nameTxt.Text+"%'";
            DataTable dt=DBConnection.display(query);
            if (dt.Rows.Count > 0)
            {
                dataGridView1.DataSource = dt;
            }
            else
            {
                MessageBox.Show("Nothing Found");
            }
        }
    }
}
