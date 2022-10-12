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
        private List<DetallePlanGimnasio> listaDetallePlan;    


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
        public void CargarGrilla(DataGridView grilla, List<DetallePlanGimnasio> lista)
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
            txtIdPlan.Text = plan.IdPlan.ToString();
            txtDescripcion.Text = plan.Descripcion;
            cbxAlumnos.Text = plan.Alumno.Nombre;
            txtNumeroDNI.Text = plan.Alumno.TipoDoc.Nombre;
            txtTipoDocumento.Text = plan.Alumno.NroDocumento.ToString();
            dtpDesde.Value = plan.FechaDesde;
            dtpHasta.Value = plan.FechaHasta;
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

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (miAccion == "Modificacion")
            {
                PlanGym nuevoPlan = new PlanGym();
                nuevoPlan.IdPlan = (int)idPlan;
                nuevoPlan.Descripcion = txtDescripcion.Text;
                nuevoPlan.FechaHasta = dtpHasta.Value;
                int rowsAff = svPlanGym.Modificar(nuevoPlan);
                if (rowsAff > 0)
                {
                    MessageBox.Show("Plan Actualizado");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo actualizar el plan, porfavor intentelo nuevamente");
                }
            }
        }
    }
}
