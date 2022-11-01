﻿using GymApp.Datos.Interfaces;
using GymApp.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GymApp.Datos.DAOs
{
    class LocalidadDao : ILocalidad
    {
        public List<Localidad> RecuperarFiltrados(string Nombre)
        {
            string consulta = "SELECT * FROM Localidad";
            if (Nombre == "")
            {
                consulta = "SELECT * FROM Localidad";

            }
            else
            {
                consulta = consulta + " WHERE Nombre LIKE '%" + Nombre + "%'";
            }

            return MapToListLocalidad(DBHelper.obtenerInstancia().consultar(consulta));
        }

        private List<Localidad> MapToListLocalidad(DataTable tabla)
        {
            List<Localidad> lista = new List<Localidad>();
            foreach (DataRow row in tabla.Rows)
            {
                Localidad loc = new Localidad();
                loc.Nombre = row["Nombre"].ToString();
                lista.Add(loc);
            }
            return lista;
        }


        public List<Localidad> RecuperarTodos()
        {
            string consulta = "Select * from Localidad";
            return MapToListlocalidad(DBHelper.obtenerInstancia().consultar(consulta));
        }


        private List<Localidad> MapToListlocalidad(DataTable tabla)
        {
            List<Localidad> lstLocalidad = new List<Localidad>();
            foreach (DataRow row in tabla.Rows)
            {
                Localidad localidad = new Localidad();
                localidad.IdLocalidad = (int)row["IdLocalidad"];
                localidad.Nombre = row["Nombre"].ToString();
                lstLocalidad.Add(localidad);
            }
            return lstLocalidad;
        }




        //public int InsertarUno(Localidad l)
        //{
        //    string consulta = "INSERT INTO Localidad (IdLocalidad, Nombre) VALUES ('" + l.IdLocalidad + "','" + l.Nombre + ", 1)";
        //    return DBHelper.obtenerInstancia().actualizar(consulta);
        //}

        public int InsertarUno(Localidad l)
        {
<<<<<<< HEAD
            string consulta = "INSERT INTO Localidad (Nombre) VALUES ('" + l.Nombre + "')";
=======
            string consulta = "INSERT INTO Localidad  (Nombre) VALUES ( '" + l.Nombre + "')";
>>>>>>> 9b4d9ad3b890085baf7132326d80518561673868
            return DBHelper.obtenerInstancia().actualizar(consulta);
        }

        public int ActualizarLocalidad(Localidad l)
        {
<<<<<<< HEAD
            string consulta = "UPDATE Localidad SET Nombre = '" +l.Nombre +"' WHERE IdLocalidad ="+l.IdLocalidad;
=======
            string consulta = "UPDATE Localidad SET Nombre = '" + l.Nombre + "' WHERE IdLocalidad = " + l.IdLocalidad;
>>>>>>> 9b4d9ad3b890085baf7132326d80518561673868
            return DBHelper.obtenerInstancia().actualizar(consulta);
        }

        public Localidad RecuperarUno(int Id)
        {
            string consulta = "SELECT l.Nombre,l.IdLocalidad FROM Localidad l WHERE l.IdLocalidad = " + Id;
            return MapToObjetoEjercicio(DBHelper.obtenerInstancia().consultar(consulta));
        }


        public Localidad MapToObjetoEjercicio(DataTable tabla)
        {
            Localidad localidad = new Localidad();
            localidad.IdLocalidad = (int)tabla.Rows[0]["IdLocalidad"];
            localidad.Nombre = tabla.Rows[0]["Nombre"].ToString();

            return localidad;
        }
    }
}
   