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
    public partial class AddProduct : MaterialSkin.Controls.MaterialForm
    {
        string connectionString = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
        SqlConnection conn;
        public AddProduct()
        {
            InitializeComponent();
            conn = new SqlConnection(connectionString);
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {
            MaterialSkin.MaterialSkinManager frmManager = MaterialSkin.MaterialSkinManager.Instance;
            frmManager.AddFormToManage(this);
            frmManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            
            if (nameBox.SelectedIndex < 0)
            {
                MessageBox.Show("Please select Category  of your Product");
            }
            else if (brandBox.SelectedIndex < 0)
            {
                MessageBox.Show("Please select Brand of your Product");
            }
            else if (qtyUpDown.Text==string.Empty || qtyUpDown.Value<1)
            {
                MessageBox.Show("Please enter the quantity");
            }
            else if (priceText.Text==string.Empty)
            {
                MessageBox.Show("Please enter the price");
            }
            else
            {

                MessageBox.Show("All is well!");
                addProduct();

            }
        }

        private void addProduct()
        {
            try
            {
                if(conn.State==ConnectionState.Closed)
                conn.Open();

                string query = "select * from Product where Category=@Category AND Brand=@Brand";

                SqlCommand cmd = new SqlCommand(query, conn);
                cmd.Parameters.Add(new SqlParameter("@Category", nameBox.Text));
                cmd.Parameters.Add(new SqlParameter("@Brand",brandBox.Text));
                cmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                System.Data.SqlClient.SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                MessageBox.Show("Rows: " + dt.Rows.Count);
                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("This product already exists please only update the quantity of the product");
                    
                }
                else { 

                    string query2 = "insert into [Product] values('" + nameBox.Text + "','" + brandBox.Text + "','" + qtyUpDown.Text + "','" + priceText.Text + "')";
                    MessageBox.Show(query2);
                    SqlCommand command2 = new SqlCommand(query2, conn);
                    int result = command2.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Product Added");
                    }
                    else
                    {
                        MessageBox.Show("Product cannot be added");
                    }
                }
                conn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void priceText_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(priceText.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                priceText.Text = priceText.Text.Remove(priceText.Text.Length - 1);
            }
        }
    }
}
