using GymApp.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GymApp.Datos.DAOs
{
    internal class AlumnoDao
    {
        public List<Alumno> RecuperarTodos()
        {
            string consulta = "SELECT a.Nombre, a.Apellido, a.FechaNacimiento, a.Telefono, a.Email, a.TelefonoEmergencia, a.Numero, a.Calle,a.IdBarrio, t.IdTipoDoc, t.Nombre, b.IdBarrio, b.Nombre,b.IdLocalidad,l.Nombre FROM TipoDocumento t  JOIN Alumno a ON t.IdTipoDoc = a.TipoDoc JOIN Barrio b ON  a.IdBarrio = b.IdBarrio JOIN Localidad l ON b.IdLocalidad = l.IdLocalidad";
            return MapeoAListaDeAlumno(DBHelper.obtenerInstancia().consultar(consulta));
        }



        //MÉTODOS AUXILIARES
        public List<Alumno> MapeoAListaDeAlumno(DataTable tabla)
        {
            List<Alumno> listAlumno = new List<Alumno>();
            foreach (DataRow row in tabla.Rows)
            {
                Alumno alumno = new Alumno();
                alumno.NroDocumento = (int)row["NumDoc"];
                alumno.TipoDoc = (int)row["TipoDoc"];
                alumno.Nombre = row["Nombre"].ToString();
                alumno.Apellido = row["Apellido"].ToString(); 
                alumno.FechaNacimiento = (DateTime)row["FechaNacimiento"];
                alumno.Telefono = (int)row["Telefono"];
                alumno.Email = row["Email"].ToString();
                alumno.TelefonoEmergencia = (int)row["TelefonoEmergencia"];
                alumno.Numero = (int)row["Numero"];
                alumno.Calle = row["Calle"].ToString();
                alumno.Barrio = (int)row["IdBarrio"];

                listAlumno.Add(alumno);
            }
            return listAlumno;
        }
    }
}
