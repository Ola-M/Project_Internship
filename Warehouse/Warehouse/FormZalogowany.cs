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

            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'warehouseDatabaseDataSet1.invoice' . Możesz go przenieść lub usunąć.
            this.invoiceTableAdapter.Fill(this.warehouseDatabaseDataSetInvoice.Invoice);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'warehouseDatabaseDataSet.ProviderInvoice' . Możesz go przenieść lub usunąć.
            this.providerInvoiceTableAdapter.Fill(this.warehouseDatabaseDataSet.ProviderInvoice);


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
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "Excel Workbook |*.xlsx";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {

                    textBoxLokalizacjaPliku.Text = openFileDialog.FileName;
                    using (var stream= File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration()
                                {
                                    UseHeaderRow = true
                                }
                            });
                            tableCollection = result.Tables;
                            comboBoxWidok.Items.Clear();

                            foreach (DataTable dt in result.Tables)
                            comboBoxWidok.Items.Add(dt.TableName);

                        }
                    }
                }
            }

        }

        private void comboBoxWidok_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dataTable = tableCollection[comboBoxWidok.SelectedItem.ToString()];
            dataGridViewInvoice.DataSource = dataTable;
            var nazwaDostawcy = comboBoxWidok.Text;
            DateTime thisDay = DateTime.Now;
            if ((dataTable != null) && (dataTable.Rows.Count>=5))
            {
                Supply supply = new Supply();
                supply.numberOfItems = int.Parse(dataTable.Rows[2][1].ToString());
                supply.addDate = thisDay;
                supply.deliveryStatus = false;


                List<Invoice> invoices = new List<Invoice>();
                for (int i = 5; i < dataTable.Rows.Count; i++)
                {
                    try
                    {
                        Invoice invoice = new Invoice();
                       
                        Provider prov = context.Provider.FirstOrDefault(c => c.companyName == nazwaDostawcy);
                        invoice.providerID = prov.providerID;
                        invoice.deliveryReportNo = dataTable.Columns[4].ToString();

                        invoice.deliveryDate = DateTime.Parse(dataTable.Rows[0][4].ToString());
                        invoice.company = dataTable.Rows[i][0].ToString();
                        invoice.orderNumber = dataTable.Rows[i][1].ToString();

                        invoice.itemNumber = int.Parse(dataTable.Rows[i][2].ToString());

                        invoice.productCode = dataTable.Rows[i][3].ToString();
                        invoice.productName = dataTable.Rows[i][4].ToString();
                        invoice.serialNo = dataTable.Rows[i][5].ToString();


                        supply.numberOfItems = int.Parse(dataTable.Rows[2][1].ToString());
                        supply.addDate = thisDay;
                        supply.deliveryStatus = false;

                        invoices.Add(invoice);
                    }catch(Exception exc)
                    {
                        MessageBox.Show("Błędna struktura pliku");
                    }

                }
                invoiceBindingSource.DataSource = invoices;

                
            }
            else
            {
                MessageBox.Show("Błędna struktura pliku");
            }
        }

        private void buttonDodajExcelDoBazy_Click(object sender, EventArgs e)
        {

            try
            {
                DapperPlusManager.Entity<Invoice>().Table("invoice");
                List<Invoice> invoices = invoiceBindingSource.DataSource as List<Invoice>;
                if(invoices != null)
                {
                   foreach(Invoice invoice in invoices)
                    {
                        context.Invoice.Add(invoice);
                    }
                    context.SaveChanges();
                }

            }
            catch (DbEntityValidationException ex)
            {
                foreach (var eve in ex.EntityValidationErrors)
                {
                    Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                        eve.Entry.Entity.GetType().Name, eve.Entry.State);
                    foreach (var ve in eve.ValidationErrors)
                    {
                        Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"",
                            ve.PropertyName, ve.ErrorMessage);
                    }
                }
                
            }



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
