using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp.Entidades
{
    internal class Alumno
    {
        public int NroDocumento { get; set; }
        public int TipoDoc { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public int Telefono { get; set; }
        public string Email { get; set; }
        public int TelefonoEmergencia { get; set; }
        public int Numero { get; set; }
        public string Calle { get; set; }
        public int Barrio { get; set; }

    }
}
