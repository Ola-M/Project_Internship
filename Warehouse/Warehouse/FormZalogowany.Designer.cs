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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewInvoice = new System.Windows.Forms.DataGridView();
            this.dataGridViewProviderInvoice = new System.Windows.Forms.DataGridView();
            this.deliveryReportNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfItemsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryStatusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.providerInvoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.warehouseDatabaseDataSet = new Warehouse.warehouseDatabaseDataSet();
            this.buttonDodajExcelDoBazy = new System.Windows.Forms.Button();
            this.providerInvoiceTableAdapter = new Warehouse.warehouseDatabaseDataSetTableAdapters.ProviderInvoiceTableAdapter();
            this.warehouseDatabaseDataSetInvoice = new Warehouse.warehouseDatabaseDataSetInvoice();
            this.invoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoiceTableAdapter = new Warehouse.warehouseDatabaseDataSetInvoiceTableAdapters.InvoiceTableAdapter();
            this.mySqlDataAdapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProviderInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.providerInvoiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseDatabaseDataSetInvoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).BeginInit();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 420);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
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
            this.deliveryReportNoDataGridViewTextBoxColumn,
            this.deliveryDateDataGridViewTextBoxColumn,
            this.companyNameDataGridViewTextBoxColumn,
            this.numberOfItemsDataGridViewTextBoxColumn,
            this.addDateDataGridViewTextBoxColumn,
            this.deliveryStatusDataGridViewCheckBoxColumn});
            this.dataGridViewProviderInvoice.DataSource = this.providerInvoiceBindingSource;
            this.dataGridViewProviderInvoice.Location = new System.Drawing.Point(26, 505);
            this.dataGridViewProviderInvoice.Name = "dataGridViewProviderInvoice";
            this.dataGridViewProviderInvoice.ReadOnly = true;
            this.dataGridViewProviderInvoice.Size = new System.Drawing.Size(709, 150);
            this.dataGridViewProviderInvoice.TabIndex = 7;
            this.dataGridViewProviderInvoice.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProviderInvoice_CellClick);
            // 
            // deliveryReportNoDataGridViewTextBoxColumn
            // 
            this.deliveryReportNoDataGridViewTextBoxColumn.DataPropertyName = "deliveryReportNo";
            this.deliveryReportNoDataGridViewTextBoxColumn.HeaderText = "deliveryReportNo";
            this.deliveryReportNoDataGridViewTextBoxColumn.Name = "deliveryReportNoDataGridViewTextBoxColumn";
            this.deliveryReportNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deliveryDateDataGridViewTextBoxColumn
            // 
            this.deliveryDateDataGridViewTextBoxColumn.DataPropertyName = "deliveryDate";
            this.deliveryDateDataGridViewTextBoxColumn.HeaderText = "deliveryDate";
            this.deliveryDateDataGridViewTextBoxColumn.Name = "deliveryDateDataGridViewTextBoxColumn";
            this.deliveryDateDataGridViewTextBoxColumn.ReadOnly = true;
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
            // addDateDataGridViewTextBoxColumn
            // 
            this.addDateDataGridViewTextBoxColumn.DataPropertyName = "addDate";
            this.addDateDataGridViewTextBoxColumn.HeaderText = "addDate";
            this.addDateDataGridViewTextBoxColumn.Name = "addDateDataGridViewTextBoxColumn";
            this.addDateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // deliveryStatusDataGridViewCheckBoxColumn
            // 
            this.deliveryStatusDataGridViewCheckBoxColumn.DataPropertyName = "deliveryStatus";
            this.deliveryStatusDataGridViewCheckBoxColumn.HeaderText = "deliveryStatus";
            this.deliveryStatusDataGridViewCheckBoxColumn.Name = "deliveryStatusDataGridViewCheckBoxColumn";
            this.deliveryStatusDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // providerInvoiceBindingSource
            // 
            this.providerInvoiceBindingSource.DataMember = "ProviderInvoice";
            this.providerInvoiceBindingSource.DataSource = this.warehouseDatabaseDataSet;
            // 
            // warehouseDatabaseDataSet
            // 
            this.warehouseDatabaseDataSet.DataSetName = "warehouseDatabaseDataSet";
            this.warehouseDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // providerInvoiceTableAdapter
            // 
            this.providerInvoiceTableAdapter.ClearBeforeFill = true;
            // 
            // warehouseDatabaseDataSetInvoice
            // 
            this.warehouseDatabaseDataSetInvoice.DataSetName = "warehouseDatabaseDataSetInvoice";
            this.warehouseDatabaseDataSetInvoice.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // invoiceBindingSource
            // 
            this.invoiceBindingSource.DataMember = "Invoice";
            this.invoiceBindingSource.DataSource = this.warehouseDatabaseDataSetInvoice;
            // 
            // invoiceTableAdapter
            // 
            this.invoiceTableAdapter.ClearBeforeFill = true;
            // 
            // mySqlDataAdapter1
            // 
            this.mySqlDataAdapter1.DeleteCommand = null;
            this.mySqlDataAdapter1.InsertCommand = null;
            this.mySqlDataAdapter1.SelectCommand = null;
            this.mySqlDataAdapter1.UpdateCommand = null;
            // 
            // FormZalogowany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1000, 667);
            this.Controls.Add(this.buttonDodajExcelDoBazy);
            this.Controls.Add(this.dataGridViewProviderInvoice);
            this.Controls.Add(this.dataGridViewInvoice);
            this.Controls.Add(this.label1);
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
            ((System.ComponentModel.ISupportInitialize)(this.providerInvoiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseDatabaseDataSetInvoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonWyloguj;
        private System.Windows.Forms.Button buttonDodajPDF;
        private System.Windows.Forms.TextBox textBoxLokalizacjaPliku;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewInvoice;
        private System.Windows.Forms.DataGridView dataGridViewProviderInvoice;
        private System.Windows.Forms.Button buttonDodajExcelDoBazy;
        public System.Windows.Forms.ComboBox comboBoxWidok;
        private warehouseDatabaseDataSet warehouseDatabaseDataSet;
        private System.Windows.Forms.BindingSource providerInvoiceBindingSource;
        private warehouseDatabaseDataSetTableAdapters.ProviderInvoiceTableAdapter providerInvoiceTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryReportNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfItemsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn deliveryStatusDataGridViewCheckBoxColumn;
        private warehouseDatabaseDataSetInvoice warehouseDatabaseDataSetInvoice;
        private System.Windows.Forms.BindingSource invoiceBindingSource;
        private warehouseDatabaseDataSetInvoiceTableAdapters.InvoiceTableAdapter invoiceTableAdapter;
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter1;
    }
}