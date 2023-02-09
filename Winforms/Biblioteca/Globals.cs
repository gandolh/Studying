using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Biblioteca
{
    class Globals
    {
        public static string connectionString= @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\gusat\Desktop\projects\csprojects\Biblioteca\Biblioteca.mdf;Integrated Security=True";
        public static SqlConnection con = new SqlConnection(connectionString);
    }
}
