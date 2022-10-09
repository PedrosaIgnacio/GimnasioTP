using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp.Entidades
{
    public class DetallePlan
    {
        public int IdPlan { get; set; }
        public int IdEjercicio { get; set; }
        public string Repeticiones { get; set; }
        public string Series { get; set; }
    }
}
