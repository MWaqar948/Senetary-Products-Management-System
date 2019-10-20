﻿using System;
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
    public partial class Brand : MaterialSkin.Controls.MaterialForm
    {
        string connectionString = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
        SqlConnection conn;
        int rows=0;


        public Brand()
        {
            InitializeComponent();
            conn = new SqlConnection(connectionString);
        }

        private void Brand_Load(object sender, EventArgs e)
        {
            string query = "select Name,Color,Guage,Bore from Category";
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
            using (AddCategory frm=new AddCategory())
            {
                frm.ShowDialog();
            }
        }

        private void categoryDetail_Click(object sender, EventArgs e)
        {
            string query = "select Name,Color,Guage,Bore from Category";
            display(query);
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
    }
}
