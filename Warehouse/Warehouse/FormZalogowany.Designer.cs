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
            this.dataGridViewShowNew = new System.Windows.Forms.DataGridView();
            this.dataGridViewShowNotes = new System.Windows.Forms.DataGridView();
            this.deliveryReportNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberOfItemsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryStatusDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.providerInvoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.warehouseDatabaseDataSet = new Warehouse.warehouseDatabaseDataSet();
            this.providerInvoiceTableAdapter = new Warehouse.warehouseDatabaseDataSetTableAdapters.ProviderInvoiceTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.warehouseDatabaseDataSet1 = new Warehouse.warehouseDatabaseDataSet1();
            this.invoiceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.invoiceTableAdapter = new Warehouse.warehouseDatabaseDataSet1TableAdapters.invoiceTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowNotes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.providerInvoiceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseDatabaseDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonWyloguj
            // 
            this.buttonWyloguj.Location = new System.Drawing.Point(790, 462);
            this.buttonWyloguj.Name = "buttonWyloguj";
            this.buttonWyloguj.Size = new System.Drawing.Size(179, 42);
            this.buttonWyloguj.TabIndex = 1;
            this.buttonWyloguj.Text = "Wyloguj";
            this.buttonWyloguj.UseVisualStyleBackColor = true;
            this.buttonWyloguj.Click += new System.EventHandler(this.buttonWyloguj_Click);
            // 
            // buttonDodajPDF
            // 
            this.buttonDodajPDF.Location = new System.Drawing.Point(556, 332);
            this.buttonDodajPDF.Name = "buttonDodajPDF";
            this.buttonDodajPDF.Size = new System.Drawing.Size(179, 42);
            this.buttonDodajPDF.TabIndex = 2;
            this.buttonDodajPDF.Text = "Dodaj Fakture";
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
            this.comboBoxWidok.Location = new System.Drawing.Point(26, 410);
            this.comboBoxWidok.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxWidok.Name = "comboBoxWidok";
            this.comboBoxWidok.Size = new System.Drawing.Size(92, 21);
            this.comboBoxWidok.TabIndex = 4;
            this.comboBoxWidok.SelectedIndexChanged += new System.EventHandler(this.comboBoxWidok_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(164, 415);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            // 
            // dataGridViewShowNew
            // 
            this.dataGridViewShowNew.AllowUserToAddRows = false;
            this.dataGridViewShowNew.AllowUserToDeleteRows = false;
            this.dataGridViewShowNew.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShowNew.Location = new System.Drawing.Point(26, 29);
            this.dataGridViewShowNew.Name = "dataGridViewShowNew";
            this.dataGridViewShowNew.Size = new System.Drawing.Size(709, 150);
            this.dataGridViewShowNew.TabIndex = 6;
            // 
            // dataGridViewShowNotes
            // 
            this.dataGridViewShowNotes.AllowUserToAddRows = false;
            this.dataGridViewShowNotes.AllowUserToDeleteRows = false;
            this.dataGridViewShowNotes.AutoGenerateColumns = false;
            this.dataGridViewShowNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewShowNotes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.deliveryReportNoDataGridViewTextBoxColumn,
            this.deliveryDateDataGridViewTextBoxColumn,
            this.companyNameDataGridViewTextBoxColumn,
            this.numberOfItemsDataGridViewTextBoxColumn,
            this.addDateDataGridViewTextBoxColumn,
            this.deliveryStatusDataGridViewCheckBoxColumn});
            this.dataGridViewShowNotes.DataSource = this.providerInvoiceBindingSource;
            this.dataGridViewShowNotes.Location = new System.Drawing.Point(26, 551);
            this.dataGridViewShowNotes.Name = "dataGridViewShowNotes";
            this.dataGridViewShowNotes.ReadOnly = true;
            this.dataGridViewShowNotes.Size = new System.Drawing.Size(709, 150);
            this.dataGridViewShowNotes.TabIndex = 7;
            this.dataGridViewShowNotes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewShowNotes_CellClick);
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
            // providerInvoiceTableAdapter
            // 
            this.providerInvoiceTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(236, 410);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // warehouseDatabaseDataSet1
            // 
            this.warehouseDatabaseDataSet1.DataSetName = "warehouseDatabaseDataSet1";
            this.warehouseDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // invoiceBindingSource
            // 
            this.invoiceBindingSource.DataMember = "invoice";
            this.invoiceBindingSource.DataSource = this.warehouseDatabaseDataSet1;
            // 
            // invoiceTableAdapter
            // 
            this.invoiceTableAdapter.ClearBeforeFill = true;
            // 
            // FormZalogowany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1000, 667);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewShowNotes);
            this.Controls.Add(this.dataGridViewShowNew);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewShowNotes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.providerInvoiceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseDatabaseDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invoiceBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonWyloguj;
        private System.Windows.Forms.Button buttonDodajPDF;
        private System.Windows.Forms.TextBox textBoxLokalizacjaPliku;
        private System.Windows.Forms.ComboBox comboBoxWidok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewShowNew;
        private System.Windows.Forms.DataGridView dataGridViewShowNotes;
        private warehouseDatabaseDataSet warehouseDatabaseDataSet;
        private System.Windows.Forms.BindingSource providerInvoiceBindingSource;
        private warehouseDatabaseDataSetTableAdapters.ProviderInvoiceTableAdapter providerInvoiceTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryReportNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberOfItemsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn deliveryStatusDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Button button1;
        private warehouseDatabaseDataSet1 warehouseDatabaseDataSet1;
        private System.Windows.Forms.BindingSource invoiceBindingSource;
        private warehouseDatabaseDataSet1TableAdapters.invoiceTableAdapter invoiceTableAdapter;
    }
}