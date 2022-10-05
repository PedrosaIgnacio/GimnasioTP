namespace GymApp.Presentacion
{
    partial class frmAlumnoAM
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblTipoDoc = new System.Windows.Forms.Label();
            this.cmbTipoDocumento = new System.Windows.Forms.ComboBox();
            this.lblNroDoc = new System.Windows.Forms.Label();
            this.txtNroDoc = new System.Windows.Forms.TextBox();
            this.lblFechaNacimiento = new System.Windows.Forms.Label();
            this.txtFechaNacimiento = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.MaskedTextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefonoEmergencia = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefonoEmergencia = new System.Windows.Forms.Label();
            this.lblCalle = new System.Windows.Forms.Label();
            this.txtNroCalle = new System.Windows.Forms.MaskedTextBox();
            this.txtCalle = new System.Windows.Forms.TextBox();
            this.lblNroCalle = new System.Windows.Forms.Label();
            this.lblBarrio = new System.Windows.Forms.Label();
            this.cmbBarrio = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(69, 16);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(50, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre: ";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(136, 18);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(174, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(69, 42);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(50, 13);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido: ";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(136, 44);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(174, 20);
            this.txtApellido.TabIndex = 3;
            // 
            // lblTipoDoc
            // 
            this.lblTipoDoc.AutoSize = true;
            this.lblTipoDoc.Location = new System.Drawing.Point(30, 70);
            this.lblTipoDoc.Name = "lblTipoDoc";
            this.lblTipoDoc.Size = new System.Drawing.Size(89, 13);
            this.lblTipoDoc.TabIndex = 4;
            this.lblTipoDoc.Text = "Tipo Documento:";
            // 
            // cmbTipoDocumento
            // 
            this.cmbTipoDocumento.FormattingEnabled = true;
            this.cmbTipoDocumento.Location = new System.Drawing.Point(137, 70);
            this.cmbTipoDocumento.Name = "cmbTipoDocumento";
            this.cmbTipoDocumento.Size = new System.Drawing.Size(173, 21);
            this.cmbTipoDocumento.TabIndex = 5;
            // 
            // lblNroDoc
            // 
            this.lblNroDoc.AutoSize = true;
            this.lblNroDoc.Location = new System.Drawing.Point(47, 100);
            this.lblNroDoc.Name = "lblNroDoc";
            this.lblNroDoc.Size = new System.Drawing.Size(70, 13);
            this.lblNroDoc.TabIndex = 6;
            this.lblNroDoc.Text = "Número Doc:";
            // 
            // txtNroDoc
            // 
            this.txtNroDoc.Location = new System.Drawing.Point(137, 97);
            this.txtNroDoc.Name = "txtNroDoc";
            this.txtNroDoc.Size = new System.Drawing.Size(174, 20);
            this.txtNroDoc.TabIndex = 7;
            // 
            // lblFechaNacimiento
            // 
            this.lblFechaNacimiento.AutoSize = true;
            this.lblFechaNacimiento.Location = new System.Drawing.Point(20, 132);
            this.lblFechaNacimiento.Name = "lblFechaNacimiento";
            this.lblFechaNacimiento.Size = new System.Drawing.Size(99, 13);
            this.lblFechaNacimiento.TabIndex = 8;
            this.lblFechaNacimiento.Text = "Fecha Nacimiento: ";
            // 
            // txtFechaNacimiento
            // 
            this.txtFechaNacimiento.Location = new System.Drawing.Point(137, 129);
            this.txtFechaNacimiento.Mask = "00/00/0000";
            this.txtFechaNacimiento.Name = "txtFechaNacimiento";
            this.txtFechaNacimiento.Size = new System.Drawing.Size(174, 20);
            this.txtFechaNacimiento.TabIndex = 9;
            this.txtFechaNacimiento.ValidatingType = typeof(System.DateTime);
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(67, 166);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(52, 13);
            this.lblTelefono.TabIndex = 10;
            this.lblTelefono.Text = "Teléfono:";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(137, 159);
            this.txtTelefono.Mask = "000-000-0000";
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(174, 20);
            this.txtTelefono.TabIndex = 12;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(82, 218);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 13;
            this.lblEmail.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(137, 211);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(174, 20);
            this.txtEmail.TabIndex = 14;
            // 
            // txtTelefonoEmergencia
            // 
            this.txtTelefonoEmergencia.Location = new System.Drawing.Point(137, 185);
            this.txtTelefonoEmergencia.Mask = "000-000-0000";
            this.txtTelefonoEmergencia.Name = "txtTelefonoEmergencia";
            this.txtTelefonoEmergencia.Size = new System.Drawing.Size(174, 20);
            this.txtTelefonoEmergencia.TabIndex = 16;
            // 
            // lblTelefonoEmergencia
            // 
            this.lblTelefonoEmergencia.AutoSize = true;
            this.lblTelefonoEmergencia.Location = new System.Drawing.Point(8, 196);
            this.lblTelefonoEmergencia.Name = "lblTelefonoEmergencia";
            this.lblTelefonoEmergencia.Size = new System.Drawing.Size(111, 13);
            this.lblTelefonoEmergencia.TabIndex = 15;
            this.lblTelefonoEmergencia.Text = "Teléfono Emergencia:";
            // 
            // lblCalle
            // 
            this.lblCalle.AutoSize = true;
            this.lblCalle.Location = new System.Drawing.Point(86, 240);
            this.lblCalle.Name = "lblCalle";
            this.lblCalle.Size = new System.Drawing.Size(33, 13);
            this.lblCalle.TabIndex = 17;
            this.lblCalle.Text = "Calle:";
            // 
            // txtNroCalle
            // 
            this.txtNroCalle.Location = new System.Drawing.Point(137, 263);
            this.txtNroCalle.Mask = "99999";
            this.txtNroCalle.Name = "txtNroCalle";
            this.txtNroCalle.Size = new System.Drawing.Size(174, 20);
            this.txtNroCalle.TabIndex = 18;
            this.txtNroCalle.ValidatingType = typeof(int);
            // 
            // txtCalle
            // 
            this.txtCalle.Location = new System.Drawing.Point(137, 237);
            this.txtCalle.Name = "txtCalle";
            this.txtCalle.Size = new System.Drawing.Size(174, 20);
            this.txtCalle.TabIndex = 19;
            // 
            // lblNroCalle
            // 
            this.lblNroCalle.AutoSize = true;
            this.lblNroCalle.Location = new System.Drawing.Point(66, 270);
            this.lblNroCalle.Name = "lblNroCalle";
            this.lblNroCalle.Size = new System.Drawing.Size(53, 13);
            this.lblNroCalle.TabIndex = 20;
            this.lblNroCalle.Text = "Nro Calle:";
            // 
            // lblBarrio
            // 
            this.lblBarrio.AutoSize = true;
            this.lblBarrio.Location = new System.Drawing.Point(80, 296);
            this.lblBarrio.Name = "lblBarrio";
            this.lblBarrio.Size = new System.Drawing.Size(37, 13);
            this.lblBarrio.TabIndex = 21;
            this.lblBarrio.Text = "Barrio:";
            // 
            // cmbBarrio
            // 
            this.cmbBarrio.FormattingEnabled = true;
            this.cmbBarrio.Location = new System.Drawing.Point(136, 293);
            this.cmbBarrio.Name = "cmbBarrio";
            this.cmbBarrio.Size = new System.Drawing.Size(174, 21);
            this.cmbBarrio.TabIndex = 22;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnAceptar);
            this.groupBox1.Controls.Add(this.lblNombre);
            this.groupBox1.Controls.Add(this.cmbBarrio);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.lblBarrio);
            this.groupBox1.Controls.Add(this.lblApellido);
            this.groupBox1.Controls.Add(this.lblNroCalle);
            this.groupBox1.Controls.Add(this.txtApellido);
            this.groupBox1.Controls.Add(this.txtCalle);
            this.groupBox1.Controls.Add(this.lblTipoDoc);
            this.groupBox1.Controls.Add(this.txtNroCalle);
            this.groupBox1.Controls.Add(this.cmbTipoDocumento);
            this.groupBox1.Controls.Add(this.lblCalle);
            this.groupBox1.Controls.Add(this.lblNroDoc);
            this.groupBox1.Controls.Add(this.txtTelefonoEmergencia);
            this.groupBox1.Controls.Add(this.txtNroDoc);
            this.groupBox1.Controls.Add(this.lblTelefonoEmergencia);
            this.groupBox1.Controls.Add(this.lblFechaNacimiento);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtFechaNacimiento);
            this.groupBox1.Controls.Add(this.lblEmail);
            this.groupBox1.Controls.Add(this.lblTelefono);
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 384);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Alumno";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(230, 338);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(80, 28);
            this.btnCancelar.TabIndex = 25;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(50, 338);
            this.btnAceptar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(80, 28);
            this.btnAceptar.TabIndex = 24;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // frmAlumnoAM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 411);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmAlumnoAM";
            this.Text = "frmAlumnoAM";
            this.Load += new System.EventHandler(this.frmAlumnoAM_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblTipoDoc;
        private System.Windows.Forms.ComboBox cmbTipoDocumento;
        private System.Windows.Forms.Label lblNroDoc;
        private System.Windows.Forms.TextBox txtNroDoc;
        private System.Windows.Forms.Label lblFechaNacimiento;
        private System.Windows.Forms.MaskedTextBox txtFechaNacimiento;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.MaskedTextBox txtTelefono;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.MaskedTextBox txtTelefonoEmergencia;
        private System.Windows.Forms.Label lblTelefonoEmergencia;
        private System.Windows.Forms.Label lblCalle;
        private System.Windows.Forms.MaskedTextBox txtNroCalle;
        private System.Windows.Forms.TextBox txtCalle;
        private System.Windows.Forms.Label lblNroCalle;
        private System.Windows.Forms.Label lblBarrio;
        private System.Windows.Forms.ComboBox cmbBarrio;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
    }
}