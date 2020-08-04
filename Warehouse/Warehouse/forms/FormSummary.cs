using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warehouse.forms
{
    public partial class FormSummary : Form
    {
        warehouseDatabaseEntities1 context = new warehouseDatabaseEntities1();
        int deliveryNoteID;
        List<Product> incorrectProducts;
        int userID;
        public FormSummary(int deliveryNoteID, List<Product> products, int userID)
        {
            this.deliveryNoteID = deliveryNoteID;
            InitializeComponent();
            this.incorrectProducts = products;
            this.userID = userID;
        }

        private void FormSummary_Load(object sender, EventArgs e)
        {
            var dataIncompapatible = (from c in context.IncompatibleProductsView where c.deliveryNoteID == deliveryNoteID select c);
                dataGridViewIncompatibleProducts.DataSource = dataIncompapatible.ToList();
            dataGridViewMissingProducts.DataSource = incorrectProducts;
            dataGridViewMissingProducts.Columns[0].Visible = false;
            dataGridViewMissingProducts.Columns[1].Visible = false;
            dataGridViewMissingProducts.Columns[4].Visible = false;
            dataGridViewMissingProducts.Columns[8].Visible = false;
            var contactProviderID = context.DeliveryNote.FirstOrDefault(c => c.deliveryNoteID == deliveryNoteID);
            var contact = context.Provider.FirstOrDefault(c => c.providerID == contactProviderID.providerID);
            labelContact.Text = "Kontakt: " + contact.contact;

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            FormCheckDelivery formCheckDelivery = new FormCheckDelivery(deliveryNoteID, userID);
            formCheckDelivery.Show();
            this.Hide();
        }
    }
}
