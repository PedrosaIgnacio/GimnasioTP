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
        public frmPlanAM()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmEjercicioPlan frmEjercicioPlan = new frmEjercicioPlan();
            frmEjercicioPlan.Show();
        }
    }
}
