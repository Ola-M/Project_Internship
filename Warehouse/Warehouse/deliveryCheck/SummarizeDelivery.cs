using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warehouse.deliveryCheck
{
    public class SummarizeDelivery
    {
        warehouseDatabaseEntities1 context = new warehouseDatabaseEntities1();
        DeliveryNote deliveryNote;
        Delivery delivery;
        Summary summary = new Summary();
        int userId;
        int deliveryNoteId;
        DataGridView dataGridViewProduct;
        DataGridView dataGridViewProvenProduct;
        List<Product> list = new List<Product>();
        

        public SummarizeDelivery(int userId, int deliveryNoteId, DataGridView dataGridViewProduct, DataGridView dataGridViewProvenProduct)
        {
            this.userId = userId;
            this.deliveryNoteId = deliveryNoteId;
            this.dataGridViewProduct = dataGridViewProduct;
            this.dataGridViewProvenProduct = dataGridViewProvenProduct;

        }
        public void summaryDelivery()
        {
            var summaryExist = context.Summary.FirstOrDefault(c => c.deliveryNoteID == this.deliveryNoteId);

            if ((summaryExist == null)||(summaryExist.correct == false))
            {
                if (summaryExist != null)
                {
                    context.Summary.Remove(summaryExist);
                    context.SaveChanges();
                }
                summary.deliveryNoteID = deliveryNoteId;
                delivery = context.Delivery.FirstOrDefault(c => c.deliveryNoteID == this.deliveryNoteId);
                summary.deliveryID = delivery.deliveryID;
                summary.usersID = userId;
                summary.correct = checkCorrect();
                summary.closed = true;
                summary.deliveryCloseDate = DateTime.Now;
                context.Summary.Add(summary);
                context.SaveChanges();
            }
            else
            {
                checkCorrect();
            }
        }
        private bool checkCorrect()
        {
            deliveryNote = context.DeliveryNote.FirstOrDefault(c => c.deliveryNoteID == this.deliveryNoteId);

            
            string grid2 = "";
            string grid1 = "";
            for (int i = dataGridViewProduct.RowCount - 1; i >= 0; i--)
            {
                for (int j = 0; j < dataGridViewProvenProduct.RowCount; j++)
                {
                    grid2 = dataGridViewProvenProduct.Rows[j].Cells[0].Value.ToString().Trim();
                    grid1 = dataGridViewProduct.Rows[i].Cells[0].Value.ToString().Trim();
                    if ((grid1 == grid2))
                    {
                        break;
                    }
                }

                if ((grid1 != grid2))
                {
                    this.list.Add(context.Product.FirstOrDefault(c => c.serialNo == grid1));
                    
                }
            }
           if((dataGridViewProvenProduct.Rows.Count != deliveryNote.numberOfItems)||(list.Count > 0))
                {
                    return false;
                }
           else
            {
                return true;
            }


        
        }
        public List<Product> getIncorrect()
        {
            return list;
        }
    }
}
