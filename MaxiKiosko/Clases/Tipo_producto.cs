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
    class Tipo_producto
    {
        Conexion _BD = new Conexion();

        public int id_tipo_producto { get; set; }
        public string descripcion { get; set; }




        public Tipo_producto(int id_tipo_producto, string descripcion)
        {
            this.id_tipo_producto = id_tipo_producto;
            this.descripcion = descripcion;


        }


        public Tipo_producto()
        {

        }

        public void agregarTipo_producto()
        {
            string SqlInsert = @" INSERT INTO tipo_producto
                         (descripcion) VALUES ('" +
                            this.descripcion +
                             "')";
            this._BD.grabar_modificar(SqlInsert);
        }

        public void modificarTipo_producto()
        {
            string SqlUpdate = @" Update tipo_producto
                               SET descripcion = '" + this.descripcion + "'" +
                               " WHERE id_tipo_producto = " + this.id_tipo_producto;
            this._BD.grabar_modificar(SqlUpdate);
        }

        public DataTable consultarTipo_producto(string subString)
        {
            return this._BD.consulta(String.Format("SELECT * FROM tipo_producto WHERE id_tipo_producto LIKE '%{0}%' OR descripcion LIKE '%{0}%'", subString));
        }

        public DataTable buscarTodos()
        {
            return this._BD.consulta("SELECT * FROM tipo_producto");
        }

        public void borrarTipo_producto(int id_forma_pago)
        {
            this._BD.grabar_modificar("DELETE FROM tipo_producto WHERE id_tipo_producto = " + id_tipo_producto);
        }
    }
}
