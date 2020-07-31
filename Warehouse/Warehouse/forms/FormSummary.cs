using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warehouse.forms
{
    public partial class FormSummary : Form
    {
        List<Product> incorrectProducts;
        public FormSummary(List<Product> products)
        {
            InitializeComponent();
            this.incorrectProducts = products;
        }

        private void FormSummary_Load(object sender, EventArgs e)
        {
            if(incorrectProducts.Count != 0)
            {
                dataGridViewSummary.Visible = true;
                dataGridViewSummary.DataSource = incorrectProducts;
            }
            
        }
        private void products()
        {

        }
    }
}
