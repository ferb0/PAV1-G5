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
        public int tipo_producto { get; set; }

        public Producto(long id_producto, int tipo_producto, decimal precio, int stock, string descripcion)
        {
            this.id_producto = id_producto;
            this.tipo_producto = tipo_producto; 
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
                         (id_producto, tipo_producto, precio, stock, descripcion) VALUES ('" +
                            this.id_producto + "', '" +
                            this.tipo_producto + "', '" +
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
                               "tipo_producto = '" + this.tipo_producto + "'," +
                               "descripcion = '" + this.descripcion + "'" +
                               " WHERE id_producto = " + this.id_producto;
            this._BD.grabar_modificar(SqlUpdate);
        } 

        public DataTable consultarProducto(string subString) {
            return this._BD.consulta(String.Format ("SELECT p.id_producto, p.descripcion, tp.descripcion 'tipo',p.precio, p.stock FROM producto p" +
                                     " INNER JOIN tipo_producto tp ON p.tipo_producto = tp.id_tipo_producto" +
                                     " WHERE p.id_producto LIKE '%{0}%'" +
                                     " OR p.precio LIKE '%{0}%'" +
                                     " OR tp.descripcion LIKE '%{0}%'" +
                                     " OR p.stock LIKE '%{0}%'" +
                                     " OR p.descripcion LIKE '%{0}%'", subString));
        }

        public DataTable buscarTodos()
        {
            return this._BD.consulta("SELECT p.id_producto, tp.descripcion 'tipo', p.descripcion, p.precio, p.stock FROM producto p" +
                                     " INNER JOIN tipo_producto tp ON p.tipo_producto = tp.id_tipo_producto; ");
        }

        public void buscarPorCodigo()
        {
            DataTable dt = this._BD.consulta("SELECT id_producto, descripcion FROM producto");
            this.id_producto = Int64.Parse(dt.Rows[0][0].ToString());
            this.descripcion = dt.Rows[0][1].ToString();
        }

        public void buscarPorCodigoUnico()
        {
            DataTable dt = this._BD.consulta("SELECT id_producto, descripcion, precio FROM producto WHERE id_producto = " + this.id_producto);
            this.descripcion = dt.Rows[0][1].ToString();
            this.precio = decimal.Parse(dt.Rows[0][2].ToString());
        }

        public void borrarProducto(long id_producto)
        {
            this._BD.grabar_modificar("DELETE FROM producto WHERE id_producto = " + id_producto);
        }

        public Boolean hayStock(int cantidad)
        {
            DataTable dt = this._BD.consulta("SELECT stock FROM producto WHERE id_producto = " + id_producto);
            int cantidadStock = int.Parse(dt.Rows[0][0].ToString());

            if(cantidadStock-cantidad >= 0)
            {
                return true;
            }
            return false;
        }
    }
}
