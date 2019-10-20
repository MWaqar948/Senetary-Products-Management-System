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
    public partial class HomePage : MaterialSkin.Controls.MaterialForm
    {
        
       
        public HomePage()
        {
            
            InitializeComponent();
            
        }
       
        private void HomePage_Load(object sender, EventArgs e)
        {
          
            MaterialSkin.MaterialSkinManager frmManager = MaterialSkin.MaterialSkinManager.Instance;
            frmManager.AddFormToManage(this);
            frmManager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            //frmManager.ColorScheme = new MaterialSkin.ColorScheme(MaterialSkin.Primary.Green600, MaterialSkin.Primary.BlueGrey900, MaterialSkin.Primary.BlueGrey500, MaterialSkin.Accent.Orange700, MaterialSkin.TextShade.WHITE);
            
        }

        private void studentBtn_Click(object sender, EventArgs e)
        {
            using(Products p=new Products())
            {
                p.ShowDialog();
            }
        }

        private void CourseBtn_Click(object sender, EventArgs e)
        {

        }

        private void categoryBtn_Click(object sender, EventArgs e)
        {
            using (Category c = new Category())
            {
                c.ShowDialog();
            }
        }
    }
}
