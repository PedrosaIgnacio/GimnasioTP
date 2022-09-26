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
    internal class GrupoMuscularDao : IGrupoMuscular
    {
        public List<GrupoMuscular> RecuperarTodos()
        {
            string consulta = "SELECT * FROM GrupoMuscular";
            return MapeoAListaDeGrupoMuscular(DBHelper.obtenerInstancia().consultar(consulta));
        }

        public List<GrupoMuscular> MapeoAListaDeGrupoMuscular(DataTable tabla)
        {
            List<GrupoMuscular> lstGrupoMuscular = new List<GrupoMuscular>();
            foreach (DataRow row in tabla.Rows)
            {
                GrupoMuscular grupoMuscular = new GrupoMuscular();
                grupoMuscular.IdGM = Convert.ToInt32(row["IdGM"]); // (int)row["ID"]
                grupoMuscular.Nombre = row["Nombre"].ToString();
                grupoMuscular.Descripcion = row["Descripcion"].ToString();
                lstGrupoMuscular.Add(grupoMuscular);
            }
            return lstGrupoMuscular;
        }
    }
}
