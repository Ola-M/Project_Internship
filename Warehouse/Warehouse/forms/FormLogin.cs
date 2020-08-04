using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Warehouse.deliveryCheck;

namespace Warehouse
{
    public partial class FormLogin : Form
    {
        int id = 0;
        public FormLogin()
        {
            InitializeComponent();
        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            
            warehouseDatabaseEntities1 context = new warehouseDatabaseEntities1();
            if (textBoxLogin.Text != string.Empty || textBoxHaslo.Text != string.Empty)
            {
                var user = context.Users.Where(u => u.login.Equals(textBoxLogin.Text)).FirstOrDefault();

                if (user != null)
                {
                    CheckPermissions checkPermissions = new CheckPermissions(user.usersID);
                    
                    if (user.password.Equals(textBoxHaslo.Text))
                    {
                        this.id = user.usersID;
                        if (!checkPermissions.administrator())
                        {
                            
                            FormZalogowany success = new FormZalogowany(this.id);
                            success.Show();
                            this.Hide();
                        }
                        else
                        {
                            FormAdmin admin = new FormAdmin();
                            admin.Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Błędny login lub hasło");
                    }
                }
                else
                {
                    MessageBox.Show("Błędny login lub hasło");
                }
            }
            else
            {
                MessageBox.Show("Uzupełnij login i hasło");
            }
        }



        private void textBoxHaslo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                buttonLogin.PerformClick();
            }
        }

    }
}

