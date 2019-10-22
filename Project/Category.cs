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
    public partial class Category : MaterialSkin.Controls.MaterialForm
    {
        
        SqlConnection conn;
        int rows=0;


        public Category()
        {
            InitializeComponent();
            conn = DBConnection.getConnection();
            
           /* Category.MaximizeBox = false;

            // Set the MinimizeBox to false to remove the minimize box.
            Category.MinimizeBox = false;*/

        }

        private void Category_Load(object sender, EventArgs e)
        {
            string query = "select Name,Color,Guage,Bore from Category";
            DataTable dt=DBConnection.display(query);
            dataGridView1.DataSource = dt;

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            using (AddCategory frm=new AddCategory())
            {
                frm.ShowDialog();
            }
        }

       

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            if (rows > 1)
            {
                MessageBox.Show("Please select one category which you want to delete");
            }
            else if(rows==1)
            {
                //MessageBox.Show("Selected: " + rows);
                foreach (DataGridViewRow row in dataGridView1.SelectedRows)
                {
                    string catName = row.Cells[0].Value.ToString();
                    string value2 = row.Cells[1].Value.ToString();
                    //MessageBox.Show("Select Category:" + catName);
                    deleteCategory(catName);
                }
            }

        }


        private void deleteCategory(string categoryName)
        {
            try
            {
                DialogResult dResult = MessageBox.Show("Are you sure you want to delete the record", "Confirm Deletion", MessageBoxButtons.YesNo);
                if (dResult == DialogResult.Yes)
                {
                    string queryDelete = "delete from [Category] Where Name='" + categoryName + "'";
                    SqlCommand command = new SqlCommand(queryDelete, conn);
                    conn.Open();
                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Category Deleted");
                    }
                    else
                    {
                        MessageBox.Show("Category cannot be Deleted");
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
             rows=dataGridView1.SelectedRows.Count;
                       
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            string query = "select Name,Color,Guage,Bore from Category where Name LIKE '%"+nameTxt.Text+"%'";
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

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            string query = "select Name,Color,Guage,Bore from Category";
            DataTable dt=DBConnection.display(query);
            dataGridView1.DataSource = dt;
        }
    }
}
