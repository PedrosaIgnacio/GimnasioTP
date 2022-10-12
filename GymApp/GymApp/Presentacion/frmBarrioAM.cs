﻿using GymApp.Entidades;
using GymApp.Servicios.Interfaces;
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
using GymApp.Servicios.Implementaciones;

namespace GymApp.Presentacion
{
    public partial class frmBarrioAM : Form
    {
        private string Accion;
        //private int? IdBr;
        IBarrioService Brservice = new BarrioService();
        ILocalidadService LService = new LocalidadService();
        public frmBarrioAM(string MiAccion)
        {
            InitializeComponent();
            Accion = MiAccion;
            this.Text = MiAccion;
            //if (IdBr != null)
            //{
            //    idBar = IdBr;
            //}
        }

        private void frmBarrioAM_Load(object sender, EventArgs e)
        {
            CargarCombo(cmbLocalidad, LService.RecuperarTodos());
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (Accion == "Alta")
            {
                Barrio br = new Barrio();
                br.Nombre = txtNombreBarrio.Text.ToString();
                br.Localidad = new Localidad();
                br.Localidad.IdLocalidad = (int)cmbLocalidad.SelectedValue;
                int rowsAff = Brservice.InsertarUno(br);
                if (rowsAff > 0)
                {
                    MessageBox.Show("Barrio Creado");
                }

            }
            else
            {
                Barrio br = new Barrio();
                br.Nombre = txtNombreBarrio.Text.ToString();
                br.Localidad = new Localidad();
                br.Localidad.IdLocalidad = (int)cmbLocalidad.SelectedValue;
                int rowsAff = Brservice.ActualizarBarrio(br);

            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarCombo(ComboBox combo, List<Localidad> lista) //si la lista es de tipo Localidad da error
        {
            combo.DataSource = lista;
            combo.DisplayMember = "Nombre";
            combo.ValueMember = "IdLocalidad";
            combo.SelectedIndex = -1;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }
    }
}
