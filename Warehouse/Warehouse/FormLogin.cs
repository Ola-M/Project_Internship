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
using Warehouse.bazaDanych;

namespace Warehouse
{
    public partial class FormLogin : Form
    {
        //string connection = (@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=warehouseDatabase;Integrated Security=True");

        public FormLogin()
        {
            InitializeComponent();
        }
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            warehouseDatabaseEntities context = new warehouseDatabaseEntities();

            if (textBoxLogin.Text != string.Empty || textBoxHaslo.Text != string.Empty)
            {
                var user = context.users.Where(u => u.login.Equals(textBoxLogin.Text)).FirstOrDefault();
                if (user != null)
                {
                    if (user.password.Equals(textBoxHaslo.Text))
                    {
                        MessageBox.Show("yey");
                        int xxx = user.permission;
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
    }
}

