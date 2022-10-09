using GymApp.Entidades;
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
    public partial class frmBarrioAM : Form
    {
        private string Accion;
        
        public frmBarrioAM(string MiAccion)
        {
            InitializeComponent();
            Accion = MiAccion;
            this.Text = MiAccion;
        }

        private void frmBarrioAM_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Accion == "Alta")
            {
                Barrio br = new Barrio();
                br.Nombre = txtNombreBarrio.Text.ToString();
                br.Localidad = new Localidad();
                br.Localidad.IdLocalidad = (int)cmbLocalidad.SelectedValue;
                //ACA FALTA

            }
            else
            {
                Barrio br = new Barrio();
                br.Nombre = txtNombreBarrio.Text.ToString();
                br.Localidad = new Localidad();
                br.Localidad.IdLocalidad = (int)cmbLocalidad.SelectedValue;
                //ACA FALTA
            }
        }
    }
}
