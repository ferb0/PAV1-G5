using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MaxiKiosko.Clases
{
    class Compra
    {
        Conexion _BD = new Conexion();

        public int id_compra { get; set; }
        public int cuit { get; set; }
        public int nro_comprobante { get; set; }
        public List<DetalleCompra> detalle { get; set; }
        public DateTime fecha_hora { get; set; }
        public int id_usuario { get; set; }
        public decimal total { get; set; }

        public Compra(int id_compra, int cuit, int nro_comprobante, List<DetalleCompra> detalle, DateTime fecha_hora, int id_usuario, decimal total)
        {
            this.id_compra = id_compra;
            this.cuit = cuit;
            this.detalle = detalle;
            this.fecha_hora = fecha_hora;
            this.id_usuario = id_usuario;
            this.total = total;

        }

        public Compra()
        {
        }

        public DataTable consultarTodos()
        {
            return this._BD.consulta("SELECT c.id_compra, c.fecha_hora, p.razon_social, c.numero_comprobante, c.total " +
                " FROM compra c LEFT JOIN proveedor p ON p.cuit = c.proveedor_cuit");
        }

        public void guardarCompra()
        {
            string sqlLastId = @" SELECT id_compra FROM compra ORDER BY id_compra DESC LIMIT 1";
            DataTable dt = this._BD.consulta(sqlLastId);

            int last_id_compra = 1;
            if (dt.Rows.Count > 0)
            {
                last_id_compra = int.Parse(dt.Rows[0][0].ToString()) + 1;

            }

            string SqlInsert;

            SqlInsert = @" INSERT INTO compra
                         (fecha_hora, proveedor_cuit, id_usuario, numero_comprobante, total) VALUES ('" +
                         this.fecha_hora.ToString("yyyy/MM/dd HH:ss") + "', " +
                         this.cuit + ", " +
                         this.id_usuario + ", " +
                         this.nro_comprobante + ", " +
                         this.total +
                         ")";
            this._BD.grabar_modificar(SqlInsert);
            //MessageBox.Show(SqlInsert);

            foreach (var d in this.detalle)
            {
                SqlInsert = @" INSERT INTO detalle_compra 
                            (id_compra, id_producto, cantidad, costo, porc_iva) VALUES (" +
                            last_id_compra + ", " +
                            d.id_producto + ", " +
                            d.cantidad + ", " +
                            d.costo + ", " +
                            d.porc_iva +
                            ")";
                this._BD.grabar_modificar(SqlInsert);

                SqlInsert = @" UPDATE producto SET stock = stock + " + d.cantidad.ToString() + " WHERE id_producto = " + d.id_producto.ToString();
                this._BD.grabar_modificar(SqlInsert);

                //MessageBox.Show(SqlInsert);
            }





            //string sqlLastId = @" SELECT id_detalle_compra FROM detalle_compra ORDER BY id_detalle_compra DESC LIMIT 1";
            //DataTable dt = this._BD.consulta(sqlLastId);

            //int last_id_detalle = 1;
            //if (dt.Rows.Count > 0)
            //{
            //    last_id_detalle = int.Parse(dt.Rows[0][0].ToString()) + 1;

            //}

            //string SqlInsert;
            //foreach (var d in this.detalle)
            //{
            //    SqlInsert = @" INSERT INTO detalle_compra 
            //                (id_detalle_compra, id_producto, cantidad, costo, porc_iva) VALUES (" +
            //                last_id_detalle + ", " +
            //                d.id_producto + ", " +
            //                d.cantidad + ", " +
            //                d.costo + ", " +
            //                d.porc_iva +
            //                ")";
            //    this._BD.grabar_modificar(SqlInsert);
            //    //MessageBox.Show(SqlInsert);
            //}

            //SqlInsert = @" INSERT INTO compra
            //             (fecha_hora, proveedor_cuit, id_usuario, numero_comprobante, total) VALUES ('" +
            //                this.fecha_hora.ToString("yyyy/MM/dd HH:ss") + "', " +
            //                this.cuit + ", " +
            //                this.id_usuario + ", " +
            //                this.nro_comprobante + ", " +
            //                this.total +
            //                 ")";
            //this._BD.grabar_modificar(SqlInsert);
            ////MessageBox.Show(SqlInsert);

        }
    }
}
