using GymApp.Datos.DAOs;
using GymApp.Datos.Interfaces;
using GymApp.Entidades;
using GymApp.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp.Servicios.Implementaciones
{
    internal class PlanGymService : IPlanGymService
    {
        IPlanGym dao = new PlanGymDao(); 
        public PlanGym recuperarUno(int idPlan)
        {
            return dao.recuperarUno(idPlan);
        }
    }
}
