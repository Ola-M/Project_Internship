using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warehouse.admin
{
    class AddOrUpdateUsers
    {
        private warehouseDatabaseEntities1 context = new warehouseDatabaseEntities1();
        private List<CheckBox> checkBoxesList;
        private List<string> textBoxList;
        private Users users = new Users();
        
        public AddOrUpdateUsers(List<string> textBoxList, List<CheckBox> checkBoxesList)
        {
            this.textBoxList = textBoxList;
            this.checkBoxesList = checkBoxesList;
        }
        public void addOrUpdate( DataGridView dataGridViewUsers)
        {
            EditUsers editUsers = new EditUsers(textBoxList, checkBoxesList, dataGridViewUsers);
            AddUser addUser = new AddUser(textBoxList, checkBoxesList);
            AddPermissions addPermissions = new AddPermissions(checkBoxesList);
            string getLogin = textBoxList[2];
            users = context.Users.FirstOrDefault(c => c.login == getLogin);
            if (users == null)
            {
                addUser.addNewUser();
                users = context.Users.FirstOrDefault(c => c.login == getLogin);
                if (users != null)
                {
                    addPermissions.permission(users.usersID);
                    MessageBox.Show("Dodano użytkownika");
                }
                    
                
                // return users.usersID;
            }
            else
            {
                const string message =
                    "Taki użytkownik juz istnieje. Czy chcesz go edytować?";
                const string caption = "Edycja";
                var result = MessageBox.Show(message, caption,
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    editUsers.updateUsers();
                    addPermissions.permission(users.usersID);
                    MessageBox.Show("Edytowano użytkownika");
                }
                    
                
                // return users.usersID;
            }

        }
    }
}
