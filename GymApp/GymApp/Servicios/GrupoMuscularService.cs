using GymApp.Datos.DAOs;
using GymApp.Datos.Interfaces;
using GymApp.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp.Servicios
{
    internal class GrupoMuscularService
    {
        private IGrupoMuscular dao;

        public GrupoMuscularService()
        {
            dao = new GrupoMuscularDao();
        }

        public List<GrupoMuscular> RecuperarTodos()
        {
            return dao.RecuperarTodos();
        }
    }
}
