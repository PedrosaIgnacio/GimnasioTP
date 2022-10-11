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
            frmPlanAM frmPlanAM = new frmPlanAM();
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
    }
}
