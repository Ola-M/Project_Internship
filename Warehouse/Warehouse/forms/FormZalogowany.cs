using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Z.Dapper.Plus;
using System.Data.SqlClient;
using System.Data.Entity.Migrations;
using System.Data.Entity.Validation;
using Warehouse.productAdd;
using Warehouse.deliveryAddDataBase;

namespace Warehouse
{
    public partial class FormZalogowany : Form
    {
       warehouseDatabaseEntities1 context = new warehouseDatabaseEntities1();


        public FormZalogowany()
        {
            InitializeComponent();

        }

        private void FormZalogowany_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'warehouseDatabaseDataSet.Delivery' . Możesz go przenieść lub usunąć.
            this.deliveryTableAdapter.Fill(this.warehouseDatabaseDataSet.Delivery);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'warehouseDatabaseDeliveryView1.DeliveryView' . Możesz go przenieść lub usunąć.
            this.deliveryViewTableAdapter1.Fill(this.warehouseDatabaseDeliveryView1.DeliveryView);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'warehouseDatabaseDataSetProduct.Product' . Możesz go przenieść lub usunąć.
            this.productTableAdapter.Fill(this.warehouseDatabaseDataSetProduct.Product);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'warehouseDatabaseDataSetView.DeliveryView' . Możesz go przenieść lub usunąć.
            this.deliveryViewTableAdapter.Fill(this.warehouseDatabaseDataSetView.DeliveryView);


        }

        private void buttonWyloguj_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
            this.Hide();
        }

        DataTableCollection tableCollection;
        public DataTable dataTable;
        private void buttonDodajPDF_Click(object sender, EventArgs e)
        {
         
            LoadExcel loadExcel = new LoadExcel();
            tableCollection = loadExcel.getFile(comboBoxWidok, textBoxLokalizacjaPliku, dataTable, dataGridViewInvoice);
            if (tableCollection != null)
            {
                comboBoxWidok.SelectedIndex = 0;
            }
        }


      
        private void comboBoxWidok_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.dataTable = tableCollection[comboBoxWidok.SelectedItem.ToString()];
            dataGridViewInvoice.DataSource = this.dataTable;
        }


        private void buttonDodajExcelDoBazy_Click(object sender, EventArgs e)
        {
            try
            {
                String deliveryNumberString = dataTable.Columns[4].ToString();
                var isAdded = context.DeliveryNote.FirstOrDefault(d => d.deliveryNumber == deliveryNumberString);
                if (isAdded == null )
                {
                    LoadDeliveryNote loadDeliveryNote = new LoadDeliveryNote();
                    loadDeliveryNote.addDeliveryNote(comboBoxWidok, dataTable);
                    LoadProduct loadProduct = new LoadProduct();
                    loadProduct.addProduct(dataTable, productBindingSource);
                    FormZalogowany_Load(sender, e);
                }
                else
                {
                    MessageBox.Show("Wybrana faktura została już dodana");
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }





        private void dataGridViewProviderInvoice_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DeliveryQuery deliveryQuery = new DeliveryQuery();
            int goToDelivery = 0;
            foreach (DataGridViewRow row in dataGridViewProviderInvoice.SelectedRows)
            {
                goToDelivery = int.Parse(row.Cells[6].Value.ToString());

            }
            if (goToDelivery != 0) {
                const string message =
                    "Czy chcesz przejść do dostawy";
                const string caption = "Edycja";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.OKCancel,
                                             MessageBoxIcon.Question);

                // If the no button was pressed ...
                if (result == DialogResult.OK)
                {
                    var cos = context.Delivery.FirstOrDefault(d => d.deliveryID == goToDelivery);
                    deliveryQuery.delivery = cos.deliveryNoteID;
                    FormCheckDelivery formCheckDelivery = new FormCheckDelivery(cos.deliveryNoteID);
                    formCheckDelivery.Show();
                    this.Hide();
                } 
            }

            
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.deliveryViewTableAdapter1.FillBy(this.warehouseDatabaseDeliveryView1.DeliveryView);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
