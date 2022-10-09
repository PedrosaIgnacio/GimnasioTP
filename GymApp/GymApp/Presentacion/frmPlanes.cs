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
    }
}
