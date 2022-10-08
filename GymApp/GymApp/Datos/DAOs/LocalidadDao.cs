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
     class LocalidadDao : ILocalidad
    {
        public List<Localidad> RecuperarTodos()
        {
            string consulta = "Select * from Localidad";
            return MapToListlocalidad(DBHelper.obtenerInstancia().consultar(consulta));
        }


        private List<Localidad> MapToListlocalidad(DataTable tabla)
        {
            List<Localidad> lstLocalidad = new List<Localidad>();
            foreach (DataRow row in tabla.Rows)
            {
                Localidad localidad = new Localidad();
                localidad.IdLocalidad = (int)row["IdLocalidad"];
                localidad.Nombre = row["Nombre"].ToString();
                lstLocalidad.Add(localidad);
            }
            return lstLocalidad;
        }
    }
}
