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
      
        }

        private void buttonWyloguj_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.Show();
            this.Close();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //pobiera dane wybranego rekordu 
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

        }

        private void comboBoxWidok_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dataTable = tableCollection[comboBoxWidok.SelectedItem.ToString()];
            dataGridView1.DataSource = dataTable;
            var nazwaDostawcy = comboBoxWidok.Text;

            if(dataTable != null)
            {
                List<invoice> invoices = new List<invoice>();
                for(int i = 5; i < 8; i++)
                {
                    invoice invo = new invoice();
                    invo.deliveryReportNo = dataTable.Rows[0][4].ToString();
                    invo.productName = dataTable.Rows[i][4].ToString();
         
                    invoices.Add(invo);
                }
                invoiceBindingSource.DataSource = invoices;
            }
        }

        private void buttonSendToDatabase_Click(object sender, EventArgs e)
        {
            try
            {
                DapperPlusManager.Entity<invoice>().Table("invoice");
                List<invoice> invoices = invoiceBindingSource.DataSource as List<invoice>;

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Messege", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
