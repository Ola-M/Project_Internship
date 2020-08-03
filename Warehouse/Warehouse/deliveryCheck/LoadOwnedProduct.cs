using Google.Protobuf.WellKnownTypes;
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
        List<OwnedProductView> dataOwnedProduct;
        DataGridView dataGridViewProvenProducts;
        DataGridView dataGridViewProducts;
        TextBox textBox;
        public LoadOwnedProduct(List<OwnedProductView> dataOwnedProduct, TextBox textBox, DataGridView dataGridViewProvenProducts, DataGridView dataGridViewProducts)
        {
            this.dataOwnedProduct = dataOwnedProduct;
            this.textBox = textBox;
            this.dataGridViewProvenProducts = dataGridViewProvenProducts;
            this.dataGridViewProducts = dataGridViewProducts;

        }
        public List<OwnedProductView> loadProducts( int deliveryNoteID)
        {
            this.dataOwnedProduct = (from c in context.OwnedProductView where c.deliveryNoteID == deliveryNoteID select c).ToList();
            dataGridViewProvenProducts.DataSource = this.dataOwnedProduct;
            dataGridViewProvenProducts.Columns["deliveryNoteID"].Visible = false;
            foreach(DataGridViewRow row in dataGridViewProducts.Rows)
            {
                var dataGridViewProductCell = row.Cells[0].Value.ToString().Trim();
                pProduct = context.ProvenProduct.FirstOrDefault(c => c.cSerialNo == dataGridViewProductCell);
                if ((pProduct != null)&&(pProduct.cSerialNo.Trim().Equals(dataGridViewProductCell)))
                {
                    row.DefaultCellStyle.BackColor = Color.Green;
                    
                }
            }
            {
                foreach (DataGridViewRow row in dataGridViewProvenProducts.Rows)
                {
                    if (row.Cells[4].Value.Equals(true))
                    {
                        row.DefaultCellStyle.BackColor = Color.Red;
                    }
                }

            }

            return this.dataOwnedProduct;

        }
        public void addSerial(List<string> list,TextBox textBoxAddSerial)
        {
            
            if (serialRepeat())
            {
                
                if (serialExist()) {
                    list.Add(textBoxAddSerial.Text.Trim());
                    addSerialToDbAndList();
                    rowsColorGreen();  
                }
                else
                {
                    list.Add(textBoxAddSerial.Text.Trim());
                    addSerialToDbAndList();
                    
                        rowsColorRed();
                }
                test();
            }
        }
        private void addSerialToDbAndList( )
        {
            this.dataOwnedProduct.Add(new OwnedProductView() { Serial = this.textBox.Text.Trim() });
            this.dataGridViewProvenProducts.DataSource = null;

            this.dataGridViewProvenProducts.DataSource = dataOwnedProduct;

            this.dataGridViewProvenProducts.Columns["deliveryNoteID"].Visible = false;
            
        }
        private bool serialExist()
        {
            Product product = context.Product.FirstOrDefault(c => c.serialNo == this.textBox.Text);
            if (product != null){
                return true;
            }
            else
            {
                return false;
            }

        }
        private bool serialRepeat()
        {
            String searchValue = this.textBox.Text;
            
            foreach (DataGridViewRow row in this.dataGridViewProvenProducts.Rows)
            {
                if (row.Cells[0].Value.ToString().Equals(searchValue.Trim()))
                {
                   
                    return false;
                }
            }
            return true;
            

        }
        private void rowsColorGreen()
        {
            foreach (DataGridViewRow row in this.dataGridViewProducts.Rows)
            {
                var tableValue = row.Cells[0].Value.ToString().Trim();
                if (tableValue.Equals(this.textBox.Text.Trim()))
                {

                    row.DefaultCellStyle.BackColor = Color.Green;
                }

            }

        }
        private void rowsColorRed()
        {
            foreach (DataGridViewRow row in this.dataGridViewProvenProducts.Rows)
            {
                var tableValue = row.Cells[0].Value.ToString().Trim();
                if (tableValue.Equals(this.textBox.Text.Trim()))
                {

                    row.DefaultCellStyle.BackColor = Color.Red;
                }

            }

        }
        
        private void test()
        {
            foreach (DataGridViewRow row in this.dataGridViewProvenProducts.Rows)
            {
                if ((row.Cells[4].Value != null)&&(row.Cells[4].Value.Equals(true)))
                {
                    row.DefaultCellStyle.BackColor = Color.Red;
                }
            }
        }

    }
}
