using System;
using System.Collections.Generic;
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
            string SqlInsert = @" INSERT INTO venta
                         (cliente) VALUES ('" +
                            this.idCliente +
                             "')";
            this._BD.grabar_modificar(SqlInsert);
        }
    }
}
