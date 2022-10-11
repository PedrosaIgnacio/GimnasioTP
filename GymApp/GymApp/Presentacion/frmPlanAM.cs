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
        IPlanGymService svPlanGym = new PlanGymService();
        IDetallePlanService svDetallePlan = new DetallePlanService();
        private string miAccion;
        private int? idPlan;
        private List<DetallePlan> listaDetallePlan;    


        public frmPlanAM(string accion, int? plan)
        {
            InitializeComponent();
            miAccion = accion;
            this.Text = accion;
            if (plan != null)
            {
                idPlan = plan;
            }
        }
        private void frmPlanAM_Load(object sender, EventArgs e)
        {
            CargarCombo(cbxAlumnos, svAlumno.RecuperarTodos());
            txtNumeroDNI.Enabled = false;
            txtTipoDocumento.Enabled = false;
            txtIdPlan.Enabled = false;
            if (miAccion == "Modificacion")
            {
                cbxAlumnos.Enabled = false;
                dtpDesde.Enabled = false;
                CargarCampos(svPlanGym.recuperarUno((int)idPlan));
                CargarGrilla(dgvDetallePlan, svDetallePlan.RecuperarTodos((int)idPlan));
            }
            if (miAccion == "Consulta")
            {
                cbxAlumnos.Enabled = false;
                dtpDesde.Enabled = false;
                txtDescripcion.Enabled = false;
                dtpHasta.Enabled = false;
                btnAddEjercicio.Enabled = false;
            }
        }
        public void CargarGrilla(DataGridView grilla, List<DetallePlan> lista)
        {
            grilla.Rows.Clear();
            for (int i = 0; i < lista.Count; i++)
            {
                grilla.Rows.Add(
                    lista[i].Ejercicio.IdEJ,
                    lista[i].Ejercicio.Nombre,
                    lista[i].Series,
                    lista[i].Repeticiones
                    );
            }
        }

        private void CargarCampos (PlanGym plan)
        {

        }
        private void CargarCombo(ComboBox combo, List<DetallePlan> lista)
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
            var alumno = cbxAlumnos.SelectedItem as DetallePlan;
            txtNumeroDNI.Text = alumno.NroDocumento.ToString();
            txtTipoDocumento.Text = alumno.TipoDoc.Nombre;

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
