using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxiKiosko.Clases
{
    class DetalleCompra
    {
        public int id_detalle_compra { get; set; }
        public long id_producto { get; set; }
        public int cantidad { get; set; }
        public decimal costo { get; set; }
        public int porc_iva { get; set; }

        public DetalleCompra(int id_detalle_compra, long id_producto, int cantidad, decimal costo,int porc_iva)
        {
            this.id_detalle_compra = id_detalle_compra;
            this.id_producto = id_producto;
            this.cantidad = cantidad;
            this.costo = costo;
            this.porc_iva = porc_iva;
        }

        public DetalleCompra()
        {

        }

    }
}


