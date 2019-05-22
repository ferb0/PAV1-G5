using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxiKiosko.Clases
{
    class DetalleVenta
    {
        public int idDetalleVenta { get; set; }
        public long idProducto { get; set; }
        public int cantidad { get; set; }
        public decimal precioHistorico { get; set; }

        public DetalleVenta(int idDetalleVenta, long idProducto, int cantidad, decimal precioHistorico)
        {
            this.idDetalleVenta = idDetalleVenta;
            this.idProducto = idProducto;
            this.cantidad = cantidad;
            this.precioHistorico = precioHistorico;
        }

        public DetalleVenta()
        {
            
        }
    }
}
