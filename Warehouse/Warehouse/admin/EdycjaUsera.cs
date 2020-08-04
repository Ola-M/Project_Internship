using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warehouse.admin
{
    class EdycjaUsera
    {
        private warehouseDatabaseEntities1 context = new warehouseDatabaseEntities1();
        private List<string> textBoxList;
        private Users user = new Users();
        private Permissions permissions = new Permissions();
        private UserPermissions userPermissions = new UserPermissions();
        private List<UserPermissions> userPermissionsList = new List<UserPermissions>();
        private List<CheckBox> checkBoxesList;
        DataGridView dataGridViewUsers;
        public EdycjaUsera(List<string> textBoxList, List<CheckBox> checkBoxesList, DataGridView dataGridViewUsers)
        {

            this.textBoxList = textBoxList;
            this.checkBoxesList = checkBoxesList;
            this.dataGridViewUsers = dataGridViewUsers;

        }
        public void updateUsers()
        {
            AddUser addingUser = new AddUser(textBoxList, checkBoxesList);
            string eee;
            int dd = 0;

            foreach (DataGridViewRow view in dataGridViewUsers.SelectedRows)
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

                }
                else
                {
                    MessageBox.Show("mesagge");
                }
            }
        }
    }
}
