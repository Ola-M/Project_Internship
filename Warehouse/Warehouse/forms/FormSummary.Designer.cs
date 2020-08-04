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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIncompatibleProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMissingProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewIncompatibleProducts
            // 
            this.dataGridViewIncompatibleProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIncompatibleProducts.Location = new System.Drawing.Point(16, 90);
            this.dataGridViewIncompatibleProducts.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridViewIncompatibleProducts.Name = "dataGridViewIncompatibleProducts";
            this.dataGridViewIncompatibleProducts.RowHeadersWidth = 51;
            this.dataGridViewIncompatibleProducts.Size = new System.Drawing.Size(734, 185);
            this.dataGridViewIncompatibleProducts.TabIndex = 0;
            // 
            // dataGridViewMissingProducts
            // 
            this.dataGridViewMissingProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMissingProducts.Location = new System.Drawing.Point(12, 373);
            this.dataGridViewMissingProducts.Name = "dataGridViewMissingProducts";
            this.dataGridViewMissingProducts.RowHeadersWidth = 51;
            this.dataGridViewMissingProducts.RowTemplate.Height = 24;
            this.dataGridViewMissingProducts.Size = new System.Drawing.Size(738, 150);
            this.dataGridViewMissingProducts.TabIndex = 1;
            // 
            // labelIncomp
            // 
            this.labelIncomp.AutoSize = true;
            this.labelIncomp.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelIncomp.Location = new System.Drawing.Point(16, 24);
            this.labelIncomp.Name = "labelIncomp";
            this.labelIncomp.Size = new System.Drawing.Size(290, 33);
            this.labelIncomp.TabIndex = 2;
            this.labelIncomp.Text = "Produkty spoza listy:";
            // 
            // labelMissing
            // 
            this.labelMissing.AutoSize = true;
            this.labelMissing.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold);
            this.labelMissing.Location = new System.Drawing.Point(22, 315);
            this.labelMissing.Name = "labelMissing";
            this.labelMissing.Size = new System.Drawing.Size(282, 33);
            this.labelMissing.TabIndex = 3;
            this.labelMissing.Text = "Brakujące produkty:";
            // 
            // labelContact
            // 
            this.labelContact.AutoSize = true;
            this.labelContact.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold);
            this.labelContact.Location = new System.Drawing.Point(22, 609);
            this.labelContact.Name = "labelContact";
            this.labelContact.Size = new System.Drawing.Size(0, 33);
            this.labelContact.TabIndex = 4;
            // 
            // FormSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 699);
            this.Controls.Add(this.labelContact);
            this.Controls.Add(this.labelMissing);
            this.Controls.Add(this.labelIncomp);
            this.Controls.Add(this.dataGridViewMissingProducts);
            this.Controls.Add(this.dataGridViewIncompatibleProducts);
            this.Margin = new System.Windows.Forms.Padding(4);
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
    }
}