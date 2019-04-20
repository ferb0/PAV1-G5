using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MaxiKiosko
{
    class Conexion
    {
        public MySqlConnection conexion { get; set; }

        public Conexion()
        {
            conexion = new MySqlConnection("Server = localhost; Port = 3306; Database = mxikiosko; Uid = root; Pwd = PasswordMySQL;");
        }

        public void abrirConexion()
        {
            conexion.Open();
        }

        public void cerrarConexion()
        {
            conexion.Close();
        }
        
    }
}
