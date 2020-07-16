namespace Warehouse
{
    partial class FormZalogowano
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.warehouseDatabaseDataSet = new Warehouse.warehouseDatabaseDataSet();
            this.invoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoiceTableAdapter = new Warehouse.warehouseDatabaseDataSetTableAdapters.invoiceTableAdapter();
            this.providerIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryReportNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfItems = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.providerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1693, 438);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 57);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.providerIDDataGridViewTextBoxColumn,
            this.deliveryReportNoDataGridViewTextBoxColumn,
            this.deliveryDateDataGridViewTextBoxColumn,
            this.numberOfItems,
            this.providerID});
            this.dataGridView1.DataSource = this.invoiceBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-2, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1674, 1006);
            this.dataGridView1.TabIndex = 1;
            // 
            // warehouseDatabaseDataSet
            // 
            this.warehouseDatabaseDataSet.DataSetName = "warehouseDatabaseDataSet";
            this.warehouseDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // invoiceBindingSource
            // 
            this.invoiceBindingSource.DataMember = "invoice";
            this.invoiceBindingSource.DataSource = this.warehouseDatabaseDataSet;
            // 
            // invoiceTableAdapter
            // 
            this.invoiceTableAdapter.ClearBeforeFill = true;
            // 
            // providerIDDataGridViewTextBoxColumn
            // 
            this.providerIDDataGridViewTextBoxColumn.DataPropertyName = "providerID";
            this.providerIDDataGridViewTextBoxColumn.HeaderText = "providerID";
            this.providerIDDataGridViewTextBoxColumn.Name = "providerIDDataGridViewTextBoxColumn";
            // 
            // deliveryReportNoDataGridViewTextBoxColumn
            // 
            this.deliveryReportNoDataGridViewTextBoxColumn.DataPropertyName = "deliveryReportNo";
            this.deliveryReportNoDataGridViewTextBoxColumn.HeaderText = "deliveryReportNo";
            this.deliveryReportNoDataGridViewTextBoxColumn.Name = "deliveryReportNoDataGridViewTextBoxColumn";
            // 
            // deliveryDateDataGridViewTextBoxColumn
            // 
            this.deliveryDateDataGridViewTextBoxColumn.DataPropertyName = "deliveryDate";
            this.deliveryDateDataGridViewTextBoxColumn.HeaderText = "deliveryDate";
            this.deliveryDateDataGridViewTextBoxColumn.Name = "deliveryDateDataGridViewTextBoxColumn";
            // 
            // numberOfItems
            // 
            this.numberOfItems.DataPropertyName = "numberOfItems";
            this.numberOfItems.HeaderText = "numberOfItems";
            this.numberOfItems.Name = "numberOfItems";
            // 
            // providerID
            // 
            this.providerID.DataPropertyName = "providerID";
            this.providerID.HeaderText = "providerID";
            this.providerID.Name = "providerID";
            this.providerID.ReadOnly = true;
            // 
            // FormZalogowano
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1800, 932);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Name = "FormZalogowano";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormZalogowano";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormZalogowano_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private warehouseDatabaseDataSet warehouseDatabaseDataSet;
        private System.Windows.Forms.BindingSource invoiceBindingSource;
        private warehouseDatabaseDataSetTableAdapters.invoiceTableAdapter invoiceTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn providerIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryReportNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn providerID;
    }
}