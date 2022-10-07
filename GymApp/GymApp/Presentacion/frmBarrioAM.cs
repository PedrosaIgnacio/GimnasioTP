using GymApp.Entidades;
using GymApp.Servicios;
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
    public partial class frmBarrioAM : Form
    {
        IBarrioService BRservice = new BarrioService();
       // ILocalidadService LocService = new LocalidadService();
        public frmBarrioAM()
        {
            InitializeComponent();
            txtIdBarrio.Enabled = false;
           
           // CargarCombo(cmbLocalidad, LocService.RecuperarTodos);
        }

        private void BarrioAM_Load(object sender, EventArgs e)
        {

        }
        private void CargarCombo(ComboBox combo, List<Localidad> lista)
        {
            combo.DataSource = lista;
            combo.DisplayMember = "Nombre";
            combo.ValueMember = "IdLocalidad";
            combo.SelectedIndex = -1;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
