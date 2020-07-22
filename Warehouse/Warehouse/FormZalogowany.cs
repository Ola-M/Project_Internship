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
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'warehouseDatabaseDataSetProduct.Product' . Możesz go przenieść lub usunąć.
            this.productTableAdapter.Fill(this.warehouseDatabaseDataSetProduct.Product);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'warehouseDatabaseDataSetView.DeliveryView' . Możesz go przenieść lub usunąć.
            this.deliveryViewTableAdapter.Fill(this.warehouseDatabaseDataSetView.DeliveryView);


        }

        private void buttonWyloguj_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
            this.Close();
        }

        DataTableCollection tableCollection;

        private void buttonDodajPDF_Click(object sender, EventArgs e)
        {
         
            LoadExcel loadExcel = new LoadExcel();
            tableCollection = loadExcel.getFile(comboBoxWidok);
        }


        public DataTable dataTable;
        private void comboBoxWidok_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.dataTable = tableCollection[comboBoxWidok.SelectedItem.ToString()];
            dataGridViewInvoice.DataSource = this.dataTable;
        }


        private void buttonDodajExcelDoBazy_Click(object sender, EventArgs e)
        {
            LoadDeliveryNote loadDeliveryNote = new LoadDeliveryNote();
            loadDeliveryNote.addDeliveryNote(comboBoxWidok, dataTable);
            LoadProduct loadProduct = new LoadProduct();
            loadProduct.addProduct(dataTable, productBindingSource);
        }

        private void dataGridViewProviderInvoice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach(DataGridViewRow row in dataGridViewProviderInvoice.SelectedRows)
    {
                string value1 = row.Cells[0].Value.ToString();

            }
        }
    }
}
