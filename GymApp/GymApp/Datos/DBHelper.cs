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
    }
}
