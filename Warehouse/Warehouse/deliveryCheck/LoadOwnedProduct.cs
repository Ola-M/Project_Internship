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
        warehouseDatabaseEntities1 context = new warehouseDatabaseEntities1();
        List<OwnedProductView> data = new List<OwnedProductView>();
        public void loadProducts(DataGridView dataGridView, int cos)
        {
             this.data = (from c in context.OwnedProductView where c.deliveryNoteID == cos select c).ToList();
            dataGridView.DataSource = data;
           // dataGridView.Columns["deliveryNoteID"].Visible = false;

        }
        public void addSerial(DataGridView dataGridView, DataGridView dataGridView1, TextBox textBox)
        {
            
            if (serialExist(textBox))
            {
                if (serialRepeat(dataGridView, textBox)) {
                    this.data.Add(new OwnedProductView() { Serial = textBox.Text });
                    dataGridView.DataSource = null;

                    dataGridView.DataSource = data;
                         foreach (DataGridViewRow row in dataGridView1.Rows)
                    {
                      
                        row.DefaultCellStyle.BackColor = Color.Green;
                    }
                    //  dataGridView.Columns["deliveryNoteID"].Visible = false;
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
                if (row.Cells[0].Value.ToString().Equals(searchValue))
                {
                   
                    return false;
                }
            }
            return true;
            

        }
        private int m1(DataGridView dataGridView, TextBox textBox)
        {
            String searchValue = textBox.Text;

            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Cells[8].Value.ToString().Equals(searchValue))
                {

                    return row.Index ;
                }
            }
            return 0;

        }

    }
}
