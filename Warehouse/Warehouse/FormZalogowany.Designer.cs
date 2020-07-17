namespace Warehouse
{
    partial class FormZalogowany
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.warehouseDatabaseDataSet = new Warehouse.warehouseDatabaseDataSet();
            this.providerInvoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.providerInvoiceTableAdapter = new Warehouse.warehouseDatabaseDataSetTableAdapters.ProviderInvoiceTableAdapter();
            this.deliveryDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryReportNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfItemsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonWyloguj = new System.Windows.Forms.Button();
            this.buttonDodajPDF = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.providerInvoiceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.deliveryDateDataGridViewTextBoxColumn,
            this.deliveryReportNoDataGridViewTextBoxColumn,
            this.companyNameDataGridViewTextBoxColumn,
            this.numberOfItemsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.providerInvoiceBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-1, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(443, 571);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // warehouseDatabaseDataSet
            // 
            this.warehouseDatabaseDataSet.DataSetName = "warehouseDatabaseDataSet";
            this.warehouseDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // providerInvoiceBindingSource
            // 
            this.providerInvoiceBindingSource.DataMember = "ProviderInvoice";
            this.providerInvoiceBindingSource.DataSource = this.warehouseDatabaseDataSet;
            // 
            // providerInvoiceTableAdapter
            // 
            this.providerInvoiceTableAdapter.ClearBeforeFill = true;
            // 
            // deliveryDateDataGridViewTextBoxColumn
            // 
            this.deliveryDateDataGridViewTextBoxColumn.DataPropertyName = "deliveryDate";
            this.deliveryDateDataGridViewTextBoxColumn.HeaderText = "deliveryDate";
            this.deliveryDateDataGridViewTextBoxColumn.Name = "deliveryDateDataGridViewTextBoxColumn";
            this.deliveryDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deliveryReportNoDataGridViewTextBoxColumn
            // 
            this.deliveryReportNoDataGridViewTextBoxColumn.DataPropertyName = "deliveryReportNo";
            this.deliveryReportNoDataGridViewTextBoxColumn.HeaderText = "deliveryReportNo";
            this.deliveryReportNoDataGridViewTextBoxColumn.Name = "deliveryReportNoDataGridViewTextBoxColumn";
            this.deliveryReportNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // companyNameDataGridViewTextBoxColumn
            // 
            this.companyNameDataGridViewTextBoxColumn.DataPropertyName = "companyName";
            this.companyNameDataGridViewTextBoxColumn.HeaderText = "companyName";
            this.companyNameDataGridViewTextBoxColumn.Name = "companyNameDataGridViewTextBoxColumn";
            this.companyNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numberOfItemsDataGridViewTextBoxColumn
            // 
            this.numberOfItemsDataGridViewTextBoxColumn.DataPropertyName = "numberOfItems";
            this.numberOfItemsDataGridViewTextBoxColumn.HeaderText = "numberOfItems";
            this.numberOfItemsDataGridViewTextBoxColumn.Name = "numberOfItemsDataGridViewTextBoxColumn";
            this.numberOfItemsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // buttonWyloguj
            // 
            this.buttonWyloguj.Location = new System.Drawing.Point(1392, 464);
            this.buttonWyloguj.Name = "buttonWyloguj";
            this.buttonWyloguj.Size = new System.Drawing.Size(179, 107);
            this.buttonWyloguj.TabIndex = 1;
            this.buttonWyloguj.Text = "Wyloguj";
            this.buttonWyloguj.UseVisualStyleBackColor = true;
            this.buttonWyloguj.Click += new System.EventHandler(this.buttonWyloguj_Click);
            // 
            // buttonDodajPDF
            // 
            this.buttonDodajPDF.Location = new System.Drawing.Point(1392, 302);
            this.buttonDodajPDF.Name = "buttonDodajPDF";
            this.buttonDodajPDF.Size = new System.Drawing.Size(179, 110);
            this.buttonDodajPDF.TabIndex = 2;
            this.buttonDodajPDF.Text = "Dodaj Fakture";
            this.buttonDodajPDF.UseVisualStyleBackColor = true;
            // 
            // FormZalogowany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1583, 932);
            this.Controls.Add(this.buttonDodajPDF);
            this.Controls.Add(this.buttonWyloguj);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormZalogowany";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormZalogowany_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.providerInvoiceBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private warehouseDatabaseDataSet warehouseDatabaseDataSet;
        private System.Windows.Forms.BindingSource providerInvoiceBindingSource;
        private warehouseDatabaseDataSetTableAdapters.ProviderInvoiceTableAdapter providerInvoiceTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryReportNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfItemsDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonWyloguj;
        private System.Windows.Forms.Button buttonDodajPDF;
    }
}