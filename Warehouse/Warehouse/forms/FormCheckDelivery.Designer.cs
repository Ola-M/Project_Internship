namespace Warehouse
{
    partial class FormCheckDelivery
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
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.dataGridViewProvenProduct = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxAddSerial = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonFinishChecking = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonSummary = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProvenProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.AllowUserToAddRows = false;
            this.dataGridViewProducts.AllowUserToDeleteRows = false;
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.Location = new System.Drawing.Point(107, 47);
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.ReadOnly = true;
            this.dataGridViewProducts.Size = new System.Drawing.Size(501, 477);
            this.dataGridViewProducts.TabIndex = 0;
            // 
            // dataGridViewProvenProduct
            // 
            this.dataGridViewProvenProduct.AllowUserToAddRows = false;
            this.dataGridViewProvenProduct.AllowUserToDeleteRows = false;
            this.dataGridViewProvenProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProvenProduct.Location = new System.Drawing.Point(749, 47);
            this.dataGridViewProvenProduct.MultiSelect = false;
            this.dataGridViewProvenProduct.Name = "dataGridViewProvenProduct";
            this.dataGridViewProvenProduct.ReadOnly = true;
            this.dataGridViewProvenProduct.ShowCellErrors = false;
            this.dataGridViewProvenProduct.ShowRowErrors = false;
            this.dataGridViewProvenProduct.Size = new System.Drawing.Size(521, 477);
            this.dataGridViewProvenProduct.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(991, 530);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 21);
            this.button1.TabIndex = 2;
            this.button1.Text = "Dodaj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(892, 557);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(106, 56);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Zapisz dostawę";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Visible = false;
            this.buttonSave.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBoxAddSerial
            // 
            this.textBoxAddSerial.Location = new System.Drawing.Point(758, 531);
            this.textBoxAddSerial.Name = "textBoxAddSerial";
            this.textBoxAddSerial.Size = new System.Drawing.Size(227, 20);
            this.textBoxAddSerial.TabIndex = 4;
            this.textBoxAddSerial.TextChanged += new System.EventHandler(this.textBoxAddSerial_TextChanged);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(1004, 557);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(101, 56);
            this.buttonDelete.TabIndex = 5;
            this.buttonDelete.Text = "Usuń";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Visible = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonFinishChecking
            // 
            this.buttonFinishChecking.Location = new System.Drawing.Point(758, 557);
            this.buttonFinishChecking.Name = "buttonFinishChecking";
            this.buttonFinishChecking.Size = new System.Drawing.Size(128, 55);
            this.buttonFinishChecking.TabIndex = 6;
            this.buttonFinishChecking.Text = "Zakończ sprawdzanie";
            this.buttonFinishChecking.UseVisualStyleBackColor = true;
            this.buttonFinishChecking.Visible = false;
            this.buttonFinishChecking.Click += new System.EventHandler(this.buttonFinishChecking_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(1130, 557);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(87, 55);
            this.buttonBack.TabIndex = 7;
            this.buttonBack.Text = "Powrót";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonSummary
            // 
            this.buttonSummary.Location = new System.Drawing.Point(655, 558);
            this.buttonSummary.Name = "buttonSummary";
            this.buttonSummary.Size = new System.Drawing.Size(97, 55);
            this.buttonSummary.TabIndex = 8;
            this.buttonSummary.Text = "Podsumuj";
            this.buttonSummary.UseVisualStyleBackColor = true;
            this.buttonSummary.Visible = false;
            this.buttonSummary.Click += new System.EventHandler(this.buttonSummary_Click);
            // 
            // FormCheckDelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1417, 641);
            this.Controls.Add(this.buttonSummary);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonFinishChecking);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.textBoxAddSerial);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridViewProvenProduct);
            this.Controls.Add(this.dataGridViewProducts);
            this.Name = "FormCheckDelivery";
            this.Text = "FormCheckDelivery";
            this.Load += new System.EventHandler(this.FormCheckDelivery_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProvenProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private System.Windows.Forms.DataGridView dataGridViewProvenProduct;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxAddSerial;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonFinishChecking;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonSummary;
    }
}