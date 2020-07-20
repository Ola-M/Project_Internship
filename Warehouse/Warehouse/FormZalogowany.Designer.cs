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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonWyloguj = new System.Windows.Forms.Button();
            this.buttonDodajPDF = new System.Windows.Forms.Button();
            this.textBoxLokalizacjaPliku = new System.Windows.Forms.TextBox();
            this.comboBoxWidok = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSendToDatabase = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(10, 11);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(980, 291);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // buttonWyloguj
            // 
            this.buttonWyloguj.Location = new System.Drawing.Point(769, 453);
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
            this.textBoxLokalizacjaPliku.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxLokalizacjaPliku.Name = "textBoxLokalizacjaPliku";
            this.textBoxLokalizacjaPliku.ReadOnly = true;
            this.textBoxLokalizacjaPliku.Size = new System.Drawing.Size(511, 20);
            this.textBoxLokalizacjaPliku.TabIndex = 3;
            // 
            // comboBoxWidok
            // 
            this.comboBoxWidok.FormattingEnabled = true;
            this.comboBoxWidok.Location = new System.Drawing.Point(26, 410);
            this.comboBoxWidok.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
            // buttonSendToDatabase
            // 
            this.buttonSendToDatabase.Location = new System.Drawing.Point(237, 410);
            this.buttonSendToDatabase.Name = "buttonSendToDatabase";
            this.buttonSendToDatabase.Size = new System.Drawing.Size(75, 23);
            this.buttonSendToDatabase.TabIndex = 7;
            this.buttonSendToDatabase.Text = "button1";
            this.buttonSendToDatabase.UseVisualStyleBackColor = true;
            this.buttonSendToDatabase.Click += new System.EventHandler(this.buttonSendToDatabase_Click);
            // 
            // FormZalogowany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1000, 748);
            this.Controls.Add(this.buttonSendToDatabase);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxWidok);
            this.Controls.Add(this.textBoxLokalizacjaPliku);
            this.Controls.Add(this.buttonDodajPDF);
            this.Controls.Add(this.buttonWyloguj);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormZalogowany";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormZalogowany_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buttonWyloguj;
        private System.Windows.Forms.Button buttonDodajPDF;
        private System.Windows.Forms.TextBox textBoxLokalizacjaPliku;
        private System.Windows.Forms.ComboBox comboBoxWidok;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSendToDatabase;
    }
}