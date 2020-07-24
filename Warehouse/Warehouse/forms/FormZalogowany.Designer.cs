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
            this.buttonWyloguj = new System.Windows.Forms.Button();
            this.buttonDodajPDF = new System.Windows.Forms.Button();
            this.textBoxLokalizacjaPliku = new System.Windows.Forms.TextBox();
            this.comboBoxWidok = new System.Windows.Forms.ComboBox();
            this.labelTest = new System.Windows.Forms.Label();
            this.dataGridViewInvoice = new System.Windows.Forms.DataGridView();
            this.dataGridViewProviderInvoice = new System.Windows.Forms.DataGridView();
            this.deliveryID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invoiceDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfItemsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.deliveryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryViewBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.warehouseDatabaseDeliveryView1 = new Warehouse.warehouseDatabaseDeliveryView1();
            this.deliveryViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.warehouseDatabaseDataSetView = new Warehouse.warehouseDatabaseDataSetView();
            this.buttonDodajExcelDoBazy = new System.Windows.Forms.Button();
            this.deliveryViewTableAdapter = new Warehouse.warehouseDatabaseDataSetViewTableAdapters.DeliveryViewTableAdapter();
            this.warehouseDatabaseDataSetProduct = new Warehouse.warehouseDatabaseDataSetProduct();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productTableAdapter = new Warehouse.warehouseDatabaseDataSetProductTableAdapters.ProductTableAdapter();
            this.warehouseDatabaseDataSet = new Warehouse.warehouseDatabaseDataSet();
            this.deliveryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deliveryTableAdapter = new Warehouse.warehouseDatabaseDataSetTableAdapters.DeliveryTableAdapter();
            this.deliveryViewTableAdapter1 = new Warehouse.warehouseDatabaseDeliveryView1TableAdapters.DeliveryViewTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProviderInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryViewBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseDatabaseDeliveryView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseDatabaseDataSetView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseDatabaseDataSetProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonWyloguj
            // 
            this.buttonWyloguj.Location = new System.Drawing.Point(809, 598);
            this.buttonWyloguj.Name = "buttonWyloguj";
            this.buttonWyloguj.Size = new System.Drawing.Size(179, 42);
            this.buttonWyloguj.TabIndex = 1;
            this.buttonWyloguj.Text = "Wyloguj";
            this.buttonWyloguj.UseVisualStyleBackColor = true;
            this.buttonWyloguj.Click += new System.EventHandler(this.buttonWyloguj_Click);
            // 
            // buttonDodajPDF
            // 
            this.buttonDodajPDF.Location = new System.Drawing.Point(556, 344);
            this.buttonDodajPDF.Name = "buttonDodajPDF";
            this.buttonDodajPDF.Size = new System.Drawing.Size(50, 20);
            this.buttonDodajPDF.TabIndex = 2;
            this.buttonDodajPDF.Text = "...";
            this.buttonDodajPDF.UseVisualStyleBackColor = true;
            this.buttonDodajPDF.Click += new System.EventHandler(this.buttonDodajPDF_Click);
            // 
            // textBoxLokalizacjaPliku
            // 
            this.textBoxLokalizacjaPliku.Location = new System.Drawing.Point(26, 344);
            this.textBoxLokalizacjaPliku.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxLokalizacjaPliku.Name = "textBoxLokalizacjaPliku";
            this.textBoxLokalizacjaPliku.ReadOnly = true;
            this.textBoxLokalizacjaPliku.Size = new System.Drawing.Size(511, 20);
            this.textBoxLokalizacjaPliku.TabIndex = 3;
            // 
            // comboBoxWidok
            // 
            this.comboBoxWidok.FormattingEnabled = true;
            this.comboBoxWidok.Location = new System.Drawing.Point(117, 412);
            this.comboBoxWidok.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxWidok.Name = "comboBoxWidok";
            this.comboBoxWidok.Size = new System.Drawing.Size(92, 21);
            this.comboBoxWidok.TabIndex = 4;
            this.comboBoxWidok.SelectedIndexChanged += new System.EventHandler(this.comboBoxWidok_SelectedIndexChanged);
            // 
            // labelTest
            // 
            this.labelTest.AutoSize = true;
            this.labelTest.Location = new System.Drawing.Point(45, 420);
            this.labelTest.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTest.Name = "labelTest";
            this.labelTest.Size = new System.Drawing.Size(35, 13);
            this.labelTest.TabIndex = 5;
            this.labelTest.Text = "label1";
            // 
            // dataGridViewInvoice
            // 
            this.dataGridViewInvoice.AllowUserToAddRows = false;
            this.dataGridViewInvoice.AllowUserToDeleteRows = false;
            this.dataGridViewInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewInvoice.Location = new System.Drawing.Point(26, 29);
            this.dataGridViewInvoice.Name = "dataGridViewInvoice";
            this.dataGridViewInvoice.ReadOnly = true;
            this.dataGridViewInvoice.Size = new System.Drawing.Size(709, 150);
            this.dataGridViewInvoice.TabIndex = 6;
            // 
            // dataGridViewProviderInvoice
            // 
            this.dataGridViewProviderInvoice.AllowUserToAddRows = false;
            this.dataGridViewProviderInvoice.AllowUserToDeleteRows = false;
            this.dataGridViewProviderInvoice.AutoGenerateColumns = false;
            this.dataGridViewProviderInvoice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProviderInvoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.deliveryID,
            this.deliveryNumberDataGridViewTextBoxColumn,
            this.invoiceDateDataGridViewTextBoxColumn,
            this.numberOfItemsDataGridViewTextBoxColumn,
            this.companyNameDataGridViewTextBoxColumn,
            this.checkedDataGridViewCheckBoxColumn,
            this.deliveryIDDataGridViewTextBoxColumn});
            this.dataGridViewProviderInvoice.DataSource = this.deliveryViewBindingSource1;
            this.dataGridViewProviderInvoice.Location = new System.Drawing.Point(26, 505);
            this.dataGridViewProviderInvoice.Name = "dataGridViewProviderInvoice";
            this.dataGridViewProviderInvoice.ReadOnly = true;
            this.dataGridViewProviderInvoice.Size = new System.Drawing.Size(709, 150);
            this.dataGridViewProviderInvoice.TabIndex = 7;
            this.dataGridViewProviderInvoice.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProviderInvoice_CellDoubleClick);
            // 
            // deliveryID
            // 
            this.deliveryID.DataPropertyName = "deliveryID";
            this.deliveryID.HeaderText = "deliveryID";
            this.deliveryID.Name = "deliveryID";
            this.deliveryID.ReadOnly = true;
            this.deliveryID.Visible = false;
            // 
            // deliveryNumberDataGridViewTextBoxColumn
            // 
            this.deliveryNumberDataGridViewTextBoxColumn.DataPropertyName = "deliveryNumber";
            this.deliveryNumberDataGridViewTextBoxColumn.HeaderText = "deliveryNumber";
            this.deliveryNumberDataGridViewTextBoxColumn.Name = "deliveryNumberDataGridViewTextBoxColumn";
            this.deliveryNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // invoiceDateDataGridViewTextBoxColumn
            // 
            this.invoiceDateDataGridViewTextBoxColumn.DataPropertyName = "invoiceDate";
            this.invoiceDateDataGridViewTextBoxColumn.HeaderText = "invoiceDate";
            this.invoiceDateDataGridViewTextBoxColumn.Name = "invoiceDateDataGridViewTextBoxColumn";
            this.invoiceDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numberOfItemsDataGridViewTextBoxColumn
            // 
            this.numberOfItemsDataGridViewTextBoxColumn.DataPropertyName = "numberOfItems";
            this.numberOfItemsDataGridViewTextBoxColumn.HeaderText = "numberOfItems";
            this.numberOfItemsDataGridViewTextBoxColumn.Name = "numberOfItemsDataGridViewTextBoxColumn";
            this.numberOfItemsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // companyNameDataGridViewTextBoxColumn
            // 
            this.companyNameDataGridViewTextBoxColumn.DataPropertyName = "companyName";
            this.companyNameDataGridViewTextBoxColumn.HeaderText = "companyName";
            this.companyNameDataGridViewTextBoxColumn.Name = "companyNameDataGridViewTextBoxColumn";
            this.companyNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // checkedDataGridViewCheckBoxColumn
            // 
            this.checkedDataGridViewCheckBoxColumn.DataPropertyName = "checked";
            this.checkedDataGridViewCheckBoxColumn.HeaderText = "checked";
            this.checkedDataGridViewCheckBoxColumn.Name = "checkedDataGridViewCheckBoxColumn";
            this.checkedDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // deliveryIDDataGridViewTextBoxColumn
            // 
            this.deliveryIDDataGridViewTextBoxColumn.DataPropertyName = "deliveryID";
            this.deliveryIDDataGridViewTextBoxColumn.HeaderText = "deliveryID";
            this.deliveryIDDataGridViewTextBoxColumn.Name = "deliveryIDDataGridViewTextBoxColumn";
            this.deliveryIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.deliveryIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // deliveryViewBindingSource1
            // 
            this.deliveryViewBindingSource1.DataMember = "DeliveryView";
            this.deliveryViewBindingSource1.DataSource = this.warehouseDatabaseDeliveryView1;
            // 
            // warehouseDatabaseDeliveryView1
            // 
            this.warehouseDatabaseDeliveryView1.DataSetName = "warehouseDatabaseDeliveryView1";
            this.warehouseDatabaseDeliveryView1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // deliveryViewBindingSource
            // 
            this.deliveryViewBindingSource.DataMember = "DeliveryView";
            this.deliveryViewBindingSource.DataSource = this.warehouseDatabaseDataSetView;
            // 
            // warehouseDatabaseDataSetView
            // 
            this.warehouseDatabaseDataSetView.DataSetName = "warehouseDatabaseDataSetView";
            this.warehouseDatabaseDataSetView.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonDodajExcelDoBazy
            // 
            this.buttonDodajExcelDoBazy.Location = new System.Drawing.Point(234, 412);
            this.buttonDodajExcelDoBazy.Name = "buttonDodajExcelDoBazy";
            this.buttonDodajExcelDoBazy.Size = new System.Drawing.Size(101, 21);
            this.buttonDodajExcelDoBazy.TabIndex = 8;
            this.buttonDodajExcelDoBazy.Text = "Dodaj";
            this.buttonDodajExcelDoBazy.UseVisualStyleBackColor = true;
            this.buttonDodajExcelDoBazy.Click += new System.EventHandler(this.buttonDodajExcelDoBazy_Click);
            // 
            // deliveryViewTableAdapter
            // 
            this.deliveryViewTableAdapter.ClearBeforeFill = true;
            // 
            // warehouseDatabaseDataSetProduct
            // 
            this.warehouseDatabaseDataSetProduct.DataSetName = "warehouseDatabaseDataSetProduct";
            this.warehouseDatabaseDataSetProduct.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "Product";
            this.productBindingSource.DataSource = this.warehouseDatabaseDataSetProduct;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // warehouseDatabaseDataSet
            // 
            this.warehouseDatabaseDataSet.DataSetName = "warehouseDatabaseDataSet";
            this.warehouseDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // deliveryBindingSource
            // 
            this.deliveryBindingSource.DataMember = "Delivery";
            this.deliveryBindingSource.DataSource = this.warehouseDatabaseDataSet;
            // 
            // deliveryTableAdapter
            // 
            this.deliveryTableAdapter.ClearBeforeFill = true;
            // 
            // deliveryViewTableAdapter1
            // 
            this.deliveryViewTableAdapter1.ClearBeforeFill = true;
            // 
            // FormZalogowany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1008, 675);
            this.Controls.Add(this.buttonDodajExcelDoBazy);
            this.Controls.Add(this.dataGridViewProviderInvoice);
            this.Controls.Add(this.dataGridViewInvoice);
            this.Controls.Add(this.labelTest);
            this.Controls.Add(this.comboBoxWidok);
            this.Controls.Add(this.textBoxLokalizacjaPliku);
            this.Controls.Add(this.buttonDodajPDF);
            this.Controls.Add(this.buttonWyloguj);
            this.Name = "FormZalogowany";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormZalogowany_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProviderInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryViewBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseDatabaseDeliveryView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseDatabaseDataSetView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseDatabaseDataSetProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.deliveryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonWyloguj;
        private System.Windows.Forms.DataGridView dataGridViewInvoice;
        private System.Windows.Forms.DataGridView dataGridViewProviderInvoice;
        public System.Windows.Forms.ComboBox comboBoxWidok;
        private warehouseDatabaseDataSetView warehouseDatabaseDataSetView;
        private System.Windows.Forms.BindingSource deliveryViewBindingSource;
        private warehouseDatabaseDataSetViewTableAdapters.DeliveryViewTableAdapter deliveryViewTableAdapter;
        private warehouseDatabaseDataSetProduct warehouseDatabaseDataSetProduct;
        public System.Windows.Forms.BindingSource productBindingSource;
        private warehouseDatabaseDataSetProductTableAdapters.ProductTableAdapter productTableAdapter;
        public System.Windows.Forms.TextBox textBoxLokalizacjaPliku;
        public System.Windows.Forms.Label labelTest;
        public System.Windows.Forms.Button buttonDodajExcelDoBazy;
        private System.Windows.Forms.Button buttonDodajPDF;
        private warehouseDatabaseDeliveryView1 warehouseDatabaseDeliveryView1;
        private System.Windows.Forms.BindingSource deliveryViewBindingSource1;
        private warehouseDatabaseDeliveryView1TableAdapters.DeliveryViewTableAdapter deliveryViewTableAdapter1;
        private warehouseDatabaseDataSet warehouseDatabaseDataSet;
        private System.Windows.Forms.BindingSource deliveryBindingSource;
        private warehouseDatabaseDataSetTableAdapters.DeliveryTableAdapter deliveryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryID;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfItemsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn checkedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryIDDataGridViewTextBoxColumn;
    }
}