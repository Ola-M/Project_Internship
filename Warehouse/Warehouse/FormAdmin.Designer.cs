namespace Warehouse
{
    partial class FormAdmin
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
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.textBoxForname = new System.Windows.Forms.TextBox();
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.usersIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fornameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.loginDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.warehouseDatabaseDataSet1 = new Warehouse.warehouseDatabaseDataSet1();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.checkBoxWarehouseman = new System.Windows.Forms.CheckBox();
            this.checkBoxLogistician = new System.Windows.Forms.CheckBox();
            this.checkBoxAdmin = new System.Windows.Forms.CheckBox();
            this.usersTableAdapter = new Warehouse.warehouseDatabaseDataSet1TableAdapters.UsersTableAdapter();
            this.buttonDeleteUser = new System.Windows.Forms.Button();
            this.checkedListBoxPermissions = new System.Windows.Forms.CheckedListBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseDatabaseDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(545, 25);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(191, 20);
            this.textBoxName.TabIndex = 0;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(545, 201);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(191, 20);
            this.textBoxPassword.TabIndex = 1;
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(545, 132);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(191, 20);
            this.textBoxLogin.TabIndex = 2;
            // 
            // textBoxForname
            // 
            this.textBoxForname.Location = new System.Drawing.Point(545, 76);
            this.textBoxForname.Name = "textBoxForname";
            this.textBoxForname.Size = new System.Drawing.Size(191, 20);
            this.textBoxForname.TabIndex = 3;
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.AllowUserToAddRows = false;
            this.dataGridViewUsers.AllowUserToDeleteRows = false;
            this.dataGridViewUsers.AutoGenerateColumns = false;
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usersIDDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.fornameDataGridViewTextBoxColumn,
            this.loginDataGridViewTextBoxColumn});
            this.dataGridViewUsers.DataSource = this.usersBindingSource;
            this.dataGridViewUsers.Location = new System.Drawing.Point(2, 12);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.ReadOnly = true;
            this.dataGridViewUsers.Size = new System.Drawing.Size(344, 357);
            this.dataGridViewUsers.TabIndex = 4;
            // 
            // usersIDDataGridViewTextBoxColumn
            // 
            this.usersIDDataGridViewTextBoxColumn.DataPropertyName = "usersID";
            this.usersIDDataGridViewTextBoxColumn.HeaderText = "usersID";
            this.usersIDDataGridViewTextBoxColumn.Name = "usersIDDataGridViewTextBoxColumn";
            this.usersIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.usersIDDataGridViewTextBoxColumn.Visible = false;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Imie";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fornameDataGridViewTextBoxColumn
            // 
            this.fornameDataGridViewTextBoxColumn.DataPropertyName = "forname";
            this.fornameDataGridViewTextBoxColumn.HeaderText = "Nazwisko";
            this.fornameDataGridViewTextBoxColumn.Name = "fornameDataGridViewTextBoxColumn";
            this.fornameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // loginDataGridViewTextBoxColumn
            // 
            this.loginDataGridViewTextBoxColumn.DataPropertyName = "login";
            this.loginDataGridViewTextBoxColumn.HeaderText = "Login";
            this.loginDataGridViewTextBoxColumn.Name = "loginDataGridViewTextBoxColumn";
            this.loginDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.warehouseDatabaseDataSet1;
            // 
            // warehouseDatabaseDataSet1
            // 
            this.warehouseDatabaseDataSet1.DataSetName = "warehouseDatabaseDataSet1";
            this.warehouseDatabaseDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.Location = new System.Drawing.Point(603, 278);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(100, 69);
            this.buttonAddUser.TabIndex = 5;
            this.buttonAddUser.Text = "Dodaj";
            this.buttonAddUser.UseVisualStyleBackColor = true;
            this.buttonAddUser.Click += new System.EventHandler(this.buttonAddUser_Click);
            // 
            // checkBoxWarehouseman
            // 
            this.checkBoxWarehouseman.AutoSize = true;
            this.checkBoxWarehouseman.Location = new System.Drawing.Point(379, 28);
            this.checkBoxWarehouseman.Name = "checkBoxWarehouseman";
            this.checkBoxWarehouseman.Size = new System.Drawing.Size(80, 17);
            this.checkBoxWarehouseman.TabIndex = 9;
            this.checkBoxWarehouseman.Text = "Magazynier";
            this.checkBoxWarehouseman.UseVisualStyleBackColor = true;
            // 
            // checkBoxLogistician
            // 
            this.checkBoxLogistician.AutoSize = true;
            this.checkBoxLogistician.Location = new System.Drawing.Point(379, 76);
            this.checkBoxLogistician.Name = "checkBoxLogistician";
            this.checkBoxLogistician.Size = new System.Drawing.Size(65, 17);
            this.checkBoxLogistician.TabIndex = 10;
            this.checkBoxLogistician.Text = "Logistyk";
            this.checkBoxLogistician.UseVisualStyleBackColor = true;
            // 
            // checkBoxAdmin
            // 
            this.checkBoxAdmin.AutoSize = true;
            this.checkBoxAdmin.Location = new System.Drawing.Point(379, 132);
            this.checkBoxAdmin.Name = "checkBoxAdmin";
            this.checkBoxAdmin.Size = new System.Drawing.Size(86, 17);
            this.checkBoxAdmin.TabIndex = 11;
            this.checkBoxAdmin.Text = "Administrator";
            this.checkBoxAdmin.UseVisualStyleBackColor = true;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // buttonDeleteUser
            // 
            this.buttonDeleteUser.Location = new System.Drawing.Point(404, 278);
            this.buttonDeleteUser.Name = "buttonDeleteUser";
            this.buttonDeleteUser.Size = new System.Drawing.Size(100, 69);
            this.buttonDeleteUser.TabIndex = 12;
            this.buttonDeleteUser.Text = "Usuń";
            this.buttonDeleteUser.UseVisualStyleBackColor = true;
            this.buttonDeleteUser.Click += new System.EventHandler(this.buttonDeleteUser_Click);
            // 
            // checkedListBoxPermissions
            // 
            this.checkedListBoxPermissions.FormattingEnabled = true;
            this.checkedListBoxPermissions.Items.AddRange(new object[] {
            "Magazynier",
            "Logistyk",
            "Administrator"});
            this.checkedListBoxPermissions.Location = new System.Drawing.Point(379, 155);
            this.checkedListBoxPermissions.Name = "checkedListBoxPermissions";
            this.checkedListBoxPermissions.Size = new System.Drawing.Size(120, 49);
            this.checkedListBoxPermissions.TabIndex = 13;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkedListBoxPermissions);
            this.Controls.Add(this.buttonDeleteUser);
            this.Controls.Add(this.checkBoxAdmin);
            this.Controls.Add(this.checkBoxLogistician);
            this.Controls.Add(this.checkBoxWarehouseman);
            this.Controls.Add(this.buttonAddUser);
            this.Controls.Add(this.dataGridViewUsers);
            this.Controls.Add(this.textBoxForname);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.textBoxName);
            this.Name = "FormAdmin";
            this.Text = "FormAdmin";
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.warehouseDatabaseDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.TextBox textBoxForname;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.CheckBox checkBoxWarehouseman;
        private System.Windows.Forms.CheckBox checkBoxLogistician;
        private System.Windows.Forms.CheckBox checkBoxAdmin;
        private warehouseDatabaseDataSet1 warehouseDatabaseDataSet1;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private warehouseDatabaseDataSet1TableAdapters.UsersTableAdapter usersTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn usersIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fornameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn loginDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button buttonDeleteUser;
        private System.Windows.Forms.CheckedListBox checkedListBoxPermissions;
    }
}