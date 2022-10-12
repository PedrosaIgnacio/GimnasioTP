using GymApp.Entidades;
using GymApp.Servicios.Implementaciones;
using GymApp.Servicios.Interfaces;
using System;
using System.Collections;
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
    public partial class frmBarrio : Form
    {
        ILocalidadService LService = new LocalidadService();
        IBarrioService BrService = new BarrioService();
        enum Acciones
        {
            Alta,
            Modificacion
        }
        private Acciones MiAccion;
        public frmBarrio()
        {
            InitializeComponent();
        }

        private void frmBarrio_Load(object sender, EventArgs e)
        {
            CargarCombo(cmbLocalidad, LService.RecuperarTodos());
        }

        private void CargarCombo(ComboBox combo, List<Localidad> lista) //si la lista es de tipo Localidad da error
        {
            combo.DataSource = lista;
            combo.DisplayMember = "Nombre";
            combo.ValueMember = "IdLocalidad";
            combo.SelectedIndex = -1;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            frmPrincipal frmPrincipal = new frmPrincipal();
            frmPrincipal.Show();
            this.Hide();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (txtNombreBarrio.Text == "" && cmbLocalidad.SelectedIndex == -1 )
            {
                CargarGrilla(grdBarrio, BrService.RecuperarTodos());
            }
            else
            {
                if (cmbLocalidad.SelectedValue != null)
                {
                    CargarGrilla(grdBarrio, BrService.RecuperarFiltrados(txtNombreBarrio.Text, (int)cmbLocalidad.SelectedValue));
                }

                else
                {
                    // Aca se llama a cargar grilla con filtros donde si el usuario no selecciona algun opcion se pasa null.
                    CargarGrilla(grdBarrio, BrService.RecuperarFiltrados(txtNombreBarrio.Text, null));
                }
            }
        }

        private void CargarGrilla(DataGridView grilla, List<Barrio> lista)
        {
            grilla.Rows.Clear();
            for (int i = 0; i < lista.Count; i++)
            {
                grilla.Rows.Add(
                    lista[i].IdBarrio,
                    lista[i].Nombre,
                    lista[i].Localidad.Nombre
                    );
            }
        }

        private void btnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            cmbLocalidad.SelectedIndex = -1;
            txtNombreBarrio.Text = "";
            List<Barrio> listavacia = new List<Barrio>();
            CargarGrilla(grdBarrio, listavacia);
            txtNombreBarrio.Focus();
            
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            MiAccion = Acciones.Alta;
            frmBarrioAM frmBarrio = new frmBarrioAM(MiAccion.ToString(), null);
            frmBarrio.Show();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (grdBarrio.CurrentRow != null)
            {
                MiAccion = Acciones.Modificacion;
                frmBarrioAM frmbarrioAM = new frmBarrioAM(MiAccion.ToString(), (int)grdBarrio.CurrentRow.Cells[0].Value);
                frmbarrioAM.Show();
            }
            else
            {
                MessageBox.Show("Error debe elegir un Barrio primero");
            }
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //if (MessageBox.Show("Está seguro de eliminar este Barrio ?", "Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            //{
            //    int rowsAff = BrService.EliminarEjercicio((int)grdBarrio.CurrentRow.Cells[0].Value);
            //    if (rowsAff > 0)
            //    {
            //        MessageBox.Show("Barrio eliminado");
            //    }
            //    else
            //    {
            //        MessageBox.Show("No se pudo eliminar el Barrio");
            //    }
                
            //    List<Barrio> lstBr = new List<Barrio>();
            //    CargarGrilla(grdBarrio, lstBr);
            //}
        }

       
    }
}
