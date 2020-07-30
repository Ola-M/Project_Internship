using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warehouse.deliveryCheck
{
    public class FinishDelivery
    {
        Delivery delivery = new Delivery();
        warehouseDatabaseEntities1 context = new warehouseDatabaseEntities1();
        int deliveryId;
        public FinishDelivery(int deliveryId)
        {
            this.deliveryId = deliveryId;
        }
        public void changeChecked(Button button)
        {
            delivery = context.Delivery.FirstOrDefault(c => c.deliveryID == this.deliveryId);
            if(delivery != null)
            {
                delivery.@checked = true;
                context.SaveChanges();
            }
            

        }
        
    }
}
