using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxiKiosko.Clases
{
    class DetalleVenta
    {
        private int idDetalleVenta { get; set; }
        private Producto producto { get; set; }
        private int cantidad { get; set; }
        private decimal precioHistorico { get; set; }

        public DetalleVenta(int idDetalleVenta, Producto producto, int cantidad, decimal precioHistorico)
        {
            this.idDetalleVenta = idDetalleVenta;
            this.producto = producto;
            this.cantidad = cantidad;
            this.precioHistorico = precioHistorico;
        }

        public DetalleVenta()
        {
            
        }
    }
}
