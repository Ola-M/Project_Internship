using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warehouse.productAdd
{
    public class LoadDeliveryNote
    {
        warehouseDatabaseEntities1 context = new warehouseDatabaseEntities1();

        public void addDeliveryNote(ComboBox box,DataTable dataTable)
        {

            var nazwaDostawcy = box.Text;
            DateTime thisDay = DateTime.Now;
            if ((dataTable != null) && (dataTable.Rows.Count >= 5))
            {

               // List<Product> products = new List<Product>();
                DeliveryNote deliveryNote = new DeliveryNote();

                Provider prov = context.Provider.FirstOrDefault(c => c.companyName == nazwaDostawcy);
                deliveryNote.providerID = prov.providerID;
                deliveryNote.deliveryNumber = dataTable.Columns[4].ToString();

                deliveryNote.invoiceDate = DateTime.Parse(dataTable.Rows[0][4].ToString());
                deliveryNote.numberOfItems = int.Parse(dataTable.Rows[2][1].ToString());
                context.DeliveryNote.Add(deliveryNote);
                context.SaveChanges();


            }
        }
    }
}
