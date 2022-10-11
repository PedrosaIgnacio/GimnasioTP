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
    internal class PlanGymDao : IPlanGym
    {
        public PlanGym recuperarUno(int idPlan)
        {
            string consulta = "SELECT * FROM PlanGim WHERE IdPlan =" + idPlan;
            return MapeoPlan(DBHelper.obtenerInstancia().consultar(consulta));
        }
        private PlanGym MapeoPlan(DataTable tabla)
        {
            PlanGym plan = new PlanGym();
            plan.IdPlan = (int)tabla.Rows[0]["IdPlan"];
            plan.Descripcion = tabla.Rows[0]["Descripcion"].ToString();
            plan.Nombre = tabla.Rows[0]["Nombre"].ToString();
            plan.FechaDesde = (DateTime)tabla.Rows[0]["FechaDesde"];
            plan.FechaHasta = (DateTime)tabla.Rows[0]["FechaHasta"];
            plan.Alumno.NroDocumento = (int)tabla.Rows[0]["NumDocAl"];
            plan.Alumno.TipoDoc.IdTipoDoc = (int)tabla.Rows[0]["TipoDocAl"];
            return plan;
        }
    }
}
