using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Warehouse
{
    class BazaDanych
    {
        private SqlConnection connection = new SqlConnection("Data Source = MSSQLLocalDB; Initial Catalog = warehouseDatabase; Integrated Security = True; MultipleActiveResultSets=True;Application Name = EntityFramework");
        public void openConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
                connection.Open();
            }
        }
        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
        public SqlConnection getConnection()
        {
            return connection;
        }
    }
}
