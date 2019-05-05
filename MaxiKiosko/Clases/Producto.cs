using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;
using System.Globalization;

namespace MaxiKiosko
{
    class Producto
    {
        Conexion _BD = new Conexion();

        public long id_producto { get; set; }
        public decimal precio { get; set; }
        public Nullable<int> stock { get; set; }
        public string descripcion { get; set; }

        public Producto(long id_producto, decimal precio, int stock, string descripcion)
        {
            this.id_producto = id_producto;
            this.precio = precio;
            this.stock = stock;
            this.descripcion = descripcion;
        }


        public Producto()
        {
           
        }

        public void agregarProducto(  )
        {
            var clone = (CultureInfo)CultureInfo.InvariantCulture.Clone();
            clone.NumberFormat.NumberDecimalSeparator = ".";
            clone.NumberFormat.NumberGroupSeparator = ",";
            string SqlInsert = @" INSERT INTO producto
                         (id_producto, precio, stock, descripcion) VALUES ('" +
                            this.id_producto + "', '" +
                            this.precio.ToString(clone) + "', " +
                            ((this.stock != null) ? "'" + this.stock + "'" : "NULL") + ", '" +
                            this.descripcion +
                             "')";
            this._BD.grabar_modificar(SqlInsert);
        }

        public void modificarProducto()
        {
            string SqlUpdate = @" Update producto
                               SET id_producto = '" + this.id_producto + "'," +
                               "precio = '" + this.precio + "'," +
                               "stock = '" + this.stock + "'," +
                               "descripcion = '" + this.descripcion + "'" +
                               " WHERE id_producto = " + this.id_producto;
            this._BD.grabar_modificar(SqlUpdate);
        } 

        public DataTable consultarProducto(string subString) {
            return this._BD.consulta(String.Format ("SELECT * FROM producto WHERE id_producto LIKE '%{0}%'" +
                " OR precio LIKE '%{0}%'" +
                " OR stock LIKE '%{0}%'" +
                " OR descripcion LIKE '%{0}%'", subString));
        }

        public DataTable buscarTodos()
        {
            return this._BD.consulta("SELECT id_producto,descripcion,precio,stock FROM producto");
        }

        public void borrarProducto(long id_producto)
        {
            this._BD.grabar_modificar("DELETE FROM producto WHERE id_producto = " + id_producto);
        }
    }
}
