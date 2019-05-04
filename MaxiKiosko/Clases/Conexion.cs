using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Data.OleDb;

namespace MaxiKiosko
{
    class Conexion
    {
        MySqlCommand cmd = new MySqlCommand();
        MySqlConnection conexion = new MySqlConnection("server=localhost;user id=root;database=maxiKiosco;allowuservariables=True; password=damian;");
        

        public void conectar()
        {
            conexion.Open();
            cmd.Connection = conexion;
            cmd.CommandType = CommandType.Text;
        }

        public void cerrar()
        {
            conexion.Close();
        }

        public DataTable consulta(string comando) {
            conectar();
            cmd.CommandText = comando;
            DataTable tabla = new DataTable();
            tabla.Load(cmd.ExecuteReader());
            cerrar();
            return tabla;
        }
        
        public void grabar_modificar(string comando){
            conectar();
            cmd.CommandText = comando;
            cmd.ExecuteNonQuery();
            cerrar();
        }
    }
}
