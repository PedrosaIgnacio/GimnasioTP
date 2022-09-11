using GymApp.Entidades;
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
    public partial class frmUsuariosAM : Form
    {
        UsuarioService Usuario = new UsuarioService();
        TipoUsuarioService TipoUsuario = new TipoUsuarioService();
        EstadoService Estado = new EstadoService();

        private string MiAccion;

        private int IdUsr;

        public frmUsuariosAM(string action, int IdUsuario)
        {
            InitializeComponent();
            this.Text = action + " de un Usuario";
            MiAccion = action;
            IdUsr = IdUsuario;
        }
        private void frmUsuariosAM_Load(object sender, EventArgs e)
        {
            txtIdUsuario.Enabled = false;
            txtNombreUsuario.Focus();
            CargarCombo(cmbTipoUsuario, TipoUsuario.RecuperarTodos());
            CargarCombo(cmbEstado, Estado.RecuperarTodos());
            if (MiAccion == "Modificacion")
            {
                DataTable usrs = Usuario.RecuperarUno(IdUsr);
                CargarCampos(usrs);
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

        private void CargarCampos(DataTable usrs)
        {
            txtIdUsuario.Text = usrs.Rows[0]["IdUsuario"].ToString();
            txtNombreUsuario.Text = usrs.Rows[0]["NombreUsuario"].ToString();
            txtClave.Text = usrs.Rows[0]["Clave"].ToString();
            cmbTipoUsuario.SelectedValue = usrs.Rows[0]["Perfil"].ToString();
            cmbEstado.SelectedValue = usrs.Rows[0]["Estado"].ToString();
        }


        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            usuario.NombreUsuario = txtNombreUsuario.Text;
            usuario.Clave = txtClave.Text;
            usuario.IdTipoUsuario = (int)cmbTipoUsuario.SelectedValue;
            usuario.Estado = (int)cmbEstado.SelectedValue;


            if (MiAccion == "Modificacion")
            {
                int rowsAff = Usuario.ActualizarUsuario(usuario, IdUsr);
                if (rowsAff > 0)
                {
                    //MessageBox.Show("Usuario Actualizado Con Exito");
                    MessageBox.Show("Usuario Actualizado Con Exito", "Actualizacion Completada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("Usuario Actualizado Con Exito", "Actualizacion Completada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); Close();
                }
            }
            else
            {
                int rowsAff = Usuario.InsertarUsuario(usuario);
                if (rowsAff > 0)
                {
                    MessageBox.Show("Usuario Insertado Con Exito");
                    Close();
                }
                else
                {
                    MessageBox.Show("Se produjo un error al insertar el usuario");
                    Close();
                }
            }
        }
    }
}
