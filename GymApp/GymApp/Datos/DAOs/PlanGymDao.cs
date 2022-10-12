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
        public List<PlanGym> recuperarTodos(string fechaDesde, string fechaHasta)
        {
            string consulta = "SELECT p.IdPlan, p.Nombre, p.Descripcion, p.FechaDesde, p.FechaHasta, p.NumDocAl, p.TipoDocAl, a.Nombre as NombreAlumno, a.Apellido FROM PlanGim p JOIN Alumno a ON p.NumDocAl= a.NumDoc WHERE FechaDesde ='" + fechaDesde + "' AND FechaHasta ='" + fechaHasta+"'";
            return MapeoListaPlan(DBHelper.obtenerInstancia().consultar(consulta));
        }
        public List<PlanGym> recuperarFiltrados(long nroDoc, string fechaDesde, string fechaHasta)
        {
            string consulta = "SELECT p.IdPlan, p.Nombre, p.Descripcion, p.FechaDesde, p.FechaHasta, p.NumDocAl, p.TipoDocAl, a.Nombre as NombreAlumno, a.Apellido FROM PlanGim p JOIN Alumno a ON p.NumDocAl= a.NumDoc WHERE p.FechaDesde ='" + fechaDesde + "' AND p.FechaHasta ='" + fechaHasta + "' AND p.NumDocAl =" + nroDoc;
            return MapeoListaPlan(DBHelper.obtenerInstancia().consultar(consulta));
        }

        public PlanGym recuperarUno(int idPlan)
        {
            string consulta = "SELECT p.IdPlan, p.Nombre, p.Descripcion, p.FechaDesde, p.FechaHasta, p.NumDocAl, p.TipoDocAl, a.Nombre as NombreAlumno, a.Apellido FROM PlanGim p JOIN Alumno a ON p.NumDocAl= a.NumDoc WHERE IdPlan =" + idPlan;
            return MapeoPlan(DBHelper.obtenerInstancia().consultar(consulta));
        }

        public int Modificar(PlanGym plan)
        {
            string consulta = "UPDATE PlanGim SET Descripcion = '" + plan.Descripcion + "', FechaHasta = '" + plan.FechaHasta + "'";
            return DBHelper.obtenerInstancia().actualizar(consulta);
        }


        private PlanGym MapeoPlan(DataTable tabla)
        {
            PlanGym plan = new PlanGym();
            plan.IdPlan = (int)tabla.Rows[0]["IdPlan"];
            plan.Descripcion = tabla.Rows[0]["Descripcion"].ToString();
            plan.Nombre = tabla.Rows[0]["Nombre"].ToString();
            plan.FechaDesde = (DateTime)tabla.Rows[0]["FechaDesde"];
            plan.FechaHasta = (DateTime)tabla.Rows[0]["FechaHasta"];
            plan.Alumno = new Alumno();
            plan.Alumno.Nombre = tabla.Rows[0]["NombreAlumno"].ToString();
            plan.Alumno.Apellido = tabla.Rows[0]["Apellido"].ToString();
            plan.Alumno.NroDocumento = (long)tabla.Rows[0]["NumDocAl"];
            plan.Alumno.TipoDoc = new TipoDocumento();
            plan.Alumno.TipoDoc.IdTipoDoc = (int)tabla.Rows[0]["TipoDocAl"];
            return plan;
        }
        private List<PlanGym> MapeoListaPlan(DataTable tabla)
        {
            List<PlanGym> listplan = new List<PlanGym>();
            foreach (DataRow row in tabla.Rows)
            {
                PlanGym plan = new PlanGym();
                plan.IdPlan = (int)row["IdPlan"];
                plan.Descripcion = row["Descripcion"].ToString();
                plan.Nombre = row["Nombre"].ToString();
                plan.FechaDesde = (DateTime)row["FechaDesde"];
                plan.FechaHasta = (DateTime)row["FechaHasta"];
                plan.Alumno = new Alumno();
                plan.Alumno.Nombre = row["NombreAlumno"].ToString();
                plan.Alumno.Apellido = row["Apellido"].ToString();
                plan.Alumno.NroDocumento = (long)row["NumDocAl"];
                plan.Alumno.TipoDoc = new TipoDocumento();
                plan.Alumno.TipoDoc.IdTipoDoc = (int)row["TipoDocAl"];
                listplan.Add(plan);
            }
            return listplan;
        }
    }
}
