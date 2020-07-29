using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warehouse.deliveryCheck
{
    public class RemoveProvenProduct
    {
        warehouseDatabaseEntities1 context = new warehouseDatabaseEntities1();
        List<OwnedProductView> dataOwnedProduct;
        public RemoveProvenProduct(List<OwnedProductView> dataOwnedProduct)
        {
            this.dataOwnedProduct = dataOwnedProduct;
        }
        public void removeProduct(DataGridView dataGridView, List<string> list)
        {
            try
            {
                ProvenProduct provenProduct;
                String delId;

                foreach (DataGridViewRow item in dataGridView.SelectedRows)
                {
                    if (item.Cells[1].Value != null)
                    {

                        var xxx = this.dataOwnedProduct.Count;
                        delId = item.Cells[0].Value.ToString();
                        provenProduct = context.ProvenProduct.First(c => c.cSerialNo == delId);
                        context.ProvenProduct.Remove(provenProduct);
                        this.dataOwnedProduct.RemoveAt(item.Index);
                    }
                    else
                    {

                        list.Remove(item.Cells[0].Value.ToString());
                        this.dataOwnedProduct.RemoveAt(item.Index);
                    }


                }
                context.SaveChanges();
                dataGridView.DataSource = null;
                dataGridView.DataSource = this.dataOwnedProduct;
                dataGridView.Columns["deliveryNoteID"].Visible = false;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
