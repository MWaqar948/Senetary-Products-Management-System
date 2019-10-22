using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Sales : Form
    {
        public Sales()
        {
            InitializeComponent();
        }

        private void productUpdateBtn_Click(object sender, EventArgs e)
        {

        }

        private void Sales_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'database1DataSet2.Brand' table. You can move, or remove it, as needed.
            this.brandTableAdapter.Fill(this.database1DataSet2.Brand);
            // TODO: This line of code loads data into the 'database1DataSet1.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter1.Fill(this.database1DataSet1.Category);
            // TODO: This line of code loads data into the 'database1DataSet.Category' table. You can move, or remove it, as needed.
            this.categoryTableAdapter.Fill(this.database1DataSet.Category);

        }
    }
}
