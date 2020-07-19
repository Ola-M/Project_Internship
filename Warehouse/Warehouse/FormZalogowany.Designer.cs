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
            this.providerInvoiceBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.warehouseDatabaseDataSet = new Warehouse.warehouseDatabaseDataSet();
            this.buttonWyloguj = new System.Windows.Forms.Button();
            this.buttonDodajPDF = new System.Windows.Forms.Button();
            this.warehouseDatabaseDataSet1 = new Warehouse.warehouseDatabaseDataSet1();
            this.providerInvoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.providerInvoiceTableAdapter = new Warehouse.warehouseDatabaseDataSetTableAdapters.ProviderInvoiceTableAdapter();
            this.textBoxLokalizacjaPliku = new System.Windows.Forms.TextBox();
            this.comboBoxWidok = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.warehouseDatabaseDataSet2 = new Warehouse.warehouseDatabaseDataSet2();
            this.invoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoiceTableAdapter = new Warehouse.warehouseDatabaseDataSet2TableAdapters.invoiceTableAdapter();
            this.invoiceID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.providerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryReportNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfItems = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orderNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serialNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.providerInvoiceBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseDatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.providerInvoiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseDatabaseDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.invoiceID,
            this.providerID,
            this.deliveryReportNoDataGridViewTextBoxColumn,
            this.deliveryDate,
            this.numberOfItems,
            this.company,
            this.orderNumber,
            this.itemNumber,
            this.productCode,
            this.productName,
            this.serialNo});
            this.dataGridView1.DataSource = this.invoiceBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1307, 358);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // providerInvoiceBindingSource1
            // 
            this.providerInvoiceBindingSource1.DataMember = "ProviderInvoice";
            this.providerInvoiceBindingSource1.DataSource = this.warehouseDatabaseDataSet;
            // 
            // warehouseDatabaseDataSet
            // 
            this.warehouseDatabaseDataSet.DataSetName = "warehouseDatabaseDataSet";
            this.warehouseDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonWyloguj
            // 
            this.buttonWyloguj.Location = new System.Drawing.Point(1054, 568);
            this.buttonWyloguj.Margin = new System.Windows.Forms.Padding(4);
            this.buttonWyloguj.Name = "buttonWyloguj";
            this.buttonWyloguj.Size = new System.Drawing.Size(239, 52);
            this.buttonWyloguj.TabIndex = 1;
            this.buttonWyloguj.Text = "Wyloguj";
            this.buttonWyloguj.UseVisualStyleBackColor = true;
            this.buttonWyloguj.Click += new System.EventHandler(this.buttonWyloguj_Click);
            // 
            // buttonDodajPDF
            // 
            this.buttonDodajPDF.Location = new System.Drawing.Point(741, 409);
            this.buttonDodajPDF.Margin = new System.Windows.Forms.Padding(4);
            this.buttonDodajPDF.Name = "buttonDodajPDF";
            this.buttonDodajPDF.Size = new System.Drawing.Size(239, 52);
            this.buttonDodajPDF.TabIndex = 2;
            this.buttonDodajPDF.Text = "Dodaj Fakture";
            this.buttonDodajPDF.UseVisualStyleBackColor = true;
            this.buttonDodajPDF.Click += new System.EventHandler(this.buttonDodajPDF_Click);
            // 
            // warehouseDatabaseDataSet1
            // 
            this.warehouseDatabaseDataSet1.DataSetName = "warehouseDatabaseDataSet1";
            this.warehouseDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // providerInvoiceBindingSource
            // 
            this.providerInvoiceBindingSource.DataMember = "ProviderInvoice";
            // 
            // providerInvoiceTableAdapter
            // 
            this.providerInvoiceTableAdapter.ClearBeforeFill = true;
            // 
            // textBoxLokalizacjaPliku
            // 
            this.textBoxLokalizacjaPliku.Location = new System.Drawing.Point(34, 424);
            this.textBoxLokalizacjaPliku.Name = "textBoxLokalizacjaPliku";
            this.textBoxLokalizacjaPliku.ReadOnly = true;
            this.textBoxLokalizacjaPliku.Size = new System.Drawing.Size(680, 22);
            this.textBoxLokalizacjaPliku.TabIndex = 3;
            // 
            // comboBoxWidok
            // 
            this.comboBoxWidok.FormattingEnabled = true;
            this.comboBoxWidok.Location = new System.Drawing.Point(34, 505);
            this.comboBoxWidok.Name = "comboBoxWidok";
            this.comboBoxWidok.Size = new System.Drawing.Size(121, 24);
            this.comboBoxWidok.TabIndex = 4;
            this.comboBoxWidok.SelectedIndexChanged += new System.EventHandler(this.comboBoxWidok_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 511);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // warehouseDatabaseDataSet2
            // 
            this.warehouseDatabaseDataSet2.DataSetName = "warehouseDatabaseDataSet2";
            this.warehouseDatabaseDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // invoiceBindingSource
            // 
            this.invoiceBindingSource.DataMember = "invoice";
            this.invoiceBindingSource.DataSource = this.warehouseDatabaseDataSet2;
            // 
            // invoiceTableAdapter
            // 
            this.invoiceTableAdapter.ClearBeforeFill = true;
            // 
            // invoiceID
            // 
            this.invoiceID.DataPropertyName = "invoiceID";
            this.invoiceID.HeaderText = "invoiceID";
            this.invoiceID.MinimumWidth = 6;
            this.invoiceID.Name = "invoiceID";
            this.invoiceID.ReadOnly = true;
            this.invoiceID.Width = 125;
            // 
            // providerID
            // 
            this.providerID.DataPropertyName = "providerID";
            this.providerID.HeaderText = "providerID";
            this.providerID.MinimumWidth = 6;
            this.providerID.Name = "providerID";
            this.providerID.Width = 125;
            // 
            // deliveryReportNoDataGridViewTextBoxColumn
            // 
            this.deliveryReportNoDataGridViewTextBoxColumn.DataPropertyName = "deliveryReportNo";
            this.deliveryReportNoDataGridViewTextBoxColumn.HeaderText = "deliveryReportNo";
            this.deliveryReportNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.deliveryReportNoDataGridViewTextBoxColumn.Name = "deliveryReportNoDataGridViewTextBoxColumn";
            this.deliveryReportNoDataGridViewTextBoxColumn.Width = 125;
            // 
            // deliveryDate
            // 
            this.deliveryDate.DataPropertyName = "deliveryDate";
            this.deliveryDate.HeaderText = "deliveryDate";
            this.deliveryDate.MinimumWidth = 6;
            this.deliveryDate.Name = "deliveryDate";
            this.deliveryDate.Width = 125;
            // 
            // numberOfItems
            // 
            this.numberOfItems.DataPropertyName = "numberOfItems";
            this.numberOfItems.HeaderText = "numberOfItems";
            this.numberOfItems.MinimumWidth = 6;
            this.numberOfItems.Name = "numberOfItems";
            this.numberOfItems.Width = 125;
            // 
            // company
            // 
            this.company.DataPropertyName = "company";
            this.company.HeaderText = "company";
            this.company.MinimumWidth = 6;
            this.company.Name = "company";
            this.company.Width = 125;
            // 
            // orderNumber
            // 
            this.orderNumber.DataPropertyName = "orderNumber";
            this.orderNumber.HeaderText = "orderNumber";
            this.orderNumber.MinimumWidth = 6;
            this.orderNumber.Name = "orderNumber";
            this.orderNumber.Width = 125;
            // 
            // itemNumber
            // 
            this.itemNumber.DataPropertyName = "itemNumber";
            this.itemNumber.HeaderText = "itemNumber";
            this.itemNumber.MinimumWidth = 6;
            this.itemNumber.Name = "itemNumber";
            this.itemNumber.Width = 125;
            // 
            // productCode
            // 
            this.productCode.DataPropertyName = "productCode";
            this.productCode.HeaderText = "productCode";
            this.productCode.MinimumWidth = 6;
            this.productCode.Name = "productCode";
            this.productCode.Width = 125;
            // 
            // productName
            // 
            this.productName.DataPropertyName = "productName";
            this.productName.HeaderText = "productName";
            this.productName.MinimumWidth = 6;
            this.productName.Name = "productName";
            this.productName.Width = 125;
            // 
            // serialNo
            // 
            this.serialNo.DataPropertyName = "serialNo";
            this.serialNo.HeaderText = "serialNo";
            this.serialNo.MinimumWidth = 6;
            this.serialNo.Name = "serialNo";
            this.serialNo.Width = 125;
            // 
            // FormZalogowany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1333, 633);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxWidok);
            this.Controls.Add(this.textBoxLokalizacjaPliku);
            this.Controls.Add(this.buttonDodajPDF);
            this.Controls.Add(this.buttonWyloguj);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormZalogowany";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormZalogowany_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.providerInvoiceBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseDatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.providerInvoiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseDatabaseDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonWyloguj;
        private System.Windows.Forms.Button buttonDodajPDF;
        private warehouseDatabaseDataSet1 warehouseDatabaseDataSet1;
        private System.Windows.Forms.BindingSource providerInvoiceBindingSource;
        private warehouseDatabaseDataSet warehouseDatabaseDataSet;
        private System.Windows.Forms.BindingSource providerInvoiceBindingSource1;
        private warehouseDatabaseDataSetTableAdapters.ProviderInvoiceTableAdapter providerInvoiceTableAdapter;
        private System.Windows.Forms.TextBox textBoxLokalizacjaPliku;
        private System.Windows.Forms.ComboBox comboBoxWidok;
        private System.Windows.Forms.Label label1;
        private warehouseDatabaseDataSet2 warehouseDatabaseDataSet2;
        private System.Windows.Forms.BindingSource invoiceBindingSource;
        private warehouseDatabaseDataSet2TableAdapters.invoiceTableAdapter invoiceTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn invoiceID;
        private System.Windows.Forms.DataGridViewTextBoxColumn providerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryReportNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfItems;
        private System.Windows.Forms.DataGridViewTextBoxColumn company;
        private System.Windows.Forms.DataGridViewTextBoxColumn orderNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn productCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn serialNo;
    }
}