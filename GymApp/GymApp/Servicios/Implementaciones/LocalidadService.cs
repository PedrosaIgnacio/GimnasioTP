using GymApp.Datos.DAOs;
using GymApp.Datos.Interfaces;
using GymApp.Entidades;
using GymApp.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymApp.Servicios.Implementaciones
{
    class LocalidadService : ILocalidadService
    {
        private ILocalidad dao;
        public LocalidadService()
        {
            dao = new LocalidadDao();
        }
        public List<Localidad> RecuperarTodos()
        {
            return dao.RecuperarTodos();
        }
        public List<Localidad> RecuperarFiltrados(string Nombre)
        {
            return dao.RecuperarFiltrados(Nombre);
        }
        public int InsertarUno(Localidad l)
        {
            return dao.InsertarUno(l);
        }

        public int ActualizarLocalidad(Localidad l)
        {
            return dao.ActualizarLocalidad(l);
        }
        public Localidad RecuperarUno(int id)
        {
            return dao.RecuperarUno(id);
        }
    }
}
