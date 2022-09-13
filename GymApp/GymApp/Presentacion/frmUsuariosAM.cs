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

        private int? IdUsr;
        public frmUsuariosAM(string action, int? IdUsuario)
        {
            InitializeComponent();
            this.Text = action + " de un Usuario";
            MiAccion = action;
            if (IdUsuario != null)
            {
                IdUsr = IdUsuario;
            }
        }

        private void frmUsuariosAM_Load(object sender, EventArgs e)
        {
            txtIdUsuario.Enabled = false;
            txtNombreUsuario.Focus();
            CargarCombo(cmbTipoUsuario, TipoUsuario.RecuperarTodos());
            CargarCombo(cmbEstado, Estado.RecuperarTodos());
            if (MiAccion == "Modificacion")
            {
                DataTable usr = Usuario.RecuperarUno((int)IdUsr);
                CargarCampos(usr);
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

        private void LimpiarCampos()
        {
            txtNombreUsuario.Text = "";
            txtClave.Text = "";
            cmbEstado.SelectedIndex = -1;
            cmbTipoUsuario.SelectedIndex = -1;
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
                usuario.IdUsuario = int.Parse(txtIdUsuario.Text);
                if (Usuario.Existe(txtNombreUsuario.Text, usuario.IdUsuario))
                {
                    MessageBox.Show("El nombre de usuario ingresado ya existe, por favor intente de nuevo", "Actualizacion Completada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    LimpiarCampos();
                    return;
                }
                else
                {
                    int rowsAff = Usuario.ActualizarUsuario(usuario);
                    if (rowsAff > 0)
                    {
                        MessageBox.Show("Usuario Actualizado Con Exito", "Actualizacion Completada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar Usuario", "Actualizacion Fallida", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        Close();
                    }
                }
            }
            else
            {
                if (Usuario.Existe(txtNombreUsuario.Text, null))
                {
                    MessageBox.Show("El nombre de usuario ingresado ya existe, por favor intente de nuevo", "Actualizacion Completada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    LimpiarCampos();
                    return;
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
}
