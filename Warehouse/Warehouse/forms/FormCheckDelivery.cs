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
        List<OwnedProductView> dataOwnedProducts = new List<OwnedProductView>();
        List<string> list = new List<string>();
        LoadOwnedProduct loadOwned;
        AddProvenProductDB addProvenProductDB;
        //RemoveProvenProduct removeProvenProduct;


        int deliveryNoteID;
        int id;
        public FormCheckDelivery(int deliveryNoteID, int id)
        {
            InitializeComponent();
            this.ActiveControl = textBoxAddSerial;
            this.deliveryNoteID = deliveryNoteID;
            this.id = id;
            this.loadOwned = new LoadOwnedProduct(dataOwnedProducts, textBoxAddSerial);
            this.addProvenProductDB = new AddProvenProductDB();
            //this.removeProvenProduct = new RemoveProvenProduct(dataOwnedProducts);
        }


        private void button1_Click(object sender, EventArgs e)
        {

            list.Add(textBoxAddSerial.Text.Trim());
            loadOwned.addSerial(dataGridViewProvenProduct, dataGridViewProducts);
            this.ActiveControl = textBoxAddSerial;
        }

        private void FormCheckDelivery_Load(object sender, EventArgs e)
        {
            var data = (from c in context.ProductView where c.deliveryNoteID == deliveryNoteID select c);
            dataGridViewProducts.DataSource = data.ToList();
            loadOwned.loadProducts(dataGridViewProvenProduct, deliveryNoteID, dataGridViewProducts);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            addProvenProductDB.addProven(list, id, dataOwnedProducts, dataGridViewProvenProduct, deliveryNoteID);
            list.Clear();
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
            //removeProvenProduct.removeProduct(this.dataGridViewProvenProduct, list);
            loadOwned.removeProduct(this.dataGridViewProvenProduct, list, dataGridViewProducts);
           
        }
    }
    
}
