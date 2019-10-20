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

namespace Project
{
    public partial class UpdateProduct : MaterialSkin.Controls.MaterialForm
    {
        string[] values;
        public UpdateProduct(string[] data)
        {
            InitializeComponent();
            values = data;
            nameBox.Text =data[0];
            productBrandBox.Text = data[1];
            //MessageBox.Show("1: " + values[1]);
            qtyUpDown.Text = data[2];
            priceText.Text = data[3];
            for (int i = 0; i < data.Length; i++)
            {
                Console.WriteLine("\nValue:" + i + " :" + data[i]);
            }
            MessageBox.Show(productBrandBox.Text);

        }

        private void updateProductBtn_Click(object sender, EventArgs e)
        {
            for (int i=0;i<values.Length;i++)
            {
                Console.WriteLine("Value:"+i+" : "+values[i]);
            }

            if (nameBox.SelectedIndex < 0)
            {
                MessageBox.Show("Please select Category  of your Product");
            }
            else if (productBrandBox.SelectedIndex < 0)
            {
                MessageBox.Show("Please select Brand of your Product");
            }
            else if (qtyUpDown.Text == string.Empty || qtyUpDown.Value < 1)
            {
                MessageBox.Show("Please enter the quantity");
            }
            else if (priceText.Text == string.Empty)
            {
                MessageBox.Show("Please enter the price");
            }
            else
            {

                MessageBox.Show("All is well!");
                productUpdate();

            }
        }


        private void productUpdate()
        {
            try
            {
                SqlConnection conn = DBConnection.getConnection();
                if (conn.State == ConnectionState.Closed)
                    conn.Open();

                string query = "update [Product] set Category='" + nameBox.Text + "',Brand='" + productBrandBox.Text + "', Quantity='" + qtyUpDown.Text + "', Price='" + priceText.Text + "' where Category='" + nameBox.Text + "'";
                SqlCommand cmd = new SqlCommand(query, conn);
                int result = cmd.ExecuteNonQuery();

                if (result > 0)
                {
                    MessageBox.Show("Product Updated");
                }
                conn.Close();
            }
            catch (DataException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
