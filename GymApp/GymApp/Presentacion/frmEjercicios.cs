﻿using GymApp.Entidades;
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
    public partial class frmEjercicios : Form
    {
        GrupoMuscularService GMservice = new GrupoMuscularService();
        EjercicioService EJservice = new EjercicioService();
        public frmEjercicios()
        {
            InitializeComponent();
        }

        private void frmEjercicios_Load(object sender, EventArgs e)
        {
            CargarCombo(cmbGrupoMuscular, GMservice.RecuperarTodos());
        }
        private void CargarCombo(ComboBox combo, List<GrupoMuscular> lista)
        {
            combo.DataSource = lista;
            combo.DisplayMember = "Nombre";
            combo.ValueMember = "IdGM";
            combo.SelectedIndex = -1;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (txtNombreEjercicio.Text == "" && cmbGrupoMuscular.SelectedIndex == -1)
            {
                CargarGrilla(grdEjercicio, EJservice.RecuperarTodos());
            }
            else
            {
                if (cmbGrupoMuscular.SelectedValue != null)
                {
                    CargarGrilla(grdEjercicio, EJservice.RecuperarFiltrados(txtNombreEjercicio.Text, (int)cmbGrupoMuscular.SelectedValue));
                }
                else
                {
                    // Aca se llama a cargar grilla con filtros donde si el usuario no selecciona algun opcion se pasa null.
                    CargarGrilla(grdEjercicio, EJservice.RecuperarFiltrados(txtNombreEjercicio.Text, null));
                }
            }
        }

        public void CargarGrilla(DataGridView grilla, List<Ejercicio> lista)
        {
            grilla.Rows.Clear();
            for (int i = 0; i < lista.Count; i++)
            {
                grilla.Rows.Add(
                    lista[i].IdEJ,
                    lista[i].Nombre,
                    lista[i].GrupoMuscular.Nombre
                    ) ;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLimpiarFiltros_Click(object sender, EventArgs e)
        {
            cmbGrupoMuscular.SelectedIndex = -1;
            txtNombreEjercicio.Text = "";
            List<Ejercicio> lstej = new List<Ejercicio>();
            CargarGrilla(grdEjercicio, lstej);
            txtNombreEjercicio.Focus();
        }
    }
}