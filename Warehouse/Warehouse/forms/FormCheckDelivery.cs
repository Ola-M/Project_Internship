using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Warehouse.bazaDanych;
using Warehouse.deliveryAddDataBase;
using Warehouse.deliveryCheck;
using Warehouse.forms;
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
        RemoveProvenProduct removeProvenProduct;
        private string numberOfItems = "0";



        int deliveryNoteID;
        int id;
        string serial;
        public FormCheckDelivery(int deliveryNoteID, int id)
        {
            InitializeComponent();
            this.ActiveControl = textBoxAddSerial;
            this.deliveryNoteID = deliveryNoteID;
            this.id = id;
            this.loadOwned = new LoadOwnedProduct(dataOwnedProducts, textBoxAddSerial, dataGridViewProvenProduct, dataGridViewProducts);
            this.addProvenProductDB = new AddProvenProductDB(dataGridViewProducts, dataGridViewProvenProduct);
            this.checkPermissionsProvenProduct = new CheckPermissionsProvenProduct(id, buttonDelete, buttonSave, buttonFinishChecking, buttonSummary, textBoxAddSerial);
            this.removeProvenProduct = new RemoveProvenProduct(dataGridViewProvenProduct, dataGridViewProducts);
            checkPermissionsProvenProduct.provenProductButtons(deliveryNoteID);
            this.ActiveControl = textBoxAddSerial;




        }



        private void FormCheckDelivery_Load(object sender, EventArgs e)
        {
            try
            {
                var data = (from c in context.ProductView where c.deliveryNoteID == deliveryNoteID select c);
                List<ProductView> productViews = new List<ProductView>();
                dataGridViewProducts.DataSource = data.ToList();
                this.ActiveControl = textBoxAddSerial;
                dataOwnedProducts = loadOwned.loadProducts( deliveryNoteID);
                labelNumberOfItems.Text = dataGridViewProvenProduct.Rows.Count.ToString();
                correctProducts();
            }
            catch(Exception ex) { }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            addProvenProductDB.addProven(list, id, dataOwnedProducts, deliveryNoteID);
            list.Clear();
        }
        private void textBoxAddSerial_TextChanged(object sender, EventArgs e)
        {
            if (serial == null)
            {
                serial = textBoxAddSerial.Text;
            }
            else
            {
                serial = textBoxAddSerial.Text;
            }
            if (serial.Length >= 12) {
                loadOwned.addSerial(list, textBoxAddSerial);
                this.ActiveControl = textBoxAddSerial;
                labelNumberOfItems.Text = dataGridViewProvenProduct.Rows.Count.ToString();
                correctProducts();
                textBoxAddSerial.Clear();
                
            }
            


        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormZalogowany formZalogowany = new FormZalogowany(id);
            formZalogowany.Show();
            this.Close();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {            
            removeProvenProduct.removeProduct(list, dataOwnedProducts);
            foreach (DataGridViewRow row in dataGridViewProvenProduct.Rows)
            {
                if ((row.Cells[4].Value != null)&&(row.Cells[4].Value.Equals(true)))
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                }
            }
            labelNumberOfItems.Text = dataGridViewProvenProduct.Rows.Count.ToString();
            correctProducts();

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
            FormSummary formSummary = new FormSummary(deliveryNoteID, summarizeDelivery.getIncorrect());
            formSummary.Show();
            this.Hide();
        }

        private void correctProducts()
        {
            int xxx = 0;
            var bbbb = context.Product.FirstOrDefault(c => c.serialNo == textBoxAddSerial.Text);
            foreach (DataGridViewRow row in dataGridViewProvenProduct.Rows)
            {
                if ((row.Cells[4].Value != null)&&(row.Cells[4].Value.Equals(false)))
                {
                    xxx++;
                }
                else if((row.Cells[4].Value == null) && (bbbb != null)){
                    xxx++;
                }
            }
            var items = context.DeliveryNote.FirstOrDefault(c => c.deliveryNoteID == this.deliveryNoteID);
            if (items != null)
            {
                this.numberOfItems = items.numberOfItems.ToString();
            }

            labelCorrectProducts.Text = "Ilość zgodnych produktów: " + xxx + "/" + numberOfItems;
        }
    }
    
}
