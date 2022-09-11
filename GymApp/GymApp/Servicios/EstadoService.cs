using GymApp.Datos.DAOs;
using GymApp.Datos.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp.Servicios
{
    class EstadoService
    {
        private IEstado dao;
        public EstadoService()
        {
            dao = new EstadoDao();
        }
        public DataTable RecuperarTodos()
        {
            return dao.RecuperarTodos();
        }
    }
}
