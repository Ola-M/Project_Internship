using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse.deliveryCheck
{
    class DeleteProduct
    {
        warehouseDatabaseEntities1 context = new warehouseDatabaseEntities1();
        public void delete()
        {
            //poddaje się trzy drinki to za dużo to dprogramowania  nie chcesz żebym dalej pisała :-D
            // to był koń na białym rycerzu na białm rycerzu był koń
            var itemToRemove = context.ProvenProduct.SingleOrDefault(x => x.cSerialNo == ); 

            if (itemToRemove != null)
            {
                context.ProvenProduct.Remove(itemToRemove);
                context.SaveChanges();
            }


        }
    }
}
