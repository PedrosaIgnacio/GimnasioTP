﻿using GymApp.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp.Datos.Interfaces
{
    internal interface IPlanGym
    {
        PlanGym recuperarUno(int idPlan);
    }
}
