using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Warehouse.bazaDanych;

namespace Warehouse.deliveryCheck
{
    class AddProvenProductDB
    {
        warehouseDatabaseEntities1 context = new warehouseDatabaseEntities1();
        DeliveryNote deliveryNote;
        DataGridView dataGridViewProduct;
        DataGridView dataGridViewProvenProduct;
        public AddProvenProductDB(DataGridView dataGridViewProduct, DataGridView dataGridViewProvenProduct) {
            this.dataGridViewProduct = dataGridViewProduct;
            this.dataGridViewProvenProduct = dataGridViewProvenProduct;
        }
        public void addProven(List<string> lista, int id, List<OwnedProductView> dataOwnedProduct, int deliveryNoteID)
        {
            ProvenProduct provenProduct = new ProvenProduct();
            Product product = new Product();
            foreach (string serial in lista)
            {
                
                product = context.Product.FirstOrDefault(c => c.serialNo == serial);


                if (product == null)
                {
                    string message =
                       "Zeskanowano serial ("+serial+"), który nie widnieje na fakturze.\nCzy chcesz go dodać?";
                    const string caption = "Edycja";
                    var result = MessageBox.Show(message, caption,
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        addIncorrectProven(id, deliveryNoteID, serial);
                    }

                }
                else
                {
                    addCorrectProven(id, deliveryNoteID, serial);
                }

                }
            dataGridViewProvenProduct.DataSource = null;
            dataGridViewProvenProduct.DataSource = (from c in context.OwnedProductView where c.deliveryNoteID == deliveryNoteID select c).ToList();
            offTheList();
            dataGridViewProvenProduct.Columns["deliveryNoteID"].Visible = false;


        }
        public void addCorrectProven(int id, int deliveryNoteID, string serial)
        {
            ProvenProduct provenProduct = new ProvenProduct();
            Product product = new Product();
                product = context.Product.FirstOrDefault(c => c.serialNo == serial);
                provenProduct.usersID = id;
                provenProduct.checkDate = DateTime.Now;
                provenProduct.deliveryNoteID = deliveryNoteID;
                provenProduct.cSerialNo = serial.Trim();
                provenProduct.cCompany = product.company;
                provenProduct.cOrderNumber = product.orderNumber;
                provenProduct.cItemNumber = product.itemNumber;
                provenProduct.cProductCode = product.productCode;
                provenProduct.cProductName = product.productName;
                provenProduct.offTheList = false;
            context.ProvenProduct.Add(provenProduct);
            context.SaveChanges();

        }
        public void addIncorrectProven(int id, int deliveryNoteID, string serial)
        {
            ProvenProduct provenProduct = new ProvenProduct();

                provenProduct.usersID = id;
                provenProduct.checkDate = DateTime.Now;
                provenProduct.deliveryNoteID = deliveryNoteID;
                provenProduct.cSerialNo = serial.Trim();
                provenProduct.cCompany = "";
                provenProduct.cOrderNumber = "";
                provenProduct.cItemNumber = 0;
                provenProduct.cProductCode = "";
                provenProduct.cProductName = "Produkt nieznany";
                provenProduct.offTheList = true;

                context.ProvenProduct.Add(provenProduct);
                context.SaveChanges();
            
        }
        private void offTheList()
        {
            foreach (DataGridViewRow row in dataGridViewProvenProduct.Rows)
            {
                if (row.Cells[4].Value.Equals(true))
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                }
            }
            
        }



    }
}
