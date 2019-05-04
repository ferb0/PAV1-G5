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
    class Producto
    {
        Conexion _BD = new Conexion();

        public int id_producto { get; set; }
        public float precio { get; set; }
        public int stock { get; set; }
        public string tipo_medida { get; set; }
        public string descripcion { get; set; }

        public Producto(float precio, int stock, string tipo_medida, string descripcion)
        {
            this.precio = precio;
            this.stock = stock;
            this.tipo_medida = tipo_medida;
            this.descripcion = descripcion;
        }


        public Producto()
        {
           
        }

        public void agregarProducto(  )
        {
            string SqlInsert = @" INSERT INTO producto
                         (precio, stock, tipo_medida, descripcion) VALUES ('" +
                            this.precio + "', '" +
                            this.stock + "', '" +
                            this.tipo_medida + "', '" +
                            this.descripcion +
                             "')";
            this._BD.grabar_modificar(SqlInsert);
        }

        public void modificarProducto()
        {
            string SqlUpdate = @" Update producto
                               SET precio = '" + this.precio + "'," +
                               "stock = '" + this.stock + "'," +
                               "tipo_medida = '" + this.tipo_medida + "'," +
                               "descripcion = '" + this.descripcion + "'" +
                               " WHERE id_producto = " + this.id_producto;
            this._BD.grabar_modificar(SqlUpdate);
        } 

        public DataTable consultarProducto(string subString) {
            return this._BD.consulta(String.Format ("SELECT * FROM producto WHERE precio LIKE '%{0}%'" +
                " OR stock LIKE '%{0}%'" +
                " OR tipo_medida LIKE '%{0}%' " +
                " OR descripcion LIKE '%{0}%'", subString));
        }

        public DataTable buscarTodos()
        {
            return this._BD.consulta("SELECT * FROM producto");
        }

        public void borrarProducto(int id_producto)
        {
            this._BD.grabar_modificar("DELETE FROM producto WHERE id_producto = " + id_producto);
        }
    }
}
