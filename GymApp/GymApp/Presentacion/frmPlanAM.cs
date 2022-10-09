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
    public partial class frmPlanAM : Form
    {
        IAlumnoService svAlumno = new AlumnoService();
        public frmPlanAM()
        {
            InitializeComponent();

        }
        private void frmPlanAM_Load(object sender, EventArgs e)
        {
            CargarCombo(cbxAlumnos, svAlumno.RecuperarTodos());
            txtNumeroDNI.Enabled = false;
            txtTipoDocumento.Enabled = false;
        }

        private void CargarCombo(ComboBox combo, List<Alumno> lista)
        {
            combo.DataSource = lista;
            combo.DisplayMember = "Nombre";
            combo.ValueMember = "NroDocumento";
            combo.SelectedIndex = -1;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmEjercicioPlan frmEjercicioPlan = new frmEjercicioPlan();
            frmEjercicioPlan.Show();
        }

        private void cbxAlumnos_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var alumno = cbxAlumnos.SelectedItem as Alumno;
            txtNumeroDNI.Text = alumno.NroDocumento.ToString();
            txtTipoDocumento.Text = alumno.TipoDoc.Nombre;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
