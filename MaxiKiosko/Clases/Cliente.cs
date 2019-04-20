using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace MaxiKiosko
{
    class Cliente
    {

        public int id_usuario { get; set; }
        public string apellido { get; set; }
        public string nombre { get; set; }
        public string telefono { get; set; }
        public string email { get; set; }

        public Cliente (string papellido, string pnombre, string ptelefono, string pemail )
        {
            this.apellido = papellido;
            this.nombre = pnombre;
            this.telefono = ptelefono;
            this.email = pemail;
        }

        public int agregarCliente( Conexion nueva_conexion )
        {
            int retorno = 0;
            MySqlCommand comando = new MySqlCommand( String.Format( "INSERT INTO cliente (apellido, nombre, telefono, email) VALUES ('{0}', '{1}', '{2}', '{3}')", apellido, nombre, telefono, email), nueva_conexion.conexion);
            retorno = comando.ExecuteNonQuery();
            return retorno;
        }
    }
}
