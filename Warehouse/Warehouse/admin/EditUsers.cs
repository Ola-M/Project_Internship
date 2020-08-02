using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Warehouse.admin
{
    class EditUsers
    {
        private warehouseDatabaseEntities1 context = new warehouseDatabaseEntities1();
        private List<string> textBoxList ;
        private Users user = new Users();
        private Permissions permissions = new Permissions();
        private UserPermissions userPermissions = new UserPermissions();
        private List<UserPermissions> userPermissionsList = new List<UserPermissions>();
        private List<CheckBox> checkBoxesList;
        DataGridView dataGridViewUsers;
        public EditUsers(List<string> textBoxList,List<CheckBox> checkBoxesList, DataGridView dataGridViewUsers)
        {
            
            this.textBoxList = textBoxList;
            this.checkBoxesList = checkBoxesList;
            this.dataGridViewUsers = dataGridViewUsers;

        }

        public void updateUsers()
        {
            AddUser addingUser = new AddUser(textBoxList,checkBoxesList);
            string eee;
            int dd = 0;
            
            foreach(DataGridViewRow view in dataGridViewUsers.SelectedRows)
            {
                eee = view.Cells[0].Value.ToString();
                dd = int.Parse(eee);

                user = context.Users.FirstOrDefault(c => c.usersID == dd);
                    if (user != null)
                  {
                    user.name = textBoxList[0].ToString();
                    user.forname = textBoxList[1].ToString();
                    user.login = textBoxList[2].ToString();
                    user.password = textBoxList[3].ToString();
                    context.SaveChanges();
                    
                    //addingUser.permission(user.usersID);
                }
                else
                {
                    MessageBox.Show("mesagge");
                }
            }
        }





        public List<string> addU()
        {
            
            try
            {
                userPermissionsList = context.UserPermissions.ToList();
                string ppp;
                int zzz = 0;
                foreach (DataGridViewRow view in dataGridViewUsers.SelectedRows)
                {
                    ppp = view.Cells[0].Value.ToString();
                    zzz = int.Parse(view.Cells[0].Value.ToString());
                    user = context.Users.FirstOrDefault(c => c.usersID == zzz);
                    textBoxList.Add(user.name.ToString());
                    textBoxList.Add(user.forname.ToString());
                    textBoxList.Add(user.login.ToString());
                    textBoxList.Add(user.password.ToString());
                    context.SaveChanges();

                    foreach (UserPermissions userPermissions in userPermissionsList)
                    {
                        var xxx = context.UserPermissions.FirstOrDefault(c => c.userID == user.usersID);
                        if (xxx != null)
                        {
                            permissions = context.Permissions.FirstOrDefault(c => c.permissionID == xxx.permissionsID);

                            for (int i = 0; i < checkBoxesList.Count; i++)
                            {
                                if ((checkBoxesList[i].Text == permissions.permissionName.ToString()))
                                {
                                    checkBoxesList[i].Checked = checked(true);
                                    context.UserPermissions.Remove(xxx);
                                    context.SaveChanges();

                                }
                            }
                        }

                    }

                }
                
            }
            catch(System.InvalidOperationException e)
            {

            }

            return textBoxList;
        }
    }
}
