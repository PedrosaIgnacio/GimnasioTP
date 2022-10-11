using GymApp.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp.Servicios.Interfaces
{
    internal interface IAlumnoService
    {
        List<DetallePlan> RecuperarTodos();
        List<DetallePlan> RecuperarFiltrados(string nombre, int? dni);
        DetallePlan RecuperarUno(long documento);
        int Modificar(DetallePlan alumno);
        int Insertar(DetallePlan alumno);
        int BajaLogica(long idAlumno);
    }
}
