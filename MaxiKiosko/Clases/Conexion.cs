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
        OleDbConnection conexion = new OleDbConnection();
        OleDbCommand cmd = new OleDbCommand();
        string cadena_conexion = "Server = localhost; Port = 3306; Database = maxikiosko; Uid = username; Pwd = password;"
        public MySqlConnection conexion { get; set; }

        public void abrirConexion()
        {
            conexion.ConnectionString = cadena_conexion;
            conexion.Open();
            cmd.Connection = conexion;
            cmd.CommandType = CommandType.Text;
        }

        public void cerrarConexion()
        {
            conexion.Close();
        }

        public DataTable consulta(string comando) {
            conectar();
            cmd.CommandText = comando;
            DataTable tabla = new DataTable();
            tabla.load(cmd.ExecuterReader());
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
