using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MaxiKiosko.Clases;
using System.Data;
using System.Windows.Forms;

namespace MaxiKiosko.Clases
{
    class Usuario
    {
        Conexion _BD = new Conexion();
        int _id_usuario;
        string _nombre_usuario;
        string _apellido;
        string _nombre;
        int _rol;
        string _password;


        public Usuario()
        {

        }

        public string nombre_usuario
        {
            get { return this._nombre_usuario; }
            set { this._nombre_usuario = value; }
        }
        public int id_usuario
        {
            get { return this._id_usuario; }
            set { this._id_usuario = value; }
        }
        public string password
        {
            get { return this._password; }
            set { this._password = value; }
        }
        public string apellido
        {
            get { return this._apellido; }
            set { this._apellido = value; }
        }
        public string nombre
        {
            get { return this._nombre; }
            set { this._nombre = value; }
        }
        public int rol
        {
            get { return this._rol; }
            set { this._rol = value; }
        }
        public DataTable autenticacion(string usuario, string pssw)
        {
            string sqltxt = @"SELECT * FROM usuario 
                             WHERE nombre_usuario = '" + usuario + "'"
                             + " AND password = '" + pssw + "'";

            //MessageBox.Show(sqltxt);
            return _BD.consulta(sqltxt);
            
        }
        public void guardar_usuario()
        {
            string SqlInsert = "";
            SqlInsert = @" INSERT INTO usuario 
                         (nombre_usuario,
                         apellido, nombre,
                         rol, password) VALUES ('" +
                         this._nombre_usuario + "', '" +
                         this._apellido + "', '" +
                         this._nombre + "', " +
                         this._rol + ", '" +
                         this._password + "')";
            //MessageBox.Show(SqlInsert);
            this._BD.grabar_modificar(SqlInsert);
        }

        public void actualizar_usuario()
        {
            string sqlUpdate = "";
            sqlUpdate = @" UPDATE usuario
                        SET nombre_usuario = '" +
                        this._nombre_usuario + "', apellido = '" + 
                        this._apellido + "', nombre = '" + 
                        this._nombre + "', rol = " + 
                        this._rol + ", password = '" + 
                        this._password + "' WHERE id_usuario = " + this._id_usuario;
            //MessageBox.Show(sqlUpdate);
            this._BD.grabar_modificar(sqlUpdate);                     
        }
        
        public void borrar_usuario()
        {
            string sqlBorrar = "";
            sqlBorrar = @" DELETE FROM usuario WHERE id_usuario = " +
                        this._id_usuario;
            //MessageBox.Show(sqlBorrar);
            this._BD.grabar_modificar(sqlBorrar);                
        }

        public DataTable mostrarTodosUsuarios()
        {
            string sqlConsulta = "";
            //sqlConsulta = @"SELECT u.id_usuario, u.nombre_usuario, u.apellido, u.nombre, u.password, r.nombre FROM usuario u, rol r WHERE u.rol=r.id_rol";
            sqlConsulta = @"SELECT u.id_usuario, u.nombre_usuario, u.apellido, u.nombre, u.password, r.nombre FROM usuario u INNER JOIN rol r ON u.rol=r.id_rol";

            return _BD.consulta(sqlConsulta);
        }

        public DataTable buscarUsuario(string usuario)
        {
            string sqlBuscar = "";
            //sqlBuscar = @" SELECT * FROM usuario WHERE nombre_usuario LIKE '%" +
            //            usuario + "%'";
            sqlBuscar = @"SELECT u.id_usuario, u.nombre_usuario, u.apellido, u.nombre, u.password, r.nombre as rol FROM usuario u INNER JOIN rol r ON (u.nombre_usuario LIKE '%" +
                        usuario + "%' OR u.id_usuario LIKE '%" +
                        usuario + "%' OR u.apellido LIKE '%" +
                        usuario + "%' OR u.nombre LIKE '%" +
                        usuario + "%') AND u.rol=r.id_rol";
            //MessageBox.Show(sqlBuscar);
            return _BD.consulta(sqlBuscar);
        }
        public DataTable mostrarUsuarioLogueado(string user)
        {
            string sqlConsulta = "";
            sqlConsulta = @"SELECT u.id_usuario, u.nombre_usuario, r.id_rol, r.nombre 
                            FROM usuario u INNER JOIN rol r ON u.rol=r.id_rol 
                            WHERE u.nombre_usuario = '" + user + "'";
             return _BD.consulta(sqlConsulta);
        }
    }
}
