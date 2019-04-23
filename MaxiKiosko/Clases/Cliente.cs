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
        Conexion _BD = new Conexion();

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

        public int agregarCliente( Cliente cliente )
        {
            string SqlInsert = "";
            SqlInsert = @" INSERT INTO cliente
                         (apellido, nombre, telefono, email) VALUES ('" +
                            this.apellido + "', '" +
                            this.nombre + "', '" +
                            this.telefono + "', '" +
                            this.email +
                             "')";
            MesssageBox.Show(SqlInsert);
            this.conexion.grabar_modificar(SqlInsert);
        }

        public DataTable consultarCliente(string nombreOApellido) {
            return this.conexion.consulta(String.Format ("SELECT * FROM cliente WHERE nombre LIKE '%{0}%' OR apellido LIKE '%{1}%'", nombreOApellido, nombreOApellido));
        }
    }
}
