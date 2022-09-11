using GymApp.Datos.DAOs;
using GymApp.Datos.Interfaces;
using GymApp.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp.Servicios
{
    class UsuarioService
    {
        private IUsuario dao;

        public UsuarioService()
        {
            dao = new UsuarioDao();
        }

        public DataTable RecuperarTodos()
        {
            return dao.RecuperarTodos();
        }
        public DataTable RecuperarFiltrados(string NombreUsuario, int? IdTipoUsuario)
        {
            return dao.RecuperarFiltrados(NombreUsuario, IdTipoUsuario);
        }
        public DataTable RecuperarUno(int id)
        {
            return dao.RecuperarUno(id);
        }
        public int InsertarUsuario(Usuario usuario)
        {
            return dao.InsertarUsuario(usuario);
        }
        public int ActualizarUsuario(Usuario usuario, int IdUsr)
        {
            return dao.ActualizarUsuario(usuario, IdUsr);
        }
        public int BajaLogicaUsuario(int IdUsr)
        {
            return dao.BajaLogicaUsuario(IdUsr);
        }
    }
}
