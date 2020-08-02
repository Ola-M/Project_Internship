using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Warehouse.admin
{
    class RemoveUser
    {
        warehouseDatabaseEntities1 context = new warehouseDatabaseEntities1();
        Users users ;
        List<UserPermissions> userPermissionsList = new List<UserPermissions>();
        public void delUser(DataGridView dataGridViewUser)
        {
            userPermissionsList = context.UserPermissions.ToList();
            try
            {
                String deleteUserLogin;
                foreach (DataGridViewRow item in dataGridViewUser.SelectedRows)
            {
                if (item.Cells[1].Value != null)
                {

                        deleteUserLogin = item.Cells[3].Value.ToString();
                        users = context.Users.First(c => c.login == deleteUserLogin);
                        int www = users.usersID;
                        
                        foreach (UserPermissions u in userPermissionsList)
                        {

                            var xxx = context.UserPermissions.FirstOrDefault(c => c.userID == www);
                            
                            if (xxx != null)
                            {
                                context.UserPermissions.Remove(xxx);
                                context.SaveChanges();
                            }

                        }

                        context.Users.Remove(users);
                 context.SaveChanges();
                    }
                    
             }

             }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
