using GymApp.Datos.Interfaces;
using GymApp.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GymApp.Datos.DAOs
{
     class LocalidadDao : ILocalidad
    {
        public List<Localidad> RecuperarFiltrados(string Nombre)
        {
            string consulta = "SELECT * FROM Localidad";
            if (Nombre == "")
            {
                 consulta = "SELECT * FROM Localidad";

            }
            else
            {
                consulta = consulta + "WHERE Nombre LIKE '%" + Nombre + "%'";
            }

            return MapToListLocalidad(DBHelper.obtenerInstancia().consultar(consulta));
        }

        private List<Localidad> MapToListLocalidad(DataTable tabla)
        {
            List<Localidad> lista = new List<Localidad>();
            foreach (DataRow row in tabla.Rows)
            {
                Localidad loc = new Localidad();
                loc.Nombre = row["Nombre"].ToString();
                lista.Add(loc);
            }
            return lista;
        }


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

        public List<Localidad> RecuperarFiltrados()
        {
            throw new NotImplementedException();
        }
    }

}
