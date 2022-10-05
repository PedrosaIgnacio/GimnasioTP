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
    class BarrioDao : IBarrio
    {
        public List<Barrio> RecuperarTodos()
        {
            string consulta = "Select b.IdBarrio, b.Nombre, b.IdLocalidad, l.Nombre as NombreLocalidad from Barrio b JOIN Localidad l on l.IdLocalidad = b.IdLocalidad";
            return MapToListBarrio(DBHelper.obtenerInstancia().consultar(consulta));
        }

        private List<Barrio> MapToListBarrio(DataTable tabla)
        {
            List<Barrio> lstBarrio = new List<Barrio>();
            foreach (DataRow row in tabla.Rows)
            {
                Barrio barrio = new Barrio();
                barrio.IdBarrio = (int)row["IdBarrio"];
                barrio.Nombre = row["Nombre"].ToString();
                barrio.Localidad = new Localidad();
                barrio.Localidad.IdLocalidad = (int)row["IdLocalidad"];
                barrio.Localidad.Nombre = row["NombreLocalidad"].ToString();
                lstBarrio.Add(barrio);
            }
            return lstBarrio;
        }
    }
}
