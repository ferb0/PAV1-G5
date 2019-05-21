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
        public string domicilio { get; set; }
        public string telefono { get; set; }
        public string email { get; set; }

        public int id_cuenta_corriente { get; set; }

        public Cliente (int dni, string papellido, string pnombre, string domicilio, string ptelefono, string pemail, int id_cuenta_corriente )
        {
            this.dni = dni;
            this.apellido = papellido;
            this.nombre = pnombre;
            this.domicilio = domicilio;
            this.telefono = ptelefono;
            this.email = pemail;
            this.id_cuenta_corriente = id_cuenta_corriente;
        }

        public Cliente()
        {
           
        }

        public void agregarCliente(  )
        {
            string SqlInsert = @" INSERT INTO cliente
                         (dni, apellido, nombre, domicilio, telefono, mail, id_cuenta) VALUES (" +
                            this.dni + ", '" +
                            this.apellido + "', '" +
                            this.nombre + "', " +
                            ((this.domicilio != "") ? "'" + this.domicilio + "'" : "NULL") + ", " +
                            ((this.telefono != "") ? "'" + this.telefono + "'" : "NULL") + ", " +
                            ((this.email != "") ? "'" + this.email + "'" : "NULL") + ", " +
                            this.id_cuenta_corriente +
                             ")";
            this._BD.grabar_modificar(SqlInsert);
        }

        public void modificarCliente()
        {
            string SqlUpdate = @" Update cliente
                               SET nombre = '" + this.nombre + "'," +
                               "apellido = '" + this.apellido + "'," +
                               "domicilio = " + ((this.domicilio != "") ? "'" + this.domicilio + "'" : "NULL") + "," +
                               "telefono = " + ((this.telefono != "") ? "'" + this.telefono + "'" : "NULL") + "," +
                               "mail = " + ((this.email != "") ? "'" + this.email + "'" : "NULL") +
                               " WHERE dni = " + this.dni;
            this._BD.grabar_modificar(SqlUpdate);
        } 

        public DataTable consultarCliente(string subString) {
            return this._BD.consulta(String.Format ("SELECT apellido, nombre, dni, domicilio, telefono, mail FROM cliente c WHERE dni LIKE '%{0}%' " +
                " OR nombre LIKE '%{0}%'" +
                " OR apellido LIKE '%{0}%'" +
                " OR domicilio LIKE '%{0}%'" +
                " OR telefono LIKE '%{0}%' " +
                " OR mail LIKE '%{0}%'", subString));
        }

        public DataTable buscarTodos()
        {
            return this._BD.consulta("SELECT apellido, nombre, dni, domicilio, telefono, mail FROM cliente c;");
        }

        public void borrar(int dni)
        {
            string id_cuenta_corriente = this._BD.consulta("SELECT * FROM cliente WHERE dni =" + dni).Rows[0]["id_cuenta"].ToString();
            this._BD.grabar_modificar("DELETE FROM cliente WHERE dni = " + dni);
            Cuenta_corriente cuenta = new Cuenta_corriente();
            cuenta.borrarCuenta_corriente(int.Parse(id_cuenta_corriente));
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

        public DataTable buscarTodosTypeahead()
        {
            return this._BD.consulta("SELECT concat(c.apellido, ', ' ,c.nombre, ' - ', c.dni) FROM maxikiosko.cliente c;");
        }
    }
}
