using GymApp.Datos.Interfaces;
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
<<<<<<< HEAD
        int? idLoc;
        public frmLocalidadAM(string MiAccion, int? idLoca)
=======
        private int? IdLocalidad;

        public frmLocalidadAM(string MiAccion, int? Id)
>>>>>>> 9b4d9ad3b890085baf7132326d80518561673868
        {
            InitializeComponent();
            txtIdLocalidad.Enabled = false;
            Accion = MiAccion;
            IdLocalidad = Id;
            this.Text = MiAccion;
<<<<<<< HEAD
            if (idLoca.HasValue)
            {
                idLoc = idLoca;
=======
            if(Id != null)
            {
                IdLocalidad = Id;
>>>>>>> 9b4d9ad3b890085baf7132326d80518561673868
            }
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
                    this.Close();
                }

            }
            else
            {
                Localidad loc = new Localidad();
                loc.Nombre = txtNombreLocalidad.Text.ToString();
<<<<<<< HEAD
                loc.IdLocalidad = (int)idLoc;
                int rowsAff = Lservice.ActualizarLocalidad(loc);
                if (rowsAff > 0)
                {
                    MessageBox.Show("Localidad actualizado");
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar la Localidad");
=======
                loc.IdLocalidad = int.Parse(txtIdLocalidad.Text);
         
                int rowsAff = Lservice.ActualizarLocalidad(loc);
                if (rowsAff > 0)
                {
                    MessageBox.Show("Localidad actualizada");
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar la localidad");
>>>>>>> 9b4d9ad3b890085baf7132326d80518561673868
                }
            }
            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLocalidadAM_Load(object sender, EventArgs e)
        {
            if (Accion == "Modificacion")
            {
                CargarCampos(Lservice.RecuperarUno((int)IdLocalidad));
    
            }
        }

        private void CargarCampos(Localidad l)
        {
            txtIdLocalidad.Text = l.IdLocalidad.ToString();
            txtNombreLocalidad.Text = l.Nombre;
        }
    }
}