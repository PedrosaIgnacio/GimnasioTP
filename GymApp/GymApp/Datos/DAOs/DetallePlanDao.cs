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
    internal class DetallePlanDao : IDetallePlan
    {
        public List<DetallePlan> RecuperarTodos(int idPlan)
        {
            string consulta = "SELECT d.IdPlan, d.IdEjercicio, d.Repeticiones, d.Series FROM DetallePlan WHERE IdPlan =" + idPlan;
            return MapeoAListaDeDetallePlan(DBHelper.obtenerInstancia().consultar(consulta));
        }
        private DetallePlan MapeoPlan(DataTable tabla)
        {
            DetallePlan DetallePlan = new DetallePlan();
            DetallePlan.IdPlan = (int)tabla.Rows[0]["IdPlan"];
            DetallePlan.Ejercicio.IdEJ = (int)tabla.Rows[0]["IdEjercicio"];
            DetallePlan.Repeticiones = (int)tabla.Rows[0]["Repeticiones"];
            DetallePlan.Series = (int)tabla.Rows[0]["Series"];
            return DetallePlan;
        }

        public List<DetallePlan> MapeoAListaDeDetallePlan(DataTable tabla)
        {
            List<DetallePlan> listDetalle = new List<DetallePlan>();
            foreach (DataRow row in tabla.Rows)
            {
                DetallePlan DetallePlan = new DetallePlan();
                DetallePlan.IdPlan = (int)row["IdPlan"];
                DetallePlan.Ejercicio.IdEJ = (int)row["IdEjercicio"];
                DetallePlan.Repeticiones = (int)row["Repeticiones"];
                DetallePlan.Series = (int)row["Series"];
                listDetalle.Add(DetallePlan);
            }
            return listDetalle;
        }

    }
}
