using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp.Entidades
{
    class Usuario
    {
        public int IdUsuario { get; set; }
        public string NombreUsuario{ get; set; }
        public string Clave { get; set; }
        public int IdTipoUsuario { get; set; }
        public int Estado { get; set; }
    }
}
