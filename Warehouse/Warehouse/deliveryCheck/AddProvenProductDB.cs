using System;
using System.Collections.Generic;
using System.Data;
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
        public AddProvenProductDB() { 
        }
        public void addProven(List<string> lista, int id, List<OwnedProductView> dataOwnedProduct, DataGridView dataGridView, int deliveryNoteID)
        {
            DataTable dataTable = new DataTable();
            ProvenProduct provenProduct = new ProvenProduct();
            Product product = new Product();
            foreach (string e in lista)
            {
                
                product = context.Product.FirstOrDefault(c => c.serialNo == e);
               
                   //if(product != null)
                {
                    provenProduct.usersID = id;
                    provenProduct.checkDate = DateTime.Now;
                    provenProduct.deliveryNoteID = product.deliveryNoteID;
                    provenProduct.cCompany = product.company;
                    provenProduct.cOrderNumber = product.orderNumber;
                    provenProduct.cItemNumber = product.itemNumber;
                    provenProduct.cProductCode = product.productCode;
                    provenProduct.cProductName = product.productName;
                    provenProduct.cSerialNo = product.serialNo.Trim();

                    context.ProvenProduct.Add(provenProduct);
                    context.SaveChanges();
                    dataGridView.DataSource = null;
                    dataGridView.DataSource = (from c in context.OwnedProductView where c.deliveryNoteID == deliveryNoteID select c).ToList();
                    dataGridView.Columns["deliveryNoteID"].Visible = false;
                }
                
                  
            }
        }


    }
}
