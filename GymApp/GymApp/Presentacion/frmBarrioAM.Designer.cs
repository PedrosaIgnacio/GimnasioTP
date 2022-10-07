namespace GymApp.Presentacion
{
    partial class frmBarrioAM
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
            this.grbAltaBarrio = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.lblNombreEjercicios = new System.Windows.Forms.Label();
            this.lblIdEjercicio = new System.Windows.Forms.Label();
            this.txtNombreBarrio = new System.Windows.Forms.TextBox();
            this.txtIdBarrio = new System.Windows.Forms.TextBox();
            this.lblLocalidad = new System.Windows.Forms.Label();
            this.cmbLocalidad = new System.Windows.Forms.ComboBox();
            this.grbAltaBarrio.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbAltaBarrio
            // 
            this.grbAltaBarrio.Controls.Add(this.cmbLocalidad);
            this.grbAltaBarrio.Controls.Add(this.btnCancelar);
            this.grbAltaBarrio.Controls.Add(this.btnAceptar);
            this.grbAltaBarrio.Controls.Add(this.lblNombreEjercicios);
            this.grbAltaBarrio.Controls.Add(this.lblIdEjercicio);
            this.grbAltaBarrio.Controls.Add(this.txtNombreBarrio);
            this.grbAltaBarrio.Controls.Add(this.txtIdBarrio);
            this.grbAltaBarrio.Controls.Add(this.lblLocalidad);
            this.grbAltaBarrio.Location = new System.Drawing.Point(11, 31);
            this.grbAltaBarrio.Margin = new System.Windows.Forms.Padding(2);
            this.grbAltaBarrio.Name = "grbAltaBarrio";
            this.grbAltaBarrio.Padding = new System.Windows.Forms.Padding(2);
            this.grbAltaBarrio.Size = new System.Drawing.Size(407, 326);
            this.grbAltaBarrio.TabIndex = 13;
            this.grbAltaBarrio.TabStop = false;
            this.grbAltaBarrio.Text = "Barrio";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(235, 226);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(85, 28);
            this.btnCancelar.TabIndex = 12;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(110, 226);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(80, 28);
            this.btnAceptar.TabIndex = 11;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            // 
            // lblNombreEjercicios
            // 
            this.lblNombreEjercicios.AutoSize = true;
            this.lblNombreEjercicios.Location = new System.Drawing.Point(16, 76);
            this.lblNombreEjercicios.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreEjercicios.Name = "lblNombreEjercicios";
            this.lblNombreEjercicios.Size = new System.Drawing.Size(47, 13);
            this.lblNombreEjercicios.TabIndex = 2;
            this.lblNombreEjercicios.Text = "Nombre:";
            // 
            // lblIdEjercicio
            // 
            this.lblIdEjercicio.AutoSize = true;
            this.lblIdEjercicio.Location = new System.Drawing.Point(16, 37);
            this.lblIdEjercicio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblIdEjercicio.Name = "lblIdEjercicio";
            this.lblIdEjercicio.Size = new System.Drawing.Size(28, 13);
            this.lblIdEjercicio.TabIndex = 10;
            this.lblIdEjercicio.Text = "# ID";
            // 
            // txtNombreBarrio
            // 
            this.txtNombreBarrio.Location = new System.Drawing.Point(129, 73);
            this.txtNombreBarrio.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombreBarrio.Name = "txtNombreBarrio";
            this.txtNombreBarrio.Size = new System.Drawing.Size(211, 20);
            this.txtNombreBarrio.TabIndex = 1;
            // 
            // txtIdBarrio
            // 
            this.txtIdBarrio.Location = new System.Drawing.Point(129, 37);
            this.txtIdBarrio.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdBarrio.Name = "txtIdBarrio";
            this.txtIdBarrio.Size = new System.Drawing.Size(211, 20);
            this.txtIdBarrio.TabIndex = 0;
            // 
            // lblLocalidad
            // 
            this.lblLocalidad.AutoSize = true;
            this.lblLocalidad.Location = new System.Drawing.Point(16, 107);
            this.lblLocalidad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLocalidad.Name = "lblLocalidad";
            this.lblLocalidad.Size = new System.Drawing.Size(56, 13);
            this.lblLocalidad.TabIndex = 3;
            this.lblLocalidad.Text = "Localidad:";
            // 
            // cmbLocalidad
            // 
            this.cmbLocalidad.FormattingEnabled = true;
            this.cmbLocalidad.Location = new System.Drawing.Point(129, 107);
            this.cmbLocalidad.Margin = new System.Windows.Forms.Padding(2);
            this.cmbLocalidad.Name = "cmbLocalidad";
            this.cmbLocalidad.Size = new System.Drawing.Size(211, 21);
            this.cmbLocalidad.TabIndex = 13;
            // 
            // BarrioAM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 370);
            this.Controls.Add(this.grbAltaBarrio);
            this.Name = "BarrioAM";
            this.Text = "BarrioAM";
            this.Load += new System.EventHandler(this.BarrioAM_Load);
            this.grbAltaBarrio.ResumeLayout(false);
            this.grbAltaBarrio.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbAltaBarrio;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label lblNombreEjercicios;
        private System.Windows.Forms.Label lblIdEjercicio;
        private System.Windows.Forms.TextBox txtNombreBarrio;
        private System.Windows.Forms.TextBox txtIdBarrio;
        private System.Windows.Forms.Label lblLocalidad;
        private System.Windows.Forms.ComboBox cmbLocalidad;
    }
}