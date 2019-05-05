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
    class Proveedor
    {
        Conexion _BD = new Conexion();

        public long cuit { get; set; }
        public string razon_social { get; set; }
        public string telefono { get; set; }
        public string email { get; set; }
        

        public Proveedor (int cuit, string razon_social, string telefono, string email)
        {
            this.cuit = cuit;
            this.razon_social = razon_social;
            this.telefono = telefono;
            this.email = email;
        }


        public Proveedor()
        {
           
        }

        public void agregarProveedor(  )
        {
            string SqlInsert = @" INSERT INTO proveedor
                         (cuit, razon_social, telefono, email) VALUES ('" +
                            this.cuit + "', '" +
                            this.razon_social + "', '" +
                            this.telefono + "', '" +
                            this.email +
                             "')";
            this._BD.grabar_modificar(SqlInsert);
        }

        public void modificarProveedor()
        {
            string SqlUpdate = @" Update proveedor
                               SET cuit = '" + this.cuit + "'," +
                               "razon_social = '" + this.razon_social + "'," +
                               "telefono = '" + this.telefono + "'," +
                               "email = '" + this.email + "'" +
                               " WHERE cuit = " + this.cuit;
            this._BD.grabar_modificar(SqlUpdate);
        } 

        public DataTable consultarProveedor(string subString) {
            return this._BD.consulta(String.Format ("SELECT * FROM proveedor WHERE razon_social LIKE '%{0}%'" +
                " OR cuit LIKE '%{0}%'" +
                " OR telefono LIKE '%{0}%' " +
                " OR email LIKE '%{0}%'", subString));
        }

        public DataTable buscarTodos()
        {
            return this._BD.consulta("SELECT * FROM proveedor");
        }

        public void borrar(long cuit)
        {
            this._BD.grabar_modificar("DELETE FROM proveedor WHERE cuit = " + cuit);
        }

        public bool buscarProveedorPorCuit(long cuit)
        {
            if(this._BD.consulta("SELECT * FROM proveedor WHERE cuit =" + cuit).Rows.Count > 0)
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}
