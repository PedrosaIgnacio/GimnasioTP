using GymApp.Entidades;
using GymApp.Servicios;
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
    public partial class frmGrupoMuscularAM : Form
    {
        private string Accion;
        private int? IdGrupoMuscular;
        IGrupoMuscularService GMservice = new GrupoMuscularService();
        public frmGrupoMuscularAM(string MiAccion, int? IdGM)
        {
            InitializeComponent();
            txtIdGrupoMuscular.Enabled = false;
            Accion = MiAccion;
            this.Text = MiAccion;
            if (IdGM != null)
            {
                IdGrupoMuscular = IdGM;
            }
        }

        private void frmGrupoMuscularAM_Load(object sender, EventArgs e)
        {
            if (Accion == "Modificacion")
            {
                CargarCampos(GMservice.RecuperarUno((int)IdGrupoMuscular));
            }
        }
        private void CargarCampos(GrupoMuscular gm)
        {
            txtIdGrupoMuscular.Text = gm.IdGM.ToString();
            txtNombreGrupoMuscular.Text = gm.Nombre;
            txtDescripcion.Text = gm.Descripcion;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            GrupoMuscular gm = new GrupoMuscular();
            gm.Nombre = txtNombreGrupoMuscular.Text;
            gm.Descripcion = txtDescripcion.Text;
            if (Accion == "Alta")
            {
                if (GMservice.AgregarGrupoMuscular(gm) == 1)
                    MessageBox.Show("Grupo Muscular: " + gm.Nombre + " agregado con exito");
                else
                    MessageBox.Show("Error, no se pudo agregar el Grupo Muscular");
            }
            else
            {
                gm.IdGM = (int)IdGrupoMuscular;
                int resultado = GMservice.ActualizarGrupoMuscular(gm);
                if (resultado == 1)
                    MessageBox.Show("Grupo Muscular: " + gm.Nombre + " actualizado con exito");
                else
                    MessageBox.Show("Error, no se pudo actualizar el Grupo Muscular");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
