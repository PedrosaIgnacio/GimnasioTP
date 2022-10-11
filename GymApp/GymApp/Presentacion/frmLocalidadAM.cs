using GymApp.Entidades;
using GymApp.Servicios.Implementaciones;
using GymApp.Servicios.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GymApp.Presentacion
{
    public partial class frmLocalidadAM : Form
    {

        private string Accion;
        ILocalidadService Lservice = new LocalidadService();
        public frmLocalidadAM(string MiAccion)
        {
            InitializeComponent();
            Accion = MiAccion;
            this.Text = MiAccion;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Accion == "Alta")
            {
                Localidad loc = new Localidad();
                loc.Nombre = txtNombreLocalidad.Text.ToString();
                int rowsAff = Lservice.InsertarUno(loc); 
                if (rowsAff > 0)
                {
                    MessageBox.Show("Localidad creada");
                }

            }
            else
            {
                Localidad loc = new Localidad();
                loc.Nombre = txtNombreLocalidad.Text.ToString();
                int rowsAff = Lservice.ActualizarLocalidad(loc);
                if (rowsAff > 0)
                {
                    MessageBox.Show("Ejercicio actualizado");
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el cliente");
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}