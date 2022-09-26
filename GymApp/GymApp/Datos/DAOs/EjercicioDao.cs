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
    internal class EjercicioDao : IEjercicio
    {
        public List<Ejercicio> RecuperarTodos()
        {
            string consulta = "SELECT e.IdEJ, e.Nombre, e.Descripcion, gm.IdGM, gm.Nombre as 'NombreGM', gm.Descripcion as 'DescripcionGM' FROM Ejercicio e  JOIN GrupoMuscular gm ON gm.IdGM = e.IdGM";
            return MapeoAListaDeEjercicio(DBHelper.obtenerInstancia().consultar(consulta));
        }
        public List<Ejercicio> MapeoAListaDeEjercicio(DataTable tabla)
        {
            List<Ejercicio> lstEjercicio = new List<Ejercicio>();
            foreach (DataRow row in tabla.Rows)
            {
                Ejercicio ejercicio = new Ejercicio();
                ejercicio.IdEJ = (int)row["IdEJ"];
                ejercicio.Nombre = row["Nombre"].ToString();
                ejercicio.Descripcion = row["Descripcion"].ToString();
                ejercicio.GrupoMuscular = new GrupoMuscular();
                ejercicio.GrupoMuscular.IdGM = (int)row["IdGM"];
                ejercicio.GrupoMuscular.Nombre = row["NombreGM"].ToString();
                ejercicio.GrupoMuscular.Descripcion = row["DescripcionGM"].ToString();

                lstEjercicio.Add(ejercicio);
            }
            return lstEjercicio;
        }
        public List<Ejercicio> RecuperarFiltrados(string Ejercicio, int? IdGM)
        {
            string consulta = "SELECT e.IdEJ, e.Nombre, e.Descripcion, gm.IdGM, gm.Nombre as 'NombreGM', gm.Descripcion as 'DescripcionGM' FROM Ejercicio e  JOIN GrupoMuscular gm ON gm.IdGM = e.IdGM ";
            if (Ejercicio != "" && IdGM != null)
            {
                consulta = consulta + "WHERE e.Nombre LIKE '%" + Ejercicio + "%' AND gm.IdGM =" + IdGM;
            }
            else
            {
                if (Ejercicio != "")
                {
                    consulta = consulta + "WHERE e.Nombre LIKE '%" + Ejercicio + "%'";
                }
                else
                {
                    consulta = consulta + "WHERE gm.IdGM =" + IdGM;
                }
            }
            return MapeoAListaDeEjercicio(DBHelper.obtenerInstancia().consultar(consulta));

        }
    }
}
