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
    internal class AlumnoDao : IAlumno
    {
        public List<Alumno> RecuperarTodos()
        {
            string consulta = "SELECT a.Nombre, a.Apellido,a.NumDoc, a.FechaNacimiento, a.Telefono, a.Email, a.TelefonoEmergencia, a.Numero, a.Calle,a.IdBarrio, t.IdTipoDoc, t.Nombre as NombreTipoDoc, b.IdBarrio, b.Nombre as NombreBarrio,b.IdLocalidad,l.Nombre as NombreLocalidad FROM TipoDocumento t  JOIN Alumno a ON t.IdTipoDoc = a.TipoDoc JOIN Barrio b ON  a.IdBarrio = b.IdBarrio JOIN Localidad l ON b.IdLocalidad = l.IdLocalidad";
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
                alumno.TipoDoc = new TipoDocumento();
                alumno.TipoDoc.IdTipoDoc = (int)row["IdTipoDoc"];
                alumno.TipoDoc.Nombre = row["NombreTipoDoc"].ToString();
                alumno.Nombre = row["Nombre"].ToString();
                alumno.Apellido = row["Apellido"].ToString();
                alumno.FechaNacimiento = (DateTime)row["FechaNacimiento"];
                alumno.Telefono = (int)row["Telefono"];
                alumno.Email = row["Email"].ToString();
                alumno.TelefonoEmergencia = (int)row["TelefonoEmergencia"];
                alumno.Numero = (int)row["Numero"];
                alumno.Calle = row["Calle"].ToString();
                alumno.Barrio = new Barrio();
                alumno.Barrio.IdBarrio = (int)row["IdBarrio"];
                alumno.Barrio.Nombre = row["NombreBarrio"].ToString();
                alumno.Barrio.Localidad = new Localidad();
                alumno.Barrio.Localidad.IdLocalidad = (int)row["IdLocalidad"];
                alumno.Barrio.Localidad.Nombre = row["NombreLocalidad"].ToString();

                listAlumno.Add(alumno);
            }
            return listAlumno;
        }

        public List<Alumno> RecuperarFiltrados(string nombre, int? dni)
        {
            string consulta = "SELECT a.Nombre, a.Apellido,a.NumDoc, a.FechaNacimiento, a.Telefono, a.Email, a.TelefonoEmergencia, a.Numero, a.Calle,a.IdBarrio, t.IdTipoDoc, t.Nombre as NombreTipoDoc, b.IdBarrio, b.Nombre as NombreBarrio,b.IdLocalidad,l.Nombre as NombreLocalidad FROM TipoDocumento t  JOIN Alumno a ON t.IdTipoDoc = a.TipoDoc JOIN Barrio b ON  a.IdBarrio = b.IdBarrio JOIN Localidad l ON b.IdLocalidad = l.IdLocalidad WHERE a.Nombre  LIKE '%" + nombre + "%'";
            if(dni != null)
            {
                consulta = consulta + " AND a.NumDoc LIKE'%" + dni + "%'";
            }
            return MapeoAListaDeAlumno(DBHelper.obtenerInstancia().consultar(consulta));
        }

        public Alumno RecuperarUno(int documento)
        {
            string consulta = "SELECT a.Nombre, a.Apellido,a.NumDoc, a.FechaNacimiento, a.Telefono, a.Email, a.TelefonoEmergencia, a.Numero, a.Calle,a.IdBarrio, t.IdTipoDoc, t.Nombre as NombreTipoDoc, b.IdBarrio, b.Nombre as NombreBarrio,b.IdLocalidad,l.Nombre as NombreLocalidad FROM TipoDocumento t  JOIN Alumno a ON t.IdTipoDoc = a.TipoDoc JOIN Barrio b ON  a.IdBarrio = b.IdBarrio JOIN Localidad l ON b.IdLocalidad = l.IdLocalidad WHERE a.NumDoc = " + documento;
            return MapeoAlumno(DBHelper.obtenerInstancia().consultar(consulta));
        }

        private Alumno MapeoAlumno(DataTable tabla)
        {
            Alumno alumno = new Alumno();
            alumno.Nombre = tabla.Rows[0]["Nombre"].ToString();
            alumno.Apellido = tabla.Rows[0]["Apellido"].ToString();
            alumno.NroDocumento = (int)tabla.Rows[0]["NumDoc"];
            alumno.Email = tabla.Rows[0]["Email"].ToString() ;
            alumno.TipoDoc = new TipoDocumento();
            alumno.TipoDoc.IdTipoDoc = (int)tabla.Rows[0]["IdTipoDoc"];
            alumno.TipoDoc.Nombre = tabla.Rows[0]["NombreTipoDoc"].ToString();
            alumno.Numero = (int)tabla.Rows[0]["Numero"];
            alumno.Telefono = (int)tabla.Rows[0]["Telefono"];
            alumno.TelefonoEmergencia = (int)tabla.Rows[0]["TelefonoEmergencia"];
            alumno.Calle = tabla.Rows[0]["Calle"].ToString();
            alumno.Barrio = new Barrio();
            alumno.Barrio.IdBarrio = (int)tabla.Rows[0]["IdBarrio"];
            alumno.Barrio.Localidad = new Localidad();
            alumno.Barrio.Localidad.IdLocalidad = (int)tabla.Rows[0]["IdLocalidad"];
            alumno.Barrio.Localidad.Nombre = tabla.Rows[0]["NombreLocalidad"].ToString();
            alumno.Barrio.Nombre = tabla.Rows[0]["NombreBarrio"].ToString();
            return alumno;
            
        }

        public int Modificar(Alumno alumno)
        {
            string consulta = "";
            return DBHelper.obtenerInstancia().actualizar(consulta);
        }
    }
}
