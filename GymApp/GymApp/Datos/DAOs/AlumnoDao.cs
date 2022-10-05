﻿using GymApp.Datos.Interfaces;
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
                alumno.FechaNacimiento = row["FechaNacimiento"].ToString();
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
            alumno.Telefono = (int)tabla.Rows[0]["Telefono"];
            alumno.TelefonoEmergencia = (int)tabla.Rows[0]["TelefonoEmergencia"];
            alumno.Calle = tabla.Rows[0]["Calle"].ToString();
            alumno.Numero = (int)tabla.Rows[0]["Numero"];
            alumno.Barrio = new Barrio();
            alumno.Barrio.IdBarrio = (int)tabla.Rows[0]["IdBarrio"];
            alumno.Barrio.Localidad = new Localidad();
            alumno.Barrio.Localidad.IdLocalidad = (int)tabla.Rows[0]["IdLocalidad"];
            alumno.Barrio.Localidad.Nombre = tabla.Rows[0]["NombreLocalidad"].ToString();
            alumno.Barrio.Nombre = tabla.Rows[0]["NombreBarrio"].ToString();
            alumno.FechaNacimiento = tabla.Rows[0]["FechaNacimiento"].ToString();
            return alumno;
            
        }

        public int Modificar(Alumno a)
        {
          string consulta = "UPDATE Alumno SET NumDoc ='"+ a.NroDocumento + "', TipoDoc ='" + a.TipoDoc + "' ,Nombre = '" +a.Nombre +"', Apellido = ' " + a.Apellido+ "' ,FechaNacimiento = '"+a.FechaNacimiento+"',Telefono='"+ a.Telefono+"',Email='"+a.Email+"',TelefonoEmergencia='"+a.TelefonoEmergencia+"',Numero='"+a.Numero+"',Calle='"+a.Calle+"',IdBarrio='"+a.Barrio+"'";
            return DBHelper.obtenerInstancia().actualizar(consulta);
        }

        public int Insertar(Alumno a)
        {
            //string consulta = "INSERT INTO Alumno (NumDoc, TipoDoc, Nombre,Apellido,FechaNacimiento,Telefono,Email,TelefonoEmergencia,Numero,Calle,IdBarrio,IdEstado) VALUES (" + a.NroDocumento + "," + a.TipoDoc.IdTipoDoc + ",'" + a.Nombre + "','" + a.Apellido + "'," + a.FechaNacimiento + "," + a.Telefono + ",'" + a.Email + "'," + a.TelefonoEmergencia + "," + a.Numero + ",'" + a.Calle + "'," + a.Barrio.IdBarrio + ", 1)";
            string consulta = "INSERT INTO Alumno (NumDoc, TipoDoc, Nombre,Apellido,FechaNacimiento,Telefono,Email,TelefonoEmergencia,Numero,Calle,IdBarrio,IdEstado) VALUES (436939888,1,'fran' ,'men','29/10/2001',3515231232,'fran',2314412,2312,'cli',1,1)";
            return DBHelper.obtenerInstancia().actualizar(consulta);
        }
    }
}