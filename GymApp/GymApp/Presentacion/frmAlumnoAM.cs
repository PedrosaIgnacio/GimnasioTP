using GymApp.Datos.Interfaces;
using GymApp.Entidades;
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
    public partial class frmAlumnoAM : Form
         
    {
        IAlumnoService svAlumno = new AlumnoService();
        ITipoDocumentoService svTipoDocumento = new TipoDocumentoService();
        IBarrioService svBarrio = new BarrioService();
        private int? nroDoc;
        private string miAccion;
        public frmAlumnoAM(string MiAccion, int? documento)
        {
            InitializeComponent();
            nroDoc = documento;
            miAccion = MiAccion;
        }

        private void frmAlumnoAM_Load(object sender, EventArgs e)
        {
            CargarComboTipoDoc(cmbTipoDocumento, svTipoDocumento.RecuperarTodos());
            CargarComboBarrio(cmbBarrio, svBarrio.RecuperarTodos());

            if (miAccion == "Modificacion")
            {
                CargarCampos(svAlumno.RecuperarUno((int)nroDoc));
                txtNroDoc.Enabled = false;
                cmbTipoDocumento.Enabled = false;
            }
        }

        private void CargarComboBarrio(ComboBox combo, List<Barrio> lista)
        {
            combo.DataSource = lista;
            combo.DisplayMember = "Nombre";
            combo.ValueMember = "IdBarrio";
            combo.SelectedIndex = -1;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void CargarComboTipoDoc(ComboBox combo, List<TipoDocumento> lista)
        {
            combo.DataSource = lista;
            combo.DisplayMember = "Nombre";
            combo.ValueMember = "IdTipoDoc";
            combo.SelectedIndex = -1;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public void CargarCampos(Alumno alumno)
        {
            txtNombre.Text = alumno.Nombre;
            txtApellido.Text = alumno.Apellido;
            cmbTipoDocumento.SelectedValue = alumno.TipoDoc.IdTipoDoc;
            txtNroDoc.Text = alumno.NroDocumento.ToString();
            txtFechaNacimiento.Text = alumno.FechaNacimiento.ToString();
            txtTelefono.Text = alumno.Telefono.ToString();
            txtTelefonoEmergencia.Text = alumno.TelefonoEmergencia.ToString();
            txtEmail.Text = alumno.Email;
            txtCalle.Text = alumno.Calle;
            txtNroCalle.Text = alumno.Numero.ToString();
            cmbBarrio.SelectedValue = alumno.Barrio.IdBarrio;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Alumno alumno = new Alumno();
            alumno.NroDocumento = int.Parse(txtNroDoc.Text);
            alumno.TipoDoc = new TipoDocumento();
            alumno.TipoDoc.IdTipoDoc = (int)cmbTipoDocumento.SelectedValue;
            alumno.TipoDoc.Nombre = cmbTipoDocumento.Text;
            alumno.Nombre = txtNombre.Text;
            alumno.Apellido = txtApellido.Text;
            alumno.FechaNacimiento = txtFechaNacimiento.Text;
            alumno.Telefono = int.Parse(txtTelefono.Text);
            alumno.Email = txtEmail.Text;
            alumno.TelefonoEmergencia = int.Parse(txtTelefonoEmergencia.Text);
            alumno.Numero = int.Parse(txtNroCalle.Text);
            alumno.Calle = txtCalle.Text;
            alumno.Barrio = new Barrio();
            alumno.Barrio.IdBarrio = (int)cmbBarrio.SelectedValue;
            alumno.Barrio.Nombre = cmbBarrio.Text;
            if (miAccion == "Modificacion")
            {
                int rowsAff = svAlumno.Modificar(alumno);
                if (rowsAff > 0)
                {
                    MessageBox.Show("Datos Modificados");
                }
                else
                {
                    MessageBox.Show("error");
                }
            }
            else
            {
                int rowsAff = svAlumno.Insertar(alumno);
                if (rowsAff > 0)
                {
                    MessageBox.Show("Datos Modificados");
                }
                else
                {
                    MessageBox.Show("error");
                }
            }
        }
    }
}
