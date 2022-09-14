using GymApp.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp.Datos
{
    class DBHelper
    {
        private static DBHelper instancia;
        private SqlConnection conexion;
        private SqlCommand comando;
        private string cadenaConexion;
        private DBHelper()
        {
            conexion = new SqlConnection();
            comando = new SqlCommand();
            cadenaConexion = Properties.Resources.StringConexion;
        }
        public static DBHelper obtenerInstancia()
        {
            if (instancia == null)
                instancia = new DBHelper();
            return instancia;
        }
        public DataTable consultar(string consultaSQL)
        {
            DataTable tabla = new DataTable();
            conexion.ConnectionString = cadenaConexion;
            conexion.Open();

            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
            comando.CommandText = consultaSQL;
            tabla.Load(comando.ExecuteReader());

            conexion.Close();
            return tabla;
        }
        public int actualizar(string consultaSQL)
        {
            int rowsAff;
            conexion.ConnectionString = cadenaConexion;
            conexion.Open();

            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
            comando.CommandText = consultaSQL;
            rowsAff = comando.ExecuteNonQuery();

            conexion.Close();
            return rowsAff;
        }
        public List<Usuario> ConsultarList(string consultaSQL)
        {
            List<Usuario> lstUsu = new List<Usuario>();
            conexion.ConnectionString = cadenaConexion;
            conexion.Open();

            comando.Connection = conexion;
            comando.CommandType = CommandType.Text;
            comando.CommandText = consultaSQL;

            using (SqlDataReader dr = comando.ExecuteReader())
            {
                while (dr.Read())
                {
                    Usuario usuario = new Usuario();
                    usuario.IdUsuario = int.Parse(dr["IdUsuario"].ToString());
                    usuario.NombreUsuario = dr["NombreUsuario"].ToString();
                    usuario.Clave = dr["Clave"].ToString();
                    usuario.IdTipoUsuario = int.Parse(dr["IdTipoUsuario"].ToString());
                    usuario.Estado = int.Parse(dr["Estado"].ToString());

                    lstUsu.Add(usuario);
                }
                return lstUsu;
            }
        }

    }
}
