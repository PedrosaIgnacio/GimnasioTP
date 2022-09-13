using GymApp.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp.Datos.Interfaces
{
    interface IUsuario
    {
        DataTable RecuperarTodos();
        DataTable RecuperarFiltrados(string NombreUsuario, int? IdTipoUsuario);
        DataTable RecuperarUno(int id);
        int InsertarUsuario(Usuario usuario);
        int ActualizarUsuario(Usuario usuario);
        int BajaLogicaUsuario(int IdUsr);
        bool Existe(string NombreUsuario, int? IdUsuario);
    }
}
