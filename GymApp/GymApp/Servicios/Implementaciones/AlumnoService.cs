using GymApp.Datos.DAOs;
using GymApp.Datos.Interfaces;
using GymApp.Entidades;
using GymApp.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymApp.Servicios.Implementaciones
{
    internal class AlumnoService : IAlumnoService
    {
        private IAlumno dao;
        public AlumnoService()
        {
            dao = new AlumnoDao();
        }

        public List<Alumno> RecuperarFiltrados(string nombre, string dni)
        {
            return dao.RecuperarFiltrados(nombre, dni);
        }

        public List<Alumno> RecuperarTodos()
        {
            throw new NotImplementedException();
        }

    }
}
