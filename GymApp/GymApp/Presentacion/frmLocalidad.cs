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
            else
            {
                CargarGrilla(grdLocalidad, LService.RecuperarFiltrados(txtNombreLocalidad.Text));
            }

        }

        private void CargarGrilla(DataGridView grdLocalidad, List<Localidad> lista)
        {
            grdLocalidad.Rows.Clear();
            for (int i = 0; i < lista.Count; i++)
            {
                grdLocalidad.Rows.Add(
                    lista[i].IdLocalidad,
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
<<<<<<< HEAD
            
            frmLocalidadAM frmLocalidad = new frmLocalidadAM(MiAccion.ToString(), null);
=======
            frmLocalidadAM frmLocalidad = new frmLocalidadAM(MiAccion.ToString(),null);
>>>>>>> 9b4d9ad3b890085baf7132326d80518561673868
            frmLocalidad.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (grdLocalidad.CurrentRow != null)
            {
                MiAccion = Acciones.Modificacion;
<<<<<<< HEAD
                int idLocalidad = (int)grdLocalidad.CurrentRow.Cells[0].Value;
                frmLocalidadAM frmLocalidadAM = new frmLocalidadAM(MiAccion.ToString(), idLocalidad);
=======
                frmLocalidadAM frmLocalidadAM = new frmLocalidadAM(MiAccion.ToString(),(int) grdLocalidad.CurrentRow.Cells[0].Value);

>>>>>>> 9b4d9ad3b890085baf7132326d80518561673868
                frmLocalidadAM.Show();
            }
            else
            {
                MessageBox.Show("Error debe elegir una localidad primero.");
            }
       
        }



        private void btnSalir_Click(object sender, EventArgs e)
        {
            frmPrincipal frmPrincipal = new frmPrincipal();
            frmPrincipal.Show();
            this.Hide();


        }
    }
}