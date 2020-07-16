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
            var user1 = user;
            if (textBoxLogin.Text == "" && textBoxHaslo.Text == "")
            {
                MessageBox.Show("Podaj login i hasło!");
            }
            else
            {
                /*SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=warehouseDatabase;Integrated Security=True");
                PobieranieDanych pobieranieDanych = new PobieranieDanych();
                SqlCommand command = new SqlCommand("SELECT * FROM [user] WHERE login = @log and password = @haslo", con);
                command.Parameters.AddWithValue("@log", textBoxLogin.Text);
                command.Parameters.AddWithValue("@haslo", textBoxHaslo.Text);
                con.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                con.Close();
                var id = dt.Rows[0]["userID"].ToString();
                var permission = dt.Rows[0]["permission"].ToString();
                var xxx = permission;
                pobieranieDanych.userID = int.Parse(id);
                if(dt.Rows.Count == 1)
                {
                    MessageBox.Show("Zalogowano");
                }
                else
                {
                    MessageBox.Show("Błędny login lub hasło");
                }*/
                foreach(var userID in )
                    if (textBoxLogin.Text == userLogin.login && textBoxHaslo.Text == userLogin.password)
                    {
                        MessageBox.Show("Zalogowano");
                        
                    }
                    else
                    {
                        MessageBox.Show("error");
                    userLogin.userID++;
                    }
                }


            }
        }
}

