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
    public partial class AddCategory : MaterialSkin.Controls.MaterialForm
    {
        string connectionString = ConfigurationManager.ConnectionStrings["myConnectionString"].ConnectionString;
        SqlConnection conn;
        public AddCategory()
        {
            InitializeComponent();
            conn = new SqlConnection(connectionString);
        }

        private void AddCategory_Load(object sender, EventArgs e)
        {
            MaterialSkin.MaterialSkinManager frmManager = MaterialSkin.MaterialSkinManager.Instance;
            frmManager.AddFormToManage(this);
            frmManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
        }

        private void addCategory()
        {
            try
            {
                conn.Open();
                string query2 = "insert into [Category] values('" + nameTxt.Text + "','" + colourBox.Text + "','" + guageBox.Text + "','" + boreBox.Text + "')";
                MessageBox.Show(query2);
                SqlCommand command2 = new SqlCommand(query2, conn);
                int result = command2.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show("Category Created");
                }
                else
                {
                    MessageBox.Show("Category cannot be created");
                }
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        


        private void addCategoryBtn_Click(object sender, EventArgs e)
        {

            if (nameTxt.Text==string.Empty)
            {
                MessageBox.Show("Please enter category name");
            }
            else if (boreBox.SelectedIndex < 0)
            {
                MessageBox.Show("Please select Bore");
            }
            else if (guageBox.SelectedIndex < 0 )
            {
                MessageBox.Show("Please select the guage");
            }
            else if (colourBox.SelectedIndex < 0)
            {
                MessageBox.Show("Please select colour");
            }
            else
            {

                MessageBox.Show("All is well!");
                addCategory();

            }
        }
    }
}
