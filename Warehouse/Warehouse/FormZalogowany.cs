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
       warehouseDatabaseEntities context = new warehouseDatabaseEntities();

        public FormZalogowany()
        {
            InitializeComponent();
        }

        private void FormZalogowany_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'warehouseDatabaseDataSet1.invoice' . Możesz go przenieść lub usunąć.
            this.invoiceTableAdapter.Fill(this.warehouseDatabaseDataSet1.invoice);
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

            MessageBox.Show(fileContent, "File Content at path: " + filePath, MessageBoxButtons.OK);
        }

        private void comboBoxWidok_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dataTable = tableCollection[comboBoxWidok.SelectedItem.ToString()];
            dataGridViewShowNew.DataSource = dataTable;
            var nazwaDostawcy = comboBoxWidok.Text;

            if (dataTable != null)
            {
                List<invoice> invoices = new List<invoice>();
                for (int i = 5; i <dataTable.Rows.Count; i++)
                {
                    invoice invo = new invoice();

                  //provider prov = context.provider.FirstOrDefault(c=> c.companyName ==) comboBox pobieranie nazwy firmy
                    //invo.providerID = 1;
                    invo.deliveryReportNo = dataTable.Columns[4].ToString();

                   // string konwersjaDeliveryDate = dataTable.Rows[0][4].ToString();
                    invo.deliveryDate = DateTime.Parse(dataTable.Rows[0][4].ToString());

                    // string konversjaNumberOfItems = dataTable.Rows[1][2].ToString();
                    invo.numberOfItems = int.Parse(dataTable.Rows[1][2].ToString());
                    invo.company = dataTable.Rows[i][0].ToString();
                    invo.orderNumber = dataTable.Rows[i][1].ToString();

                   // string konwersjaItemNumber = dataTable.Rows[i][2].ToString();
                    invo.itemNumber  = int.Parse(dataTable.Rows[i][2].ToString());

                    invo.productCode = dataTable.Rows[i][3].ToString();
                    invo.productName = dataTable.Rows[i][4].ToString();
                    invo.serialNo = dataTable.Rows[i][5].ToString();
                    

                    invoices.Add(invo);
                }
                invoiceBindingSource.DataSource = invoices;

                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DapperPlusManager.Entity<invoice>().Table("invoice");
                List<invoice> invoices = invoiceBindingSource.DataSource as List<invoice>;
                if(invoices != null)
                {
                   foreach(invoice inv in invoices)
                    {
                        context.invoice.Add(inv);
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

        private void dataGridViewShowNotes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach(DataGridViewRow row in dataGridViewShowNotes.SelectedRows)
    {
                string value1 = row.Cells[0].Value.ToString();

            }
        }
    }
}
