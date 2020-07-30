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
        CheckPermissionsProvenProduct checkPermissionsProvenProduct;



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
            this.checkPermissionsProvenProduct = new CheckPermissionsProvenProduct(id, buttonDelete, buttonSave, buttonFinishChecking, buttonSummary);
            checkPermissionsProvenProduct.provenProductButtons();



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

        private void buttonFinishChecking_Click(object sender, EventArgs e)
        {
            const string message =
                    "Czy chcesz zakończyć dostawę";
            const string caption = "Edycja";
            var result = MessageBox.Show(message, caption,
                                         MessageBoxButtons.OKCancel,
                                         MessageBoxIcon.Question);
            if (result == DialogResult.OK)
            {
                FinishDelivery finishDelivery = new FinishDelivery(deliveryNoteID);
                finishDelivery.changeChecked(buttonSummary);
            }
        }

        private void buttonSummary_Click(object sender, EventArgs e)
        {
            
            SummarizeDelivery summarizeDelivery = new SummarizeDelivery(id, deliveryNoteID, dataGridViewProducts, this.dataGridViewProvenProduct);
            summarizeDelivery.summaryDelivery();
        }
    }
    
}
