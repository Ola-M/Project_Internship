using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Warehouse.admin;

namespace Warehouse
{
    public partial class FormAdmin : Form
    {
        warehouseDatabaseEntities1 context = new warehouseDatabaseEntities1();
        List<string> textBoxList = new List<string>();
        AddingUser addingUser;
        
        
        public FormAdmin()
        {
            InitializeComponent();
            this.addingUser = new AddingUser(textBoxList,checkedListBoxPermissions);
        }


        private void FormAdmin_Load(object sender, EventArgs e)
        {
            // TODO: Ten wiersz kodu wczytuje dane do tabeli 'warehouseDatabaseDataSet1.Users' . Możesz go przenieść lub usunąć.
            this.usersTableAdapter.Fill(this.warehouseDatabaseDataSet1.Users);

        }

        private void sss()
        {
            textBoxList.Add(textBoxName.Text);
            textBoxList.Add(textBoxForname.Text);
            textBoxList.Add(textBoxLogin.Text);
            textBoxList.Add(textBoxPassword.Text);
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            //this.addingUser.permission("admin");
            // sss();
            // this.addingUser.addingNewUser(dataGridViewUsers);
            Permissions permissions;
            UserPermissions userPermissions = new UserPermissions();
            for (int i = 0; i < checkedListBoxPermissions.Items.Count; i++)
            {
                if (checkedListBoxPermissions.GetItemChecked(i))
                {
                    var blabla = checkedListBoxPermissions.Items[i].ToString();
                    permissions = context.Permissions.FirstOrDefault(c => c.permissionName == blabla);
                    userPermissions.permissionsID = permissions.permissionID;
                    userPermissions.userID = 6;
                    context.UserPermissions.Add(userPermissions);
                    context.SaveChanges();
                }
            }
            
            

        }

        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {

        }
    }
}
