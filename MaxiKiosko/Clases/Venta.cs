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
        public int formaPago { get; set; }
        public decimal total { get; set; }

        public int idUsuario { get; set; }

        public Venta(int nroTicket, int cliente, List<DetalleVenta> detalle, DateTime fecha, int formaPago, int idUsuario)
        {
            this.nroTicket = nroTicket;
            this.idCliente = idCliente;
            this.detalle = detalle;
            this.fecha = fecha;
            this.formaPago = formaPago;
            this.idUsuario = idUsuario;
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

                SqlInsert = @" UPDATE producto SET stock = stock - " + d.cantidad.ToString() + " WHERE id_producto = " + d.idProducto.ToString();
                this._BD.grabar_modificar(SqlInsert);
            }

            SqlInsert = @" INSERT INTO venta
                         (fecha_hora, total, id_forma_pago, dni, id_detalle_venta, id_usuario) VALUES ('" +
                            this.fecha.ToString("yyyy/MM/dd HH:ss") + "', '" +
                            this.total + "', '" +
                            this.formaPago + "', " +
			                ((this.idCliente == 0) ? "1" : this.idCliente.ToString()) + ", '" +
                            last_id_detalle + "', " +
                            this.idUsuario +
                             ")";
            this._BD.grabar_modificar(SqlInsert);

        }
        public DataTable consultarTodos() {
            return this._BD.consulta("SELECT vent.nro_ticket,vent.fecha_hora,vent.total,cli.nombre,cli.apellido,cli.dni,fp.descripcion FROM venta AS vent" +
                                     " LEFT JOIN cliente AS cli ON vent.dni = cli.dni"+
                                     " LEFT JOIN forma_pago AS fp ON vent.id_forma_pago = fp.id_forma_pago");
        }
        public DataTable ConsultarReporte(DateTime fecha_inicio, DateTime fecha_fin)
        {
            //MessageBox.Show(fecha_inicio.ToString("yyyy/MM/dd HH:ss") + fecha_fin.ToString("yyyy/MM/dd HH:ss"));

            //return this._BD.consulta("call spRptVentasWithPrompt('" + fecha_inicio.ToString("yyyy/MM/dd HH:ss") + "', '" + fecha_fin.ToString("yyyy/MM/dd HH:ss") + "')");
            return this._BD.consulta("SELECT venta.nro_ticket, venta.fecha_hora, venta.dni, cliente.nombre, cliente.apellido, venta.id_detalle_venta, forma_pago.descripcion as forma_pago, detalle_venta.cantidad, producto.descripcion AS producto, detalle_venta.precio_historico " +
                                     "FROM producto INNER JOIN detalle_venta ON producto.id_producto = detalle_venta.id_producto " +
                                     "INNER JOIN tipo_producto ON producto.tipo_producto = tipo_producto.id_tipo_producto " +
                                     "INNER JOIN venta ON detalle_venta.id_detalle_venta = venta.id_detalle_venta " +
                                     "INNER JOIN cliente ON venta.dni = cliente.dni " +
                                     "INNER JOIN forma_pago ON venta.id_forma_pago = forma_pago.id_forma_pago " +
                                     "WHERE venta.fecha_hora >= '" + fecha_inicio.ToString("yyyy/MM/dd HH:ss") + "' AND venta.fecha_hora <= '" + fecha_fin.ToString("yyyy/MM/dd HH:ss") + "'" +
                                     " GROUP BY venta.nro_ticket, venta.total, venta.id_detalle_venta, producto.descripcion");
        }
    }
}
