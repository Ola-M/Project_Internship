using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Warehouse.admin;

namespace Warehouse
{
    public partial class FormAdmin : Form
    {
        private warehouseDatabaseEntities1 context = new warehouseDatabaseEntities1();
        private List<string> textBoxList = new List<string>();
        RemoveUser removeUser;
        ClearTextBox clearTextBox;
        List<CheckBox> checkBoxesList = new List<CheckBox>();
        EditUsers editUsers;
        AddOrUpdateUsers addOrUpdateUsers ;

        public FormAdmin()
        {
            InitializeComponent();
            this.addOrUpdateUsers = new AddOrUpdateUsers(textBoxList, checkBoxesList);
            this.removeUser = new RemoveUser();
            this.editUsers = new EditUsers(textBoxList,checkBoxesList, dataGridViewUsers);
            this.clearTextBox = new ClearTextBox(textBoxName, textBoxForname, textBoxLogin, textBoxPassword, textBoxList);
        }


        private void FormAdmin_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'warehouseDatabaseDataSet1.Users' . Możesz go przenieść lub usunąć.
            this.usersTableAdapter.Fill(this.warehouseDatabaseDataSet1.Users);

        }
        private void createCheckBoxList()
        {
            checkBoxesList.Add(checkBoxWarehouseman);
            checkBoxesList.Add(checkBoxLogistician);
            checkBoxesList.Add(checkBoxAdmin);
        }



        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            textBoxList.Clear();
            checkBoxesList.Clear();
            createCheckBoxList();
            clearTextBox.addTextBoxToList();
            addOrUpdateUsers.addOrUpdate(dataGridViewUsers);
            clearTextBox.clearText();
            checkBoxesList.Clear();
            FormAdmin_Load(sender, e);

        }

        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            removeUser.delUser(dataGridViewUsers);
            clearTextBox.clearText();
            FormAdmin_Load(sender, e);

        }
        private void dataGridViewUsers_DoubleClick(object sender, EventArgs e)
        {
            createCheckBoxList();
            textBoxList = editUsers.addU();
            textBoxName.Text = textBoxList[0];
            textBoxForname.Text = textBoxList[1];
            textBoxLogin.Text = textBoxList[2];
            textBoxPassword.Text = textBoxList[3];

        }
    }
}
