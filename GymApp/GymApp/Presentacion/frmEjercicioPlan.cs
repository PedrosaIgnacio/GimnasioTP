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
    public partial class frmEjercicioPlan : Form
    {
        IEjercicioService svEjercicioService = new EjercicioService();
        public frmEjercicioPlan()
        {
            InitializeComponent();
        }

        private void frmEjercicioPlan_Load(object sender, EventArgs e)
        {
            CargarCombo(cmbEjercicio, svEjercicioService.RecuperarTodos());
            txtGrupoMuscular.Enabled = false;
        }

        private void CargarCombo(ComboBox combo, List<Ejercicio> lista)
        {
            combo.DataSource = lista;
            combo.DisplayMember = "Nombre";
            combo.ValueMember = "IdEJ";
            combo.SelectedIndex = -1;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {

        }

        private void cmbEjercicio_SelectionChangeCommitted(object sender, EventArgs e)
        {
            var ejercicio = cmbEjercicio.SelectedItem as Ejercicio;
            txtGrupoMuscular.Text = ejercicio.GrupoMuscular.Nombre;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
