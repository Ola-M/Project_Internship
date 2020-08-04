using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Warehouse.admin
{
    class AddUser
    {
        private warehouseDatabaseEntities1 context = new warehouseDatabaseEntities1();
        private List<string> textBoxList;
        private Users users = new Users();
        private List<CheckBox> checkBoxesList;
        public AddUser(List<string> textBoxList, List<CheckBox> checkBoxesList)
        {
            this.textBoxList = textBoxList;
            this.checkBoxesList = checkBoxesList;
        }
        public void addNewUser()
        {
            if((textBoxFilled()== true) && ( checkBoxFilled()== true))
            {
                usersAdd();
            }
            else
            {
                MessageBox.Show("Wszystkie Pola muszą być uzupełnione i wybrane uprawnienia");
            }
        }

        private void usersAdd()
        {

                users.name = textBoxList[0].ToString();
                users.forname = textBoxList[1].ToString();
                users.login = textBoxList[2].ToString();
                users.password = textBoxList[3].ToString();

                context.Users.Add(users);
                context.SaveChanges();

        }

        private bool checkBoxFilled()    
        {
            int permissionFilled = 0;
            for (int i = 0; i < checkBoxesList.Count; i++)
            {
                if (checkBoxesList[i].Checked == true)
                {
                    permissionFilled++ ;
                }

            }
            if (permissionFilled > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool textBoxFilled()
        {
            if(textBoxList.Count == 4)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

  
    }
}
