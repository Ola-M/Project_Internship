using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warehouse.deliveryCheck
{
    public class LoadOwnedProduct
    {
        ProvenProduct pProduct;
        warehouseDatabaseEntities1 context = new warehouseDatabaseEntities1();
        List<OwnedProductView> data = new List<OwnedProductView>();
        public void loadProducts(DataGridView dataGridView, int cos, DataGridView dataGridView1)
        {
             this.data = (from c in context.OwnedProductView where c.deliveryNoteID == cos select c).ToList();
            dataGridView.DataSource = data;
            dataGridView.Columns["deliveryNoteID"].Visible = false;
            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                var x = row.Cells[0].Value.ToString().Trim();
                pProduct = context.ProvenProduct.FirstOrDefault(c => c.cSerialNo == x);
                if ((pProduct != null)&&(pProduct.cSerialNo.Trim().Equals(x)))
                {
                    row.DefaultCellStyle.BackColor = Color.Purple;
                    
                }
            }
            


        }
        public void addSerial(DataGridView dataGridView, DataGridView dataGridView1, TextBox textBox)
        {
            
            if (serialExist(textBox))
            {
                if (serialRepeat(dataGridView, textBox)) {
                    this.data.Add(new OwnedProductView() { Serial = textBox.Text.Trim() });
                    dataGridView.DataSource = null;

                    dataGridView.DataSource = data;
                    rowsColor(dataGridView1, textBox);
                    dataGridView.Columns["deliveryNoteID"].Visible = false;
                    textBox.Clear();
                } 
            }
            
        

        }
        private bool serialExist(TextBox textBox)
        {
            Product product = context.Product.FirstOrDefault(c => c.serialNo == textBox.Text);
            if (product != null){
                return true;
            }
            else
            {
                return false;
            }

        }
        private bool serialRepeat(DataGridView dataGridView, TextBox textBox)
        {
            String searchValue = textBox.Text;
            
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Cells[0].Value.ToString().Equals(searchValue.Trim()))
                {
                   
                    return false;
                }
            }
            return true;
            

        }
        private void rowsColor(DataGridView dataGridView1, TextBox textBox)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                var tableValue = row.Cells[0].Value.ToString().Trim();
                if (tableValue.Equals(textBox.Text.Trim()))
                {

                    row.DefaultCellStyle.BackColor = Color.LemonChiffon;
                }

            }

        }


    }
}
