using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Warehouse.admin
{
    class EditUser
    {
        private warehouseDatabaseEntities1 context = new warehouseDatabaseEntities1();
        private List<string> textBoxList;
        private Users user = new Users();
        private List<CheckBox> checkBoxesList;
        DataGridView dataGridViewUsers;
        public EditUser(List<string> textBoxList, List<CheckBox> checkBoxesList, DataGridView dataGridViewUsers)
        {

            this.textBoxList = textBoxList;
            this.checkBoxesList = checkBoxesList;
            this.dataGridViewUsers = dataGridViewUsers;

        }
        public void updateUsers()
        {
            AddUser addingUser = new AddUser(textBoxList, checkBoxesList);
            string getUserID;
            int userID = 0;

            foreach (DataGridViewRow view in dataGridViewUsers.SelectedRows)
            {
                getUserID = view.Cells[0].Value.ToString();
                userID = int.Parse(getUserID);

                user = context.Users.FirstOrDefault(c => c.usersID == userID);
                if (user != null)
                {
                    user.name = textBoxList[0].ToString();
                    user.forname = textBoxList[1].ToString();
                    user.login = textBoxList[2].ToString();
                    user.password = textBoxList[3].ToString();
                    context.SaveChanges();

                }
                else
                {
                    MessageBox.Show("mesagge");
                }
            }
        }
    }
}
