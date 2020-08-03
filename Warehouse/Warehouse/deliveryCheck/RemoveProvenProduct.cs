using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warehouse.deliveryCheck
{
    public class RemoveProvenProduct
    {
        private warehouseDatabaseEntities1 context = new warehouseDatabaseEntities1();
        private DataGridView dataGridViewProvenProduct;
        private DataGridView dataGridViewProducts;
        public RemoveProvenProduct(DataGridView dataGridViewProvenProduct, DataGridView dataGridViewProducts)
        {
            this.dataGridViewProvenProduct = dataGridViewProvenProduct;
            this.dataGridViewProducts = dataGridViewProducts;
        }
        public void removeProduct( List<string> list, List<OwnedProductView> dataOwnedProducts)
        {
            try
            {
                ProvenProduct provenProduct;
                String delId;
                foreach (DataGridViewRow item in dataGridViewProvenProduct.SelectedRows)
                {
                    if (item.Cells[1].Value != null)
                    {

                        delId = item.Cells[0].Value.ToString();
                        provenProduct = context.ProvenProduct.First(c => c.cSerialNo == delId);
                        context.ProvenProduct.Remove(provenProduct);
                    }
                    else
                    {

                        list.Remove(item.Cells[0].Value.ToString());
                    }
                    foreach (DataGridViewRow row in dataGridViewProducts.Rows)
                    {
                        var xxx = row.Cells[0].Value.ToString().Trim();
                        if ((xxx != null) && (xxx.Equals(item.Cells[0].Value.ToString())))
                        {
                            row.DefaultCellStyle.BackColor = Color.Empty;
                        }
                    }

                    dataOwnedProducts.RemoveAt(item.Index);

                }
                context.SaveChanges();
                dataGridViewProvenProduct.DataSource = null;
                dataGridViewProvenProduct.DataSource = dataOwnedProducts;
                dataGridViewProvenProduct.Columns["deliveryNoteID"].Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
