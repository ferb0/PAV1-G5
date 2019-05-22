using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxiKiosko.Clases
{
    class Venta
    {
        Conexion _BD = new Conexion();

        public int nroTicket { get; set; }
        public int idCliente { get; set; }
        public List<DetalleVenta> detalle { get; set; }
        public DateTime fecha { get; set; }
        public Forma_pago formaPago { get; set; }
        public decimal total { get; set; }

        public Venta(int nroTicket, Cliente cliente, List<DetalleVenta> detalle, DateTime fecha, Forma_pago formaPago)
        {
            this.nroTicket = nroTicket;
            this.idCliente = idCliente;
            this.detalle = detalle;
            this.fecha = fecha;
            this.formaPago = formaPago;
        }

        public Venta()
        {
        }

        public void guardarVenta()
        {
            string sqlLastId = @" SELECT id_detalle_venta FROM detalle_venta ORDER BY id_detalle_venta DESC LIMIT 1";
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
