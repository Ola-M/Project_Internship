using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warehouse.admin
{
    class AddingUser
    {
        warehouseDatabaseEntities1 context = new warehouseDatabaseEntities1();
        List<string> textBoxList;
        Users users = new Users();
        UserPermissions userPermissions = new UserPermissions();
        CheckedListBox checkedListBoxPermissions;
        public AddingUser(List<string> textBoxList,CheckedListBox checkedListBoxPermissions)
        {
            this.textBoxList = textBoxList;
            this.checkedListBoxPermissions = checkedListBoxPermissions;
        }
        public void addingNewUser(DataGridView dataGridViewUsers)
        {
            string eee = textBoxList[2];
            var abecadlo = context.Users.FirstOrDefault(c => c.login == eee);
           


            if (abecadlo == null)
            {
                users.name = textBoxList[0];
                users.forname = textBoxList[1];
                users.login = textBoxList[2];
                users.password = textBoxList[3];

                context.Users.Add(users);
                context.SaveChanges();
                
                
            }
          

        }

        public void permission(string eee)
        {
            var id = context.Users.FirstOrDefault(c => c.login == eee);
            userPermissions.userID = id.usersID;
            var sss = checkedListBoxPermissions.CheckedIndices;
            var w = sss;
           /* if ()
            {
                var x = 1;
            }

            if (checkedListBoxPermissions.SelectedItem.Equals("Magazynier") == true)
            {
                var x = 1;
            }*/


            userPermissions.permissionsID = 1;
            context.UserPermissions.Add(userPermissions);
            context.SaveChanges();
            userPermissions.permissionsID = 2;
            context.UserPermissions.Add(userPermissions);
            context.SaveChanges();
            userPermissions.permissionsID = 3;
            context.UserPermissions.Add(userPermissions);
            context.SaveChanges();

        }

        private void addingToDB()
        {
            
        }

        

    }
}
