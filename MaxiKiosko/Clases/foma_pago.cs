using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace MaxiKiosko
{
    class Forma_pago
    {
        Conexion _BD = new Conexion();

        public int id_forma_pago { get; set; }
        public string descripcion { get; set; }
        
        
        

        public Forma_pago(int id_forma_pago, string descripcion)
        {
            this.id_forma_pago = id_forma_pago;
            this.descripcion = descripcion;
            
            
        }


        public Forma_pago()
        {
           
        }

        public void agregarForma_pago(  )
        {
            string SqlInsert = @" INSERT INTO forma_pago
                         (descripcion) VALUES ('" +
                            this.descripcion + 
                             "')";
            this._BD.grabar_modificar(SqlInsert);
        }

        public void modificarForma_pago()
        {
            string SqlUpdate = @" Update forma_pago
                               SET descripcion = '" + this.descripcion  + "'" +
                               " WHERE id_forma_pago = " + this.id_forma_pago;
            this._BD.grabar_modificar(SqlUpdate);
        } 

        public DataTable consultarForma_pago(string subString) {
            return this._BD.consulta(String.Format ("SELECT * FROM forma_pago WHERE id_forma_pago LIKE '%{0}%'" , subString));
        }

        public DataTable buscarTodos()
        {
            return this._BD.consulta("SELECT * FROM forma_pago");
        }

        public void borrarForma_pago(int id_forma_pago)
        {
            this._BD.grabar_modificar("DELETE FROM forma_pago WHERE id_forma_pago = " + id_forma_pago);
        }
    }
}
