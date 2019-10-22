using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class AddBrand : MaterialSkin.Controls.MaterialForm
    {
        SqlConnection conn;
        public AddBrand()
        {
            InitializeComponent();
            conn = DBConnection.getConnection();
        }

        private void AddBrand_Load(object sender, EventArgs e)
        {
            MaterialSkin.MaterialSkinManager frmManager = MaterialSkin.MaterialSkinManager.Instance;
            frmManager.AddFormToManage(this);
            frmManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
        }

        private void addBrand()
        {
            try
            {
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                string query = "select * from Brand where Name=@Brand";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@Brand", nameTxt.Text));
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                System.Data.SqlClient.SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("This Brand already exists");
                }
                else
                {
                    string query2 = "insert into [Brand] values('" + nameTxt.Text + "')";
                    MessageBox.Show(query2);
                    SqlCommand command2 = new SqlCommand(query2, conn);
                    int result = command2.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Brand Created");
                    }
                    else
                    {
                        MessageBox.Show("Brand cannot be created");
                    }
                }
                
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
       

        private void addBrandBtn_Click(object sender, EventArgs e)
        {

            if (nameTxt.Text == string.Empty)
            {
                MessageBox.Show("Please enter category name");
            }
            else
            {

                MessageBox.Show("All is well!");
                addBrand();
            }
        }
    }
}
