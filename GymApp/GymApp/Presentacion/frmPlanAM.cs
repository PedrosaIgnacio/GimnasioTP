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
        List<DetallePlanGimnasio> listaDP ;    


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
            listaDP = new List<DetallePlanGimnasio>();
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
                CargarCampos(svPlanGym.recuperarUno((int)idPlan));
                CargarGrilla(dgvDetallePlan, svDetallePlan.RecuperarTodos((int)idPlan));
                dgvDetallePlan.Enabled = false;
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
            frmEjercicioPlan frmEP = new frmEjercicioPlan();
            DialogResult res = frmEP.ShowDialog();
            if (frmEP.flag)
            {
                listaDP.Add(frmEP.detalle);
                CargarGrilla(dgvDetallePlan, listaDP);
            }
            
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
            if (miAccion == "Consulta")
            {
                this.Close();
            }
            else
            {
                PlanGym nuevoPlan = new PlanGym();
                nuevoPlan.Descripcion = txtDescripcion.Text;
                nuevoPlan.FechaHasta = dtpHasta.Value;
                nuevoPlan.FechaDesde = dtpDesde.Value;
                nuevoPlan.Alumno = new Alumno();
                nuevoPlan.Alumno.NroDocumento =  Int32.Parse(txtNumeroDNI.Text);
                nuevoPlan.Alumno.TipoDoc = new TipoDocumento();
                nuevoPlan.Alumno.TipoDoc.IdTipoDoc = 1;
                if (miAccion == "Modificacion")
                {
                    nuevoPlan.IdPlan = (int)idPlan;
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

                if (miAccion == "Alta")
                {
                    if (svPlanGym.InsertarPlanConDetalle(nuevoPlan, listaDP))
                    {
                        MessageBox.Show("Plan agregado con exito!");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Error, porfavor volver a reintentar");
                        this.Close();
                    }
                }
            }
        }
    }
}
