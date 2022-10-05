using GymApp.Datos.Interfaces;
using GymApp.Entidades;
using GymApp.Servicios;
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
    public partial class frmAlumno : Form
    {
        IAlumnoService AlService = new AlumnoService();
        enum Acciones
        {
            Alta,
            Modificacion
        }
        private Acciones MiAccion;
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
            List<Alumno> lstAl = new List<Alumno>();
            CargarGrilla(grdAlumno, lstAl);
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
                if (txtNroDni.Text == "")
                {
                    CargarGrilla(grdAlumno, AlService.RecuperarFiltrados(txtNombre.Text, null));

                }
                else
                {

                CargarGrilla(grdAlumno, AlService.RecuperarFiltrados(txtNombre.Text, int.Parse(txtNroDni.Text)));
                }

            }
        }

        private void CargarGrilla(DataGridView grdAlumno, List<Alumno> alumnos)
        {
            grdAlumno.Rows.Clear();
            for (int i = 0; i < alumnos.Count; i++)
            {
                grdAlumno.Rows.Add(
                    alumnos[i].Nombre,
                    alumnos[i].Apellido,
                    alumnos[i].FechaNacimiento,
                    alumnos[i].NroDocumento
                    );
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            frmPrincipal frmPrincipal = new frmPrincipal();
            frmPrincipal.Show();
            this.Hide();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

            MiAccion = Acciones.Alta;
            frmAlumnoAM frmAlAM = new frmAlumnoAM(MiAccion.ToString(), null);
            frmAlAM.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmAlumnoAM frmAl = new frmAlumnoAM(MiAccion.ToString(), (int)grdAlumno.CurrentRow.Cells[3].Value);
            frmAl.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }
    }
}
