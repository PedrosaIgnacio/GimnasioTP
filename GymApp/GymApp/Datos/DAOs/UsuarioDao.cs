using GymApp.Datos.Interfaces;
using GymApp.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp.Datos.DAOs
{
    class UsuarioDao : IUsuario
    {
        public DataTable RecuperarFiltrados(string NombreUsuario, int? IdTipoUsuario)
        {
            string consulta = "SELECT U.IdUsuario, U.NombreUsuario, U.Clave, TU.Descripcion as 'Perfil', E.Nombre as 'Estado' FROM Usuario U JOIN Estado E ON E.IdEstado = U.Estado JOIN TipoUsuario TU ON TU.IdTipoUsuario = U.IdTipoUsuario ";
            if (NombreUsuario != "" && IdTipoUsuario != null)
            {
                consulta = consulta + "WHERE U.NombreUsuario LIKE '" + NombreUsuario + "%' AND U.IdTipoUsuario =" + IdTipoUsuario;
            }
            else
            {

                if (IdTipoUsuario != null)
                {
                    consulta = consulta + "WHERE U.IdTipoUsuario =" + IdTipoUsuario;
                }
                if (NombreUsuario != "")
                {
                    consulta = consulta + "WHERE U.NombreUsuario LIKE '" + NombreUsuario + "%'";
                }
            }
            return DBHelper.obtenerInstancia().consultar(consulta);
        }

        public DataTable RecuperarTodos()
        {
            string consulta = "SELECT U.IdUsuario, U.NombreUsuario, U.Clave, TU.Descripcion as 'Perfil', E.Nombre as 'Estado' FROM Usuario U JOIN Estado E ON E.IdEstado = U.Estado JOIN TipoUsuario TU ON TU.IdTipoUsuario = U.IdTipoUsuario ORDER BY U.IdUsuario desc";
            return DBHelper.obtenerInstancia().consultar(consulta);

        }

        public DataTable RecuperarUno(int id)
        {
            string consulta = "SELECT U.IdUsuario, U.NombreUsuario, U.Clave, U.IdTipoUsuario as 'Perfil', U.Estado as 'Estado' FROM Usuario U WHERE U.IdUsuario =" + id;
            return DBHelper.obtenerInstancia().consultar(consulta);
        }

        public int InsertarUsuario(Usuario usuario)
        {
            string consulta = "INSERT INTO Usuario (NombreUsuario, Clave, IdTipoUsuario, Estado) VALUES ('" + usuario.NombreUsuario + "','" + usuario.Clave + "'," + usuario.IdTipoUsuario + "," + usuario.Estado + ")";
            return DBHelper.obtenerInstancia().actualizar(consulta);
        }
        public int ActualizarUsuario(Usuario usuario)
        {
            string consulta = "UPDATE Usuario SET NombreUsuario='" + usuario.NombreUsuario + "', Clave='" + usuario.Clave + "', IdTipoUsuario = '" + usuario.IdTipoUsuario + "', Estado = '" + usuario.Estado + "' WHERE IdUsuario =" + usuario.IdUsuario;
            return DBHelper.obtenerInstancia().actualizar(consulta);
        }

        public int BajaLogicaUsuario(int IdUsr)
        {
            string consulta = "UPDATE Usuario SET Estado = 0 WHERE IdUsuario = " + IdUsr;
            return DBHelper.obtenerInstancia().actualizar(consulta);

        }
        public bool Existe(string NombreUsuario, int? IdUsuario)
        {
            string consulta = "SELECT * FROM Usuario WHERE NombreUsuario = '"+ NombreUsuario+"'";
            if (IdUsuario != null)
            {
                consulta = consulta + " AND IdUsuario != " + IdUsuario;
            }
            return (DBHelper.obtenerInstancia().consultar(consulta).Rows.Count > 0);
        }
    }
}
