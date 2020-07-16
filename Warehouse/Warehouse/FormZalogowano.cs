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
    public partial class FormZalogowano : Form
    {
        public FormZalogowano()
        {
            InitializeComponent();
        }

        private void FormZalogowano_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'warehouseDatabaseDataSet.invoice' . Możesz go przenieść lub usunąć.
            this.invoiceTableAdapter.Fill(this.warehouseDatabaseDataSet.invoice);
            loadgrid();
        }

        private void loadgrid()
        {
            pickUpDelivery pickUpDelivery = new pickUpDelivery();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
