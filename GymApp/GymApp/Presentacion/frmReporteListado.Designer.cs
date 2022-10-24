namespace GymApp.Presentacion
{
    partial class frmReporteListado
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.rpvPlan = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnListo = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.gbxMes = new System.Windows.Forms.GroupBox();
            this.cmbMes = new System.Windows.Forms.ComboBox();
            this.lblMes = new System.Windows.Forms.Label();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.dsListadoPlanes = new GymApp.Reportes.dsListadoPlanes();
            this.dTPlanesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gbxMes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsListadoPlanes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTPlanesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // rpvPlan
            // 
            this.rpvPlan.LocalReport.ReportEmbeddedResource = "GymApp.Reportes.rptListadoPlan.rdlc";
            this.rpvPlan.Location = new System.Drawing.Point(12, 113);
            this.rpvPlan.Name = "rpvPlan";
            this.rpvPlan.ServerReport.BearerToken = null;
            this.rpvPlan.Size = new System.Drawing.Size(776, 415);
            this.rpvPlan.TabIndex = 0;
            // 
            // btnListo
            // 
            this.btnListo.Location = new System.Drawing.Point(628, 534);
            this.btnListo.Name = "btnListo";
            this.btnListo.Size = new System.Drawing.Size(147, 37);
            this.btnListo.TabIndex = 1;
            this.btnListo.Text = "Listo";
            this.btnListo.UseVisualStyleBackColor = true;
            this.btnListo.Click += new System.EventHandler(this.btnListo_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("MS Reference Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(178, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(374, 24);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Generar listado de planes por mes";
            this.lblTitulo.Click += new System.EventHandler(this.lblTitulo_Click);
            // 
            // gbxMes
            // 
            this.gbxMes.Controls.Add(this.btnConsultar);
            this.gbxMes.Controls.Add(this.cmbMes);
            this.gbxMes.Controls.Add(this.lblMes);
            this.gbxMes.Location = new System.Drawing.Point(182, 47);
            this.gbxMes.Name = "gbxMes";
            this.gbxMes.Size = new System.Drawing.Size(370, 46);
            this.gbxMes.TabIndex = 3;
            this.gbxMes.TabStop = false;
            this.gbxMes.Text = "Mes";
            // 
            // cmbMes
            // 
            this.cmbMes.FormattingEnabled = true;
            this.cmbMes.Location = new System.Drawing.Point(130, 15);
            this.cmbMes.Name = "cmbMes";
            this.cmbMes.Size = new System.Drawing.Size(121, 21);
            this.cmbMes.TabIndex = 1;
            // 
            // lblMes
            // 
            this.lblMes.AutoSize = true;
            this.lblMes.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMes.Location = new System.Drawing.Point(38, 16);
            this.lblMes.Name = "lblMes";
            this.lblMes.Size = new System.Drawing.Size(39, 16);
            this.lblMes.TabIndex = 0;
            this.lblMes.Text = "Mes:";
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(281, 15);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(70, 21);
            this.btnConsultar.TabIndex = 2;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // dsListadoPlanes
            // 
            this.dsListadoPlanes.DataSetName = "dsListadoPlanes";
            this.dsListadoPlanes.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dTPlanesBindingSource
            // 
            this.dTPlanesBindingSource.DataMember = "DTPlanes";
            this.dTPlanesBindingSource.DataSource = this.dsListadoPlanes;
            // 
            // frmReporteListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 583);
            this.Controls.Add(this.gbxMes);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnListo);
            this.Controls.Add(this.rpvPlan);
            this.Name = "frmReporteListado";
            this.Text = "Listado de planes";
            this.Load += new System.EventHandler(this.frmReporteListado_Load);
            this.gbxMes.ResumeLayout(false);
            this.gbxMes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dsListadoPlanes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dTPlanesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rpvPlan;
        private System.Windows.Forms.Button btnListo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox gbxMes;
        private System.Windows.Forms.Label lblMes;
        private System.Windows.Forms.ComboBox cmbMes;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.BindingSource dTPlanesBindingSource;
        private Reportes.dsListadoPlanes dsListadoPlanes;
    }
}