﻿using GymApp.Datos.Interfaces;
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
        private long? nroDoc;
        private string miAccion;
        public frmAlumnoAM(string MiAccion, long? documento)
        {
            InitializeComponent();
            nroDoc = documento;
            miAccion = MiAccion;
        }

        private void frmAlumnoAM_Load(object sender, EventArgs e)
        {
            CargarComboTipoDoc(cmbTipoDocumento, svTipoDocumento.RecuperarTodos());
            CargarComboBarrio(cmbBarrio, svBarrio.RecuperarTodos());
            this.Text = miAccion;
            if (miAccion == "Modificacion")
            {
                CargarCampos(svAlumno.RecuperarUno((long)nroDoc));
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
            txtDiaNacimiento.Text = alumno.DiaNacimiento.ToString();
            txtMesNacimiento.Text = alumno.MesNacimiento.ToString();
            txtAnioNacimiento.Text = alumno.AnioNacimiento.ToString();
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
            int Dia = int.Parse(txtDiaNacimiento.Text);
            if (1 <= Dia && Dia <= 31)
            {
                alumno.DiaNacimiento = Dia;
            }
            else
            {
                MessageBox.Show("Error! El dia esta fuera de rango","Error", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                this.txtDiaNacimiento.Focus();
            }

            int Mes = int.Parse(txtMesNacimiento.Text);

            if (1 <= Mes && Mes <= 12)
            {
                alumno.MesNacimiento = Mes;
            }
            else
            {
                MessageBox.Show("Error! El mes esta fuera de rango", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMesNacimiento.Focus();
            }
            int Anio = int.Parse(txtAnioNacimiento.Text);
            if (1930<=Anio && Anio < DateTime.Now.Year)
            {
                alumno.AnioNacimiento = Anio;
            }
            else
            {
                MessageBox.Show("Error! El anio esta fuera de rango", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAnioNacimiento.Focus();
            }

            alumno.NroDocumento = long.Parse(txtNroDoc.Text);
            alumno.TipoDoc = new TipoDocumento();
            alumno.TipoDoc.IdTipoDoc = (int)cmbTipoDocumento.SelectedValue;
            alumno.TipoDoc.Nombre = cmbTipoDocumento.Text;
            alumno.Nombre = txtNombre.Text;
            alumno.Apellido = txtApellido.Text;
            alumno.Telefono = long.Parse(txtTelefono.Text);
            alumno.Email = txtEmail.Text;
            alumno.TelefonoEmergencia = long.Parse(txtTelefonoEmergencia.Text);
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
                    MessageBox.Show("El Alumno: " + alumno.Nombre + " fue agregado con exito!");
                }
                else
                {
                    MessageBox.Show("Error");
                }
            }
            
            this.Close();
        }

        private void frmAlumnoAM_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void txtFechaNacimiento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtMesNacimiento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void txtAnioNacimiento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }
    }
}
