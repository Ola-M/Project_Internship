using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Warehouse.admin
{
    class GetUser
    {
        private warehouseDatabaseEntities1 context = new warehouseDatabaseEntities1();
        private List<string> textBoxList ;
        private Users user = new Users();
        private Permissions permissions = new Permissions();
        private UserPermissions userPermissions = new UserPermissions();
        private List<UserPermissions> userPermissionsList = new List<UserPermissions>();
        private List<CheckBox> checkBoxesList;
        DataGridView dataGridViewUsers;
        private AddPermissions addPermissions;
        public GetUser(List<string> textBoxList,List<CheckBox> checkBoxesList, DataGridView dataGridViewUsers)
        {
            
            this.textBoxList = textBoxList;
            this.checkBoxesList = checkBoxesList;
            this.dataGridViewUsers = dataGridViewUsers;
            this.addPermissions = new AddPermissions(checkBoxesList);
        }



        public List<CheckBox> getPermissions()
        {
            try
            {

                userPermissionsList = context.UserPermissions.ToList();
                foreach (DataGridViewRow view in dataGridViewUsers.SelectedRows)
                {

                    foreach (UserPermissions userPermissions in userPermissionsList)
                    {
                        var userPermissionsExist = context.UserPermissions.FirstOrDefault(c => c.userID == user.usersID);
                        if (userPermissionsExist != null)
                        {
                            permissions = context.Permissions.FirstOrDefault(c => c.permissionID == userPermissionsExist.permissionsID);

                            for (int i = 0; i < checkBoxesList.Count; i++)
                            {
                                if ((checkBoxesList[i].Text == permissions.permissionName.ToString()))
                                {
                                    checkBoxesList[i].Checked = checked(true);
                                    context.UserPermissions.Remove(userPermissionsExist);
                                    context.SaveChanges();

                                }
                            }
                        }

                    }
                }
            }
            catch (System.InvalidOperationException e)
            {

            }
            addPermissions.permission(user.usersID);
            return checkBoxesList;
        }



        public List<string> getUser()
        {
            
            try
            {
                int getUserID = 0;
                foreach (DataGridViewRow view in dataGridViewUsers.SelectedRows)
                {
                    getUserID = int.Parse(view.Cells[0].Value.ToString());
                    user = context.Users.FirstOrDefault(c => c.usersID == getUserID);
                    textBoxList.Add(user.name.ToString());
                    textBoxList.Add(user.forname.ToString());
                    textBoxList.Add(user.login.ToString());
                    textBoxList.Add(user.password.ToString());
                    context.SaveChanges();

                   

                }
                
            }
            catch(System.InvalidOperationException e)
            {

            }

            return textBoxList;
        }
    }
}
