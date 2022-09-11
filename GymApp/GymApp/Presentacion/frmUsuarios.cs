using GymApp.Servicios;
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
    public partial class frmUsuarios : Form
    {
        UsuarioService Usuario = new UsuarioService();
        TipoUsuarioService TipoUsuario = new TipoUsuarioService();
        enum Acciones
        {
            None,
            Alta,
            Modificacion
        }

        Acciones MiAccion;

        public frmUsuarios()
        {
            InitializeComponent();
        }
        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            CargarGrilla(grdUsuarios, Usuario.RecuperarTodos());
            CargarCombo(cmbTipoUsuario, TipoUsuario.RecuperarTodos());
            txtNombreUsuario.Focus();
            MiAccion = Acciones.None;
        }

        public void CargarGrilla(DataGridView grilla, DataTable tabla)
        {
            grilla.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grilla.Rows.Add(
                    tabla.Rows[i]["IdUsuario"],
                    tabla.Rows[i]["NombreUsuario"],
                    tabla.Rows[i]["Clave"],
                    tabla.Rows[i]["Perfil"],
                    tabla.Rows[i]["Estado"]
                    );
            }
        }
        private void CargarCombo(ComboBox combo, DataTable tabla)
        {
            combo.DataSource = tabla;
            combo.DisplayMember = tabla.Columns[1].ColumnName;
            combo.ValueMember = tabla.Columns[0].ColumnName;
            combo.SelectedIndex = -1;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (cmbTipoUsuario.SelectedValue != null)
            {
                CargarGrilla(grdUsuarios, Usuario.RecuperarFiltrados(txtNombreUsuario.Text, (int)cmbTipoUsuario.SelectedValue));
            }
            else
            {
                CargarGrilla(grdUsuarios, Usuario.RecuperarFiltrados(txtNombreUsuario.Text, null));
            }
        }

        private void btnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            txtNombreUsuario.Text = "";
            cmbTipoUsuario.SelectedIndex = -1;
            CargarGrilla(grdUsuarios, Usuario.RecuperarTodos());
            txtNombreUsuario.Focus();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            MiAccion = Acciones.Alta;
            AbrirFrmUsuariosAM(MiAccion.ToString(), (int)grdUsuarios.CurrentRow.Cells[0].Value);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            MiAccion = Acciones.Modificacion;
            AbrirFrmUsuariosAM(MiAccion.ToString(), (int)grdUsuarios.CurrentRow.Cells[0].Value);
        }
        private void AbrirFrmUsuariosAM(string accion, int IdUsuario)
        {
            frmUsuariosAM FrmUsuariosAM = new frmUsuariosAM(accion, IdUsuario);
            FrmUsuariosAM.Show();
            CargarGrilla(grdUsuarios, Usuario.RecuperarTodos());
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Esta seguro de eliminar este usuario ?", "ELIMINANDO", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
            {
                Usuario.BajaLogicaUsuario((int)grdUsuarios.CurrentRow.Cells[0].Value);
                CargarGrilla(grdUsuarios, Usuario.RecuperarTodos());
            }
        }
    }
}
