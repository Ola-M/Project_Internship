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
            this.button2 = new System.Windows.Forms.Button();
            this.textBoxAddSerial = new System.Windows.Forms.TextBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(892, 557);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 56);
            this.button2.TabIndex = 3;
            this.button2.Text = "Zapisz dostawę";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(758, 557);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(128, 55);
            this.button4.TabIndex = 6;
            this.button4.Text = "Zakończ sprawdzanie";
            this.button4.UseVisualStyleBackColor = true;
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
            // FormCheckDelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1417, 641);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.textBoxAddSerial);
            this.Controls.Add(this.button2);
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
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBoxAddSerial;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button buttonBack;
    }
}