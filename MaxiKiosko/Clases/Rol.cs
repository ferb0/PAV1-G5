using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace MaxiKiosko.Clases
{
    class Rol
    {
        Conexion _BD = new Conexion();
        int _id_rol;
        string _nombre_rol;
        string _descripcion_rol;

        public int id_rol
        {
            get { return this._id_rol; }
            set { this._id_rol = value; }
        }
        public string nombre_rol
        {
            get { return this._nombre_rol; }
            set { this._nombre_rol = value; }
        }

        public string descripcion_rol
        {
            get { return this._descripcion_rol; }
            set { this._descripcion_rol = value; }
        }

        public DataTable mostrarTodos()
        {
            string sqlConsulta = "";
            sqlConsulta = @"SELECT * FROM rol";
            return _BD.consulta(sqlConsulta);
        }
        public void guardar_rol()
        {
            string SqlInsert = "";
            SqlInsert = @" INSERT INTO rol 
                         (nombre, descripcion) VALUES ('" +
                         this._nombre_rol + "', '" +
                         this._descripcion_rol + "')";
            //MessageBox.Show(SqlInsert);
            this._BD.grabar_modificar(SqlInsert);
        }

        public void actualizar_Rol()
        {
            string sqlUpdate = "";
            sqlUpdate = @" UPDATE rol
                        SET nombre = '" +
                        this._nombre_rol + "', descripcion = '" +
                        this._descripcion_rol + "' WHERE id_rol = " + this._id_rol;
            //MessageBox.Show(sqlUpdate);
            this._BD.grabar_modificar(sqlUpdate);
        }
        public void borrar_rol()
        {
            string sqlBorrar = "";
            sqlBorrar = @" DELETE FROM rol WHERE id_rol = " +
                        this._id_rol;
            //MessageBox.Show(sqlBorrar);
            this._BD.grabar_modificar(sqlBorrar);
        }
        //public DataTable consultarRol(string subString)
        //{
        //    return this._BD.consulta(String.Format("SELECT * FROM rol WHERE nombre LIKE '%{0}%'" +
        //        " OR descripcion LIKE '%{0}%'", subString));
        //}

        public DataTable buscar_rol(string rol)
        {
            string sqlBuscar = "";
            sqlBuscar = @" SELECT * FROM rol WHERE nombre LIKE '%" +
                        rol +
                        "%' OR descripcion LIKE '%" + rol + "%'";

            //MessageBox.Show(sqlBuscar);
            return _BD.consulta(sqlBuscar);
        }
    }
}
