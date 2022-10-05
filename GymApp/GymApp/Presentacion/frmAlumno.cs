using GymApp.Datos.Interfaces;
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
    public partial class frmAlumno : Form
    {
        IAlumnoService AlService = new AlumnoService();
        public frmAlumno()
        {
            InitializeComponent();
        }

        private void txtDni_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmAlumno_Load(object sender, EventArgs e)
        {

        }

        private void btnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtNroDni.Text = "";
            //Agregar limpiar grilla
            txtNombre.Focus();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" && txtNroDni.Text == "")
            {
                CargarGrilla(grdAlumno, AlService.RecuperarTodos() );
            }
            else
            {
                if (true)
                {

                }
            }
        }
    }
}
