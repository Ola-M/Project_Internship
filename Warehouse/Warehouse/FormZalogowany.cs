using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'warehouseDatabaseDataSet.ProviderInvoice' . Możesz go przenieść lub usunąć.
            this.providerInvoiceTableAdapter.Fill(this.warehouseDatabaseDataSet.ProviderInvoice);

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
    }
}
