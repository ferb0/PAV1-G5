using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxiKiosko.Clases
{
    class Compra
    {
        Conexion _BD = new Conexion();

        public int id_compra { get; set; }
        public long cuit { get; set; }
        public List<DetalleCompra> detalle { get; set; }
        public DateTime fecha_hora { get; set; }
        public int id_usuario { get; set; }
        public decimal total { get; set; }

        public Compra(int id_compra, long cuit, List<DetalleCompra> detalle, DateTime fecha_hora, int id_usuario)
        {
            this.id_compra = id_compra;
            this.cuit = cuit;
            this.detalle = detalle;
            this.fecha_hora = fecha_hora;
            this.id_usuario = id_usuario;

        }

        public Compra()
        {
        }

        public void guardarCompra()
        {
            string sqlLastId = @" SELECT id_detalle_compra FROM detalle_compra ORDER BY id_detalle_compra DESC LIMIT 1";
            DataTable dt = this._BD.consulta(sqlLastId);

            int last_id_detalle = 1;
            if (dt.Rows.Count > 0)
            {
                last_id_detalle = int.Parse(dt.Rows[0][0].ToString()) + 1;

            }

            string SqlInsert;
            foreach (var d in this.detalle)
            {
                SqlInsert = @" INSERT INTO detalle_venta 
                            (id_detalle_venta, cantidad, precio_historico, id_producto) VALUES ('" +
                            last_id_detalle + "', '" +
                            d.cantidad + "', '" +
                            d.precioHistorico + "', '" +
                            d.idProducto +
                            "')";
                this._BD.grabar_modificar(SqlInsert);
            }

            SqlInsert = @" INSERT INTO venta
                         (fecha_hora, total, id_forma_pago, id_detalle_venta) VALUES ('" +
                            this.fecha.ToString("yyyy/MM/dd HH:ss") + "', '" +
                            this.total + "', '" +
                            1 + "', '" +
                            last_id_detalle +
                             "')";
            this._BD.grabar_modificar(SqlInsert);

        }
    }
}
