namespace Warehouse.forms
{
    partial class FormSummary
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
            this.dataGridViewIncompatibleProducts = new System.Windows.Forms.DataGridView();
            this.dataGridViewMissingProducts = new System.Windows.Forms.DataGridView();
            this.labelIncomp = new System.Windows.Forms.Label();
            this.labelMissing = new System.Windows.Forms.Label();
            this.labelContact = new System.Windows.Forms.Label();
            this.buttonBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIncompatibleProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMissingProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewIncompatibleProducts
            // 
            this.dataGridViewIncompatibleProducts.AllowUserToAddRows = false;
            this.dataGridViewIncompatibleProducts.AllowUserToDeleteRows = false;
            this.dataGridViewIncompatibleProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIncompatibleProducts.Location = new System.Drawing.Point(12, 73);
            this.dataGridViewIncompatibleProducts.Name = "dataGridViewIncompatibleProducts";
            this.dataGridViewIncompatibleProducts.ReadOnly = true;
            this.dataGridViewIncompatibleProducts.RowHeadersWidth = 51;
            this.dataGridViewIncompatibleProducts.Size = new System.Drawing.Size(453, 150);
            this.dataGridViewIncompatibleProducts.TabIndex = 0;
            // 
            // dataGridViewMissingProducts
            // 
            this.dataGridViewMissingProducts.AllowUserToAddRows = false;
            this.dataGridViewMissingProducts.AllowUserToDeleteRows = false;
            this.dataGridViewMissingProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMissingProducts.Location = new System.Drawing.Point(9, 303);
            this.dataGridViewMissingProducts.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridViewMissingProducts.Name = "dataGridViewMissingProducts";
            this.dataGridViewMissingProducts.ReadOnly = true;
            this.dataGridViewMissingProducts.RowHeadersWidth = 51;
            this.dataGridViewMissingProducts.RowTemplate.Height = 24;
            this.dataGridViewMissingProducts.Size = new System.Drawing.Size(554, 122);
            this.dataGridViewMissingProducts.TabIndex = 1;
            // 
            // labelIncomp
            // 
            this.labelIncomp.AutoSize = true;
            this.labelIncomp.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelIncomp.Location = new System.Drawing.Point(12, 20);
            this.labelIncomp.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelIncomp.Name = "labelIncomp";
            this.labelIncomp.Size = new System.Drawing.Size(230, 27);
            this.labelIncomp.TabIndex = 2;
            this.labelIncomp.Text = "Produkty spoza listy:";
            // 
            // labelMissing
            // 
            this.labelMissing.AutoSize = true;
            this.labelMissing.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold);
            this.labelMissing.Location = new System.Drawing.Point(16, 256);
            this.labelMissing.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelMissing.Name = "labelMissing";
            this.labelMissing.Size = new System.Drawing.Size(224, 27);
            this.labelMissing.TabIndex = 3;
            this.labelMissing.Text = "Brakujące produkty:";
            // 
            // labelContact
            // 
            this.labelContact.AutoSize = true;
            this.labelContact.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold);
            this.labelContact.Location = new System.Drawing.Point(16, 495);
            this.labelContact.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelContact.Name = "labelContact";
            this.labelContact.Size = new System.Drawing.Size(0, 27);
            this.labelContact.TabIndex = 4;
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold);
            this.buttonBack.Location = new System.Drawing.Point(472, 73);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(91, 149);
            this.buttonBack.TabIndex = 5;
            this.buttonBack.Text = "Powrót";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // FormSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 568);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.labelContact);
            this.Controls.Add(this.labelMissing);
            this.Controls.Add(this.labelIncomp);
            this.Controls.Add(this.dataGridViewMissingProducts);
            this.Controls.Add(this.dataGridViewIncompatibleProducts);
            this.Name = "FormSummary";
            this.Text = "FormSummary";
            this.Load += new System.EventHandler(this.FormSummary_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIncompatibleProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMissingProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewIncompatibleProducts;
        private System.Windows.Forms.DataGridView dataGridViewMissingProducts;
        private System.Windows.Forms.Label labelIncomp;
        private System.Windows.Forms.Label labelMissing;
        private System.Windows.Forms.Label labelContact;
        private System.Windows.Forms.Button buttonBack;
    }
}