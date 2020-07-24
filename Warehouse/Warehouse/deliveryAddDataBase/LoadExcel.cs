
using ExcelDataReader;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warehouse
{
    public class LoadExcel
    {
        FormZalogowany formZalogowany = new FormZalogowany();

      //  DataTableCollection tableCollection;


        
        public DataTableCollection getFile(ComboBox comboBox, TextBox textBox, DataTable dataTable, DataGridView dataGrid)
        {
            DataTableCollection dataTableCollection = null;
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

                    textBox.Text = openFileDialog.FileName;
                    try
                    {
                        using (var stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
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
                                dataTableCollection = result.Tables;
                                comboBox.Items.Clear();
                                if (dataTable != null)
                                {
                                    dataTable.Rows.Clear();
                                    dataTable.Columns.Clear();
                                    comboBox.Items.Clear();
                                }


                                foreach (DataTable dt in result.Tables)
                                {
                                    comboBox.Items.Add(dt.TableName);
                                }
                            }
                        }
                    }
                    catch(IOException ioException) { MessageBox.Show(ioException.Message); 
                    }
                }
            }
            return dataTableCollection;
        }

    }
}
