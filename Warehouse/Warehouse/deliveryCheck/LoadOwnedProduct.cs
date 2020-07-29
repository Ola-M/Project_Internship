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
        TextBox textBox;
        public LoadOwnedProduct(List<OwnedProductView> dataOwnedProduct, TextBox textBox)
        {
            this.dataOwnedProduct = dataOwnedProduct;
            this.textBox = textBox;

        }
        public void loadProducts(DataGridView dataGridView, int deliveryNoteID, DataGridView dataGridView1)
        {
            this.dataOwnedProduct = (from c in context.OwnedProductView where c.deliveryNoteID == deliveryNoteID select c).ToList();
            dataGridView.DataSource = this.dataOwnedProduct;
            dataGridView.Columns["deliveryNoteID"].Visible = false;
            foreach(DataGridViewRow row in dataGridView1.Rows)
            {
                var dataGridViewProductCell = row.Cells[0].Value.ToString().Trim();
                pProduct = context.ProvenProduct.FirstOrDefault(c => c.cSerialNo == dataGridViewProductCell);
                if ((pProduct != null)&&(pProduct.cSerialNo.Trim().Equals(dataGridViewProductCell)))
                {
                    row.DefaultCellStyle.BackColor = Color.Green;
                    
                }
            }
            


        }
        public void addSerial(DataGridView dataGridView, DataGridView dataGridView1)
        {
            
            if (serialRepeat(dataGridView))
            {
                
                if (serialExist()) {
                    addSerialToDbAndList(dataGridView, dataGridView1);
                }
            }
        }
        private void addSerialToDbAndList(DataGridView dataGridView, DataGridView dataGridView1)
        {
            this.dataOwnedProduct.Add(new OwnedProductView() { Serial = this.textBox.Text.Trim() });
            dataGridView.DataSource = null;

            dataGridView.DataSource = dataOwnedProduct;
            rowsColor(dataGridView1);
            dataGridView.Columns["deliveryNoteID"].Visible = false;
            this.textBox.Clear();
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
        private bool serialRepeat(DataGridView dataGridView)
        {
            String searchValue = this.textBox.Text;
            
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                if (row.Cells[0].Value.ToString().Equals(searchValue.Trim()))
                {
                   
                    return false;
                }
            }
            return true;
            

        }
        private void rowsColor(DataGridView dataGridView1)
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                var tableValue = row.Cells[0].Value.ToString().Trim();
                if (tableValue.Equals(this.textBox.Text.Trim()))
                {

                    row.DefaultCellStyle.BackColor = Color.Green;
                }

            }

        }
        public void removeProduct(DataGridView dataGridView, List<string> list, DataGridView dataGridViewProduct)
        {
            try
            {
                ProvenProduct provenProduct;
                String delId;
                foreach (DataGridViewRow item in dataGridView.SelectedRows)
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
                    foreach (DataGridViewRow row in dataGridViewProduct.Rows)
                    {
                        var xxx = row.Cells[0].Value.ToString().Trim();
                        if ((xxx != null) && (xxx.Equals(item.Cells[0].Value.ToString())))
                        {
                            row.DefaultCellStyle.BackColor = Color.Empty;
                        }
                    }

                    this.dataOwnedProduct.RemoveAt(item.Index);

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
