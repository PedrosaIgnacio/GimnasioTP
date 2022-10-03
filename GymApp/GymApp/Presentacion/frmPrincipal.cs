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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void soporteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ejerciciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEjercicios frmEjercicios = new frmEjercicios();
            frmEjercicios.Show();
            this.Hide();
        }

        private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuarios frmUsuario = new frmUsuarios();
            frmUsuario.Show();
            this.Hide();
        }

        private void grupoMuscularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGrupoMuscular frmGrupoMuscular = new frmGrupoMuscular();
            frmGrupoMuscular.Show();
            this.Hide();
        }
    }
}
