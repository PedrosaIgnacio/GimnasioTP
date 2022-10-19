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
    public partial class frmPlanes : Form
    {
        ITipoDocumentoService tipoDocumentoService = new TipoDocumentoService();
        IPlanGymService svPlanGym = new PlanGymService();
        enum Acciones
        {
            Alta,
            Modificacion,
            Consulta
        }
        private Acciones miAccion;
        public frmPlanes()
        {
            InitializeComponent();
        }

        private void lblFechaHasta_Click(object sender, EventArgs e)
        {

        }

        private void lblFechaDesde_Click(object sender, EventArgs e)
        {

        }

        private void dtpHasta_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtpDesde_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            miAccion = Acciones.Alta;
            frmPlanAM frmPlanAM = new frmPlanAM(miAccion.ToString(), null);
            frmPlanAM.Show();
        }

        private void frmPlanes_Load(object sender, EventArgs e)
        {
            CargarCombo(cmbTipoDoc, tipoDocumentoService.RecuperarTodos());
        }
        private void CargarCombo(ComboBox combo, List<TipoDocumento> lista)
        {
            combo.DataSource = lista;
            combo.DisplayMember = "Nombre";
            combo.ValueMember = "IdTipoDoc";
            combo.SelectedIndex = -1;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            frmPrincipal frmPrincipal = new frmPrincipal();
            frmPrincipal.Show();
            this.Hide();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (txtNroDoc.Text == "" && cmbTipoDoc.SelectedIndex == -1)
            {
                CargarGrilla(grdPlan, svPlanGym.recuperarTodos(dtpDesde.Value.ToString("yyyy/MM/dd"), dtpHasta.Value.ToString("yyyy/MM/dd")));

            }

            else
            {
                CargarGrilla(grdPlan, svPlanGym.recuperarFiltrados(long.Parse(txtNroDoc.Text), dtpDesde.Value.ToString("yyyy/MM/dd"), dtpHasta.Value.ToString("yyyy/MM/dd")));
            }

        }
        public void CargarGrilla(DataGridView grilla, List<PlanGym> lista)
        {
            grilla.Rows.Clear();
            for (int i = 0; i < lista.Count; i++)
            {
                grilla.Rows.Add(
                    lista[i].IdPlan,
                    lista[i].Alumno.Nombre + " " + lista[i].Alumno.Apellido,
                    lista[i].FechaDesde,
                    lista[i].FechaHasta
                    );
            }

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (grdPlan.CurrentRow != null)
            {
                miAccion = Acciones.Modificacion;
                frmPlanAM frmPlanAM = new frmPlanAM(miAccion.ToString(), (int)grdPlan.CurrentRow.Cells[0].Value);
                frmPlanAM.Show();
                
            }
            else
            {

                MessageBox.Show("Error, debe elegir un Plan primero.");

            }
        }

        private void grdPlan_DoubleClick(object sender, EventArgs e)
        {
            if (grdPlan.CurrentRow != null)
            {
                miAccion = Acciones.Consulta;
                frmPlanAM frmPlanAM = new frmPlanAM(miAccion.ToString(), (int)grdPlan.CurrentRow.Cells[0].Value);
                frmPlanAM.Show();

            }
            else
            {

                MessageBox.Show("Error, debe elegir un Plan primero.");

            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Estas seguro de eliminar el Plan", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                if ((svPlanGym.DarBajaPlan((int)grdPlan.CurrentRow.Cells[0].Value)))
                {
                    MessageBox.Show("Plan eliminado con exito");
                }
                else
                {
                    MessageBox.Show("Error, no se pudo eliminar el plan");
                }
            }
        }
    }
}
