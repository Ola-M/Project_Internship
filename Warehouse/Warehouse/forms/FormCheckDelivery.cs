using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Warehouse.deliveryAddDataBase;
using Warehouse.deliveryCheck;
using Warehouse.warehouseDatabaseDeliveryView1TableAdapters;

namespace Warehouse
{
    public partial class FormCheckDelivery : Form
    {
        warehouseDatabaseEntities1 context = new warehouseDatabaseEntities1();
        LoadOwnedProduct loadOwned = new LoadOwnedProduct();

        int cos;
        public FormCheckDelivery(int cos)
        {
            InitializeComponent();
            this.cos = cos;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            loadOwned.addSerial(dataGridView2, dataGridViewProducts, textBox1);
        }

        private void FormCheckDelivery_Load(object sender, EventArgs e)
        {

            var data = (from c in context.Product where c.deliveryNoteID == cos select c);

            dataGridViewProducts.DataSource = data.ToList();
            loadOwned.loadProducts(dataGridView2, cos);

            //dataGridView2.Columns["deliveryNoteID"].Visible = false;
           /* foreach(DataGridViewRow row in dataGridViewProducts.Rows)
            {
                row.DefaultCellStyle.BackColor = Color.Green;
            }*/
        }

    }
}
