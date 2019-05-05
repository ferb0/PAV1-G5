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

        public int dni { get; set; }
        public string apellido { get; set; }
        public string nombre { get; set; }
        public string telefono { get; set; }
        public string email { get; set; }

        public Cliente (int dni, string papellido, string pnombre, string ptelefono, string pemail )
        {
            this.dni = dni;
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
                         (dni, apellido, nombre, telefono, mail) VALUES (" +
                            this.dni + ", '" +
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
                               "mail = '" + this.email + "'" +
                               " WHERE dni = " + this.dni;
            this._BD.grabar_modificar(SqlUpdate);
        } 

        public DataTable consultarCliente(string subString) {
            return this._BD.consulta(String.Format ("SELECT * FROM cliente WHERE dni LIKE '%{0}%' " +
                " OR nombre LIKE '%{0}%'" +
                " OR apellido LIKE '%{0}%'" +
                " OR telefono LIKE '%{0}%' " +
                " OR mail LIKE '%{0}%'", subString));
        }

        public DataTable buscarTodos()
        {
            return this._BD.consulta("SELECT c.apellido, c.nombre, c.dni, c.telefono, c.mail FROM cliente c;");
        }

        public void borrar(int dni)
        {
            this._BD.grabar_modificar("DELETE FROM cliente WHERE dni = " + dni);
        }

        public bool buscarClientePorDNI(int dni)
        {
            if(this._BD.consulta("SELECT * FROM cliente WHERE dni =" + dni).Rows.Count > 0)
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}
