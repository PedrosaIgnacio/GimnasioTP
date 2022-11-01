using GymApp.Datos;
using GymApp.Entidades;
using GymApp.Reportes;
using GymApp.Servicios.Implementaciones;
using GymApp.Servicios.Interfaces;
using Microsoft.Reporting.WinForms;
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
    public partial class frmReporteListado : Form
    {
        IPlanGymService svPlanGym = new PlanGymService();
        IAlumnoService AlumnoService = new AlumnoService();

        public frmReporteListado()
        {
            InitializeComponent();
        }

        //private List<Mes> crearListaMes()
        //{
        //    List<Mes> lista = new List<Mes>();
        //    string[] mes = new string[12] { "Enero", "Febero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciemrbe"};
           
        //    for (int i = 0; i < mes.Count(); i++)
        //    {
        //        Mes mes1 = new Mes();
        //        mes1.Nombre = mes[i];
        //        mes1.Numero = i+1;
        //        lista.Add(mes1);
        //    }
        //    return lista;
        //}

        private void frmReporteListado_Load(object sender, EventArgs e)
        {
            
           // cargarCombo(cmbMes, crearListaMes());
            //this.dTPlanesBindingSource.DataSource = this.dsListadoPlanes;
            //this.rpvPlan.RefreshReport();
           
           
        }

        //private void cargarCombo(ComboBox combo, List<Mes> lista)
        //{
        //    combo.DataSource = lista;
        //    combo.DisplayMember = "Nombre";
        //    combo.ValueMember = "Numero";
        //    combo.SelectedIndex = -1;
        //    combo.DropDownStyle = ComboBoxStyle.DropDownList;

        //}

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            //rpvPlan.LocalReport.SetParameters(new ReportParameter[] { new ReportParameter("MesSeleccionado", cmbMes.SelectedValue.ToString()) });
            ////DATASOURCE
            //rpvPlan.LocalReport.DataSources.Clear();
            //rpvPlan.LocalReport.DataSources.Add(new ReportDataSource("DTPlanes", DBHelper.obtenerInstancia().consultar("SELECT p.IdPlan as 'numeroPlan', p.Nombre as 'nombrePlan', a.Nombre + a.Apellido as 'nombreAlumno', p.FechaDesde, p.FechaHasta FROM PlanGim p JOIN Alumno a ON (p.NumDocAl = a.NumDoc) WHERE MONTH(p.FechaDesde) = " + (cmbMes.SelectedIndex + 1))));
            //rpvPlan.RefreshReport();
            if (txtNombreAlummno.Text == "" && txtNumeroDoc.Text == "")
            {
                this.dTPlanesBindingSource.DataSource = ( AlumnoService.RecuperarTodos());
            }
            else
            {
                if (txtNumeroDoc.Text == "")
                {
                    this.dTPlanesBindingSource.DataSource = (AlumnoService.RecuperarFiltrados(txtNombreAlummno.Text, null));

                }
                else
                {

                    this.dTPlanesBindingSource.DataSource = (AlumnoService.RecuperarFiltrados(txtNombreAlummno.Text, int.Parse(txtNumeroDoc.Text)));
                }

            }

            if (txtNombrePlan.Text == "" && txtNumeroPlann.Text == "")
            {
                this.dTPlanesBindingSource.DataSource= svPlanGym.recuperarTodos(dtpDesde.Value.ToString("yyyy/MM/dd"), dtpHasta.Value.ToString("yyyy/MM/dd"));

            }

            else
            {
                this.dTPlanesBindingSource.DataSource= svPlanGym.recuperarFiltrados(long.Parse(txtNumeroDoc.Text), dtpDesde.Value.ToString("yyyy/MM/dd"), dtpHasta.Value.ToString("yyyy/MM/dd"));
            }






        }
        private void btnListo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

      
    }
}
