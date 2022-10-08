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
    public partial class frmLocalidadAM : Form
    {
        private string Accion;
        public frmLocalidadAM(string MiAccion)
        {
            InitializeComponent();
            Accion = MiAccion;
            this.Text = MiAccion;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Accion == "Alta")
            {
                Localidad loc = new Localidad();
                loc.Nombre = txtNombreLocalidad.Text.ToString();
            }
            else
            {

            }
        }
    }
}