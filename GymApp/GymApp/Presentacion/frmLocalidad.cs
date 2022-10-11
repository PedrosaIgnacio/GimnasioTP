using GymApp.Entidades;
using GymApp.Servicios.Implementaciones;
using GymApp.Servicios.Interfaces;
using System;
using System.Collections;
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
    public partial class frmLocalidad : Form

    {
        ILocalidadService LService = new LocalidadService();
        enum Acciones
        {
            Alta,
            Modificacion
        }
        private Acciones MiAccion;
        public frmLocalidad()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (txtNombreLocalidad.Text == "")
            {
                CargarGrilla(grdLocalidad, LService.RecuperarTodos());

            }
        }

        private void CargarGrilla(DataGridView grdLocalidad, List<Localidad> lista)
        {
            grdLocalidad.Rows.Clear();
            for (int i = 0; i < lista.Count; i++)
            {
                grdLocalidad.Rows.Add(
                    lista[i].Nombre
                    );
            }
        }

        private void btnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            txtNombreLocalidad.Text = "";
            List<Localidad> listavacia = new List<Localidad>();
            CargarGrilla(grdLocalidad, listavacia);
            txtNombreLocalidad.Focus();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            MiAccion = Acciones.Alta;
            frmLocalidadAM frmLocalidad = new frmLocalidadAM(MiAccion.ToString());
            frmLocalidad.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (grdLocalidad.CurrentRow != null)
            {
                MiAccion = Acciones.Modificacion;
                frmLocalidadAM frmLocalidadAM = new frmLocalidadAM(MiAccion.ToString());
                frmLocalidadAM.Show();
            }
            else
            {
                MessageBox.Show("Error debe elegir una localidad primero.");
            }
       
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            frmPrincipal frmPrincipal = new frmPrincipal();
            frmPrincipal.Show();
            this.Hide();


        }
    }
}