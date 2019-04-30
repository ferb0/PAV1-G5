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
    class Cuenta_corriente
    {
        Conexion _BD = new Conexion();

        public int id_cuenta { get; set; }
        public float balance { get; set; }
        public float limite_credito { get; set; }
        
        

        public Cuenta_corriente(int id_cuenta, float balance, float limite_credito)
        {
            this.id_cuenta = id_cuenta;
            this.balance = balance;
            this.limite_credito = limite_credito;
            
        }


        public Cuenta_corriente()
        {
           
        }

        public void agregarCuenta_corriente(  )
        {
            string SqlInsert = @" INSERT INTO proveedor
                         (balance, limite_credito) VALUES ('" +
                            this.balance + "', '" +
                            this.limite_credito + 
                             "')";
            this._BD.grabar_modificar(SqlInsert);
        }

        public void modificarCuenta_corriente()
        {
            string SqlUpdate = @" Update proveedor
                               SET balance = '" + this.balance + "'," +
                               "limite_credito = '" + this.limite_credito + "'" +
                               " WHERE id_cuenta = " + this.id_cuenta;
            this._BD.grabar_modificar(SqlUpdate);
        } 

        public DataTable consultarCuenta_corriente(string subString) {
            return this._BD.consulta(String.Format ("SELECT * FROM proveedor WHERE id_cuenta LIKE '%{0}%'" +
                " OR balance LIKE '%{0}%'" +
                " OR limite_credito LIKE '%{0}%' ", subString));
        }

        public DataTable buscarTodos()
        {
            return this._BD.consulta("SELECT * FROM cuenta_corriente");
        }

        public void borrarCuenta_corriente(int id_cuenta)
        {
            this._BD.grabar_modificar("DELETE FROM cuenta_corriente WHERE id_cuenta = " + id_cuenta);
        }
    }
}
