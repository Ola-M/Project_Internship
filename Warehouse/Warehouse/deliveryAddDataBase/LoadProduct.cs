using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warehouse.productAdd
{
    public class LoadProduct
    {
        DeliveryNote deliveryNote = new DeliveryNote();
        warehouseDatabaseEntities1 context = new warehouseDatabaseEntities1();

        public void addProduct(DataTable dataTable, BindingSource bindingSource)
        {
            List<Product> products = new List<Product>();
            Delivery delivery = new Delivery();
            for (int i = 5; i < dataTable.Rows.Count; i++)
            {
                try
                {
                    Product product = new Product();
                    String deliveryNumberString = dataTable.Columns[4].ToString();
                    deliveryNote = context.DeliveryNote.FirstOrDefault(d => d.deliveryNumber == deliveryNumberString);
                    product.deliveryNoteID = deliveryNote.deliveryNoteID;
                    product.company = dataTable.Rows[i][0].ToString();
                    product.orderNumber = dataTable.Rows[i][1].ToString();

                    product.itemNumber = int.Parse(dataTable.Rows[i][2].ToString());

                    product.productCode = dataTable.Rows[i][3].ToString();
                    product.productName = dataTable.Rows[i][4].ToString();
                    product.serialNo = dataTable.Rows[i][5].ToString().Trim();
                    

                    products.Add(product);
                }
                catch (Exception exc)
                {
                    MessageBox.Show("Błędna struktura pliku");
                    break;
                }

            }
            delivery.deliveryNoteID = deliveryNote.deliveryNoteID;

            bindingSource.DataSource = products;
            AddExcelToDatabase addExcelToDatabase = new AddExcelToDatabase();
            addExcelToDatabase.addExcel(products);
            context.Delivery.Add(delivery);
            context.SaveChanges();


        }
    }
}
