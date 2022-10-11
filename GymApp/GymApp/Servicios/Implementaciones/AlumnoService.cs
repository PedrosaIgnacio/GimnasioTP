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

        public int Modificar(DetallePlan alumno)
        {
            return dao.Modificar(alumno);
        }

        public List<DetallePlan> RecuperarFiltrados(string nombre, int? dni)
        {
            return dao.RecuperarFiltrados(nombre, dni);
        }

        public List<DetallePlan> RecuperarTodos()
        {
            return dao.RecuperarTodos();
        }

        public DetallePlan RecuperarUno(long documento)
        {
            return dao.RecuperarUno(documento);
        }

        public int Insertar(DetallePlan a)
        {
            return dao.Insertar(a);
        }

        public int BajaLogica(long a)
        {
            return dao.BajaLogica(a);
        }
    }
}
