using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Warehouse.bazaDanych;
using Warehouse.deliveryAddDataBase;
using Warehouse.deliveryCheck;
using Warehouse.warehouseDatabaseDeliveryView1TableAdapters;

namespace Warehouse
{
    public partial class FormCheckDelivery : Form
    {
        public FormLogin formLogin;
        warehouseDatabaseEntities1 context = new warehouseDatabaseEntities1();
        LoadOwnedProduct loadOwned = new LoadOwnedProduct();
        List<string> list = new List<string>();

        int cos;
        int id;
        public FormCheckDelivery(int cos, int id)
        {
            InitializeComponent();
            this.ActiveControl = textBoxAddSerial;
            this.cos = cos;
            this.id = id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            list.Add(textBoxAddSerial.Text.Trim());
            loadOwned.addSerial(dataGridViewProvenProduct, dataGridViewProducts, textBoxAddSerial);
            this.ActiveControl = textBoxAddSerial;
        }

        private void FormCheckDelivery_Load(object sender, EventArgs e)
        {

            var data = (from c in context.ProductView where c.deliveryNoteID == cos select c);

            dataGridViewProducts.DataSource = data.ToList();
            loadOwned.loadProducts(dataGridViewProvenProduct, cos, dataGridViewProducts);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddProvenProductDB addProvenProduct = new AddProvenProductDB();
            addProvenProduct.addProven(list, id);
            dataGridViewProducts.DataSource = data.ToList();

            list.Clear();
            //FormCheckDelivery_Load(sender, e);
        }

        private void textBoxAddSerial_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormZalogowany formZalogowany = new FormZalogowany(id);
            formZalogowany.Show();
            this.Close();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
        }
    }
    
}
