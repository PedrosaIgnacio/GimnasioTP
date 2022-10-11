﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp.Entidades
{
    internal class PlanGym
    {
        public int IdPlan { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public DateTime FechaDesde{ get; set; }
        public DateTime FechaHasta { get; set; }
        public DetallePlan Alumno { get; set; }
    }
}
