using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace MaxiKiosko
{
    class Cliente
    {
        Conexion _BD = new Conexion();

        public int idCliente { get; set; }
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


        public Cliente()
        {
           
        }

        public void agregarCliente(  )
        {
            string SqlInsert = @" INSERT INTO cliente
                         (apellido, nombre, telefono, email) VALUES ('" +
                            this.apellido + "', '" +
                            this.nombre + "', '" +
                            this.telefono + "', '" +
                            this.email +
                             "')";
            this._BD.grabar_modificar(SqlInsert);
        }

        public void modificarCliente()
        {
            string SqlUpdate = @" Update cliente
                               SET nombre = '" + this.nombre + "'," +
                               "apellido = '" + this.apellido + "'," +
                               "telefono = '" + this.telefono + "'," +
                               "email = '" + this.email + "'" +
                               " WHERE idCliente = " + this.idCliente;
            this._BD.grabar_modificar(SqlUpdate);
        } 

        public DataTable consultarCliente(string subString) {
            return this._BD.consulta(String.Format ("SELECT * FROM cliente WHERE nombre LIKE '%{0}%'" +
                " OR apellido LIKE '%{0}%'" +
                " OR telefono LIKE '%{0}%' " +
                " OR email LIKE '%{0}%'", subString));
        }

        public DataTable buscarTodos()
        {
            return this._BD.consulta("SELECT * FROM cliente");
        }

        public void borrar(int idCliente)
        {
            this._BD.grabar_modificar("DELETE FROM cliente WHERE idCliente = " + idCliente);
        }
    }
}
