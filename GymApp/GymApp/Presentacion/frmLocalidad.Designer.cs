namespace GymApp.Presentacion
{
    partial class frmLocalidad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLocalidad));
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.grdEjercicio = new System.Windows.Forms.DataGridView();
            this.btnLimpiarFiltros = new System.Windows.Forms.Button();
            this.lblNombreEjercicio = new System.Windows.Forms.Label();
            this.txtLocalidad = new System.Windows.Forms.TextBox();
            this.ColIdLocalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNombreLocalidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdEjercicio)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.SystemColors.Window;
            this.btnEliminar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEliminar.BackgroundImage")));
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEliminar.Location = new System.Drawing.Point(171, 334);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(46, 47);
            this.btnEliminar.TabIndex = 43;
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.Window;
            this.btnSalir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSalir.BackgroundImage")));
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSalir.Location = new System.Drawing.Point(445, 334);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(46, 47);
            this.btnSalir.TabIndex = 42;
            this.btnSalir.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.SystemColors.Window;
            this.btnEditar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnEditar.BackgroundImage")));
            this.btnEditar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnEditar.Location = new System.Drawing.Point(94, 334);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(46, 47);
            this.btnEditar.TabIndex = 41;
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.SystemColors.Window;
            this.btnNuevo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNuevo.BackgroundImage")));
            this.btnNuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnNuevo.Location = new System.Drawing.Point(17, 334);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(46, 47);
            this.btnNuevo.TabIndex = 40;
            this.btnNuevo.UseVisualStyleBackColor = false;
            // 
            // btnConsultar
            // 
            this.btnConsultar.BackColor = System.Drawing.SystemColors.Window;
            this.btnConsultar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConsultar.BackgroundImage")));
            this.btnConsultar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnConsultar.Location = new System.Drawing.Point(389, 13);
            this.btnConsultar.Margin = new System.Windows.Forms.Padding(2);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(46, 47);
            this.btnConsultar.TabIndex = 38;
            this.btnConsultar.UseVisualStyleBackColor = false;
            // 
            // grdEjercicio
            // 
            this.grdEjercicio.AllowUserToAddRows = false;
            this.grdEjercicio.AllowUserToDeleteRows = false;
            this.grdEjercicio.BackgroundColor = System.Drawing.SystemColors.Control;
            this.grdEjercicio.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grdEjercicio.ColumnHeadersHeight = 30;
            this.grdEjercicio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColIdLocalidad,
            this.ColNombreLocalidad});
            this.grdEjercicio.GridColor = System.Drawing.SystemColors.Control;
            this.grdEjercicio.Location = new System.Drawing.Point(20, 100);
            this.grdEjercicio.Margin = new System.Windows.Forms.Padding(2);
            this.grdEjercicio.Name = "grdEjercicio";
            this.grdEjercicio.ReadOnly = true;
            this.grdEjercicio.RowHeadersWidth = 51;
            this.grdEjercicio.RowTemplate.Height = 24;
            this.grdEjercicio.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.grdEjercicio.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grdEjercicio.Size = new System.Drawing.Size(353, 192);
            this.grdEjercicio.TabIndex = 33;
            // 
            // btnLimpiarFiltros
            // 
            this.btnLimpiarFiltros.BackColor = System.Drawing.SystemColors.Window;
            this.btnLimpiarFiltros.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnLimpiarFiltros.BackgroundImage")));
            this.btnLimpiarFiltros.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnLimpiarFiltros.Location = new System.Drawing.Point(450, 13);
            this.btnLimpiarFiltros.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiarFiltros.Name = "btnLimpiarFiltros";
            this.btnLimpiarFiltros.Size = new System.Drawing.Size(46, 47);
            this.btnLimpiarFiltros.TabIndex = 39;
            this.btnLimpiarFiltros.UseVisualStyleBackColor = false;
            // 
            // lblNombreEjercicio
            // 
            this.lblNombreEjercicio.AutoSize = true;
            this.lblNombreEjercicio.Location = new System.Drawing.Point(18, 24);
            this.lblNombreEjercicio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreEjercicio.Name = "lblNombreEjercicio";
            this.lblNombreEjercicio.Size = new System.Drawing.Size(96, 13);
            this.lblNombreEjercicio.TabIndex = 34;
            this.lblNombreEjercicio.Text = "Nombre Localidad:";
            // 
            // txtLocalidad
            // 
            this.txtLocalidad.Location = new System.Drawing.Point(20, 40);
            this.txtLocalidad.Margin = new System.Windows.Forms.Padding(2);
            this.txtLocalidad.Name = "txtLocalidad";
            this.txtLocalidad.Size = new System.Drawing.Size(159, 20);
            this.txtLocalidad.TabIndex = 35;
            // 
            // ColIdLocalidad
            // 
            this.ColIdLocalidad.HeaderText = "# ID";
            this.ColIdLocalidad.MinimumWidth = 6;
            this.ColIdLocalidad.Name = "ColIdLocalidad";
            this.ColIdLocalidad.ReadOnly = true;
            this.ColIdLocalidad.Width = 125;
            // 
            // ColNombreLocalidad
            // 
            this.ColNombreLocalidad.HeaderText = "Nombre Localidad";
            this.ColNombreLocalidad.MinimumWidth = 6;
            this.ColNombreLocalidad.Name = "ColNombreLocalidad";
            this.ColNombreLocalidad.ReadOnly = true;
            this.ColNombreLocalidad.Width = 175;
            // 
            // frmLocalidad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 399);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.btnConsultar);
            this.Controls.Add(this.grdEjercicio);
            this.Controls.Add(this.btnLimpiarFiltros);
            this.Controls.Add(this.lblNombreEjercicio);
            this.Controls.Add(this.txtLocalidad);
            this.Name = "frmLocalidad";
            this.Text = "frmLocalidad";
            ((System.ComponentModel.ISupportInitialize)(this.grdEjercicio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DataGridView grdEjercicio;
        private System.Windows.Forms.Button btnLimpiarFiltros;
        private System.Windows.Forms.Label lblNombreEjercicio;
        private System.Windows.Forms.TextBox txtLocalidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColIdLocalidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNombreLocalidad;
    }
}