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
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'warehouseDatabaseDataSet2.invoice' . Możesz go przenieść lub usunąć.
            this.invoiceTableAdapter.Fill(this.warehouseDatabaseDataSet2.invoice);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'warehouseDatabaseDataSet.ProviderInvoice' . Możesz go przenieść lub usunąć.
            this.providerInvoiceTableAdapter.Fill(this.warehouseDatabaseDataSet.ProviderInvoice);
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'warehouseDatabaseDataSet1.ProviderInvoice' . Możesz go przenieść lub usunąć.


        }

        private void buttonWyloguj_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach(DataGridViewRow row in dataGridView1.SelectedRows)
    {
                string value1 = row.Cells[1].Value.ToString();

            }
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
            dataGridView1.DataSource = dataTable;
        }
    }
}
