namespace Depcom.TaberIsla.WinForm.Formularios
{
    partial class FrmNuevoEditarNaufrago
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtApellidos = new Depcom.TaberIsla.WinForm.Base.FlatTextBox();
            this.txtNombres = new Depcom.TaberIsla.WinForm.Base.FlatTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtObservacion = new Depcom.TaberIsla.WinForm.Base.FlatTextBox();
            this.btnCancelar = new Depcom.TaberIsla.WinForm.Base.FlatButton();
            this.btnSiguiente = new Depcom.TaberIsla.WinForm.Base.FlatButton();
            this.dtpFechaNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEdad = new Depcom.TaberIsla.WinForm.Base.FlatTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtId = new Depcom.TaberIsla.WinForm.Base.FlatTextBox();
            this.flatButton1 = new Depcom.TaberIsla.WinForm.Base.FlatButton();
            this.txtResponsable = new Depcom.TaberIsla.WinForm.Base.FlatTextBox();
            this.chkEsEspecial = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "Apellidos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nombres:";
            // 
            // txtApellidos
            // 
            this.txtApellidos.BackColor = System.Drawing.Color.Gainsboro;
            this.txtApellidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApellidos.Location = new System.Drawing.Point(114, 112);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(351, 25);
            this.txtApellidos.TabIndex = 2;
            this.txtApellidos.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Validating);
            // 
            // txtNombres
            // 
            this.txtNombres.BackColor = System.Drawing.Color.Gainsboro;
            this.txtNombres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombres.Location = new System.Drawing.Point(114, 70);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(351, 25);
            this.txtNombres.TabIndex = 1;
            this.txtNombres.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Fecha de nacimiento:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 34);
            this.label6.TabIndex = 15;
            this.label6.Text = "Observación /\r\nMedicamentos:";
            // 
            // txtObservacion
            // 
            this.txtObservacion.BackColor = System.Drawing.Color.Gainsboro;
            this.txtObservacion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtObservacion.Location = new System.Drawing.Point(114, 265);
            this.txtObservacion.Multiline = true;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.Size = new System.Drawing.Size(351, 83);
            this.txtObservacion.TabIndex = 4;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnCancelar.Location = new System.Drawing.Point(235, 368);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 35);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguiente.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSiguiente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnSiguiente.Location = new System.Drawing.Point(349, 368);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(115, 35);
            this.btnSiguiente.TabIndex = 10;
            this.btnSiguiente.Text = "SIGUIENTE";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // dtpFechaNacimiento
            // 
            this.dtpFechaNacimiento.CustomFormat = "dd-MM-yyyy";
            this.dtpFechaNacimiento.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaNacimiento.Location = new System.Drawing.Point(159, 224);
            this.dtpFechaNacimiento.Name = "dtpFechaNacimiento";
            this.dtpFechaNacimiento.Size = new System.Drawing.Size(167, 25);
            this.dtpFechaNacimiento.TabIndex = 3;
            this.dtpFechaNacimiento.Validating += new System.ComponentModel.CancelEventHandler(this.dtpFechaNacimiento_Validating);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(332, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 17;
            this.label4.Text = "Edad:";
            // 
            // txtEdad
            // 
            this.txtEdad.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txtEdad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtEdad.Location = new System.Drawing.Point(378, 224);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.ReadOnly = true;
            this.txtEdad.Size = new System.Drawing.Size(86, 25);
            this.txtEdad.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(346, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 17);
            this.label5.TabIndex = 19;
            this.label5.Text = "ID:";
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.Color.LightSteelBlue;
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtId.Location = new System.Drawing.Point(378, 31);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(87, 25);
            this.txtId.TabIndex = 18;
            // 
            // flatButton1
            // 
            this.flatButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flatButton1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flatButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.flatButton1.Location = new System.Drawing.Point(378, 180);
            this.flatButton1.Name = "flatButton1";
            this.flatButton1.Size = new System.Drawing.Size(87, 25);
            this.flatButton1.TabIndex = 20;
            this.flatButton1.Text = "Responsable";
            this.flatButton1.UseVisualStyleBackColor = true;
            // 
            // txtResponsable
            // 
            this.txtResponsable.BackColor = System.Drawing.Color.Thistle;
            this.txtResponsable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtResponsable.Location = new System.Drawing.Point(114, 180);
            this.txtResponsable.Name = "txtResponsable";
            this.txtResponsable.ReadOnly = true;
            this.txtResponsable.Size = new System.Drawing.Size(265, 25);
            this.txtResponsable.TabIndex = 21;
            // 
            // chkEsEspecial
            // 
            this.chkEsEspecial.AutoSize = true;
            this.chkEsEspecial.Location = new System.Drawing.Point(327, 148);
            this.chkEsEspecial.Name = "chkEsEspecial";
            this.chkEsEspecial.Size = new System.Drawing.Size(137, 21);
            this.chkEsEspecial.TabIndex = 22;
            this.chkEsEspecial.Text = "Educación especial";
            this.chkEsEspecial.UseVisualStyleBackColor = true;
            // 
            // FrmNuevoEditarNaufrago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 434);
            this.Controls.Add(this.chkEsEspecial);
            this.Controls.Add(this.txtResponsable);
            this.Controls.Add(this.flatButton1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.dtpFechaNacimiento);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtObservacion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtNombres);
            this.Name = "FrmNuevoEditarNaufrago";
            this.Text = "Creación de Naufrago";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmNuevoEditarNaufrago_FormClosing);
            this.Load += new System.EventHandler(this.FrmNuevoEditarNaufrago_Load);
            this.Controls.SetChildIndex(this.txtNombres, 0);
            this.Controls.SetChildIndex(this.txtApellidos, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtObservacion, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.btnSiguiente, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.dtpFechaNacimiento, 0);
            this.Controls.SetChildIndex(this.txtEdad, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtId, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.flatButton1, 0);
            this.Controls.SetChildIndex(this.txtResponsable, 0);
            this.Controls.SetChildIndex(this.chkEsEspecial, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Base.FlatTextBox txtApellidos;
        private Base.FlatTextBox txtNombres;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private Base.FlatTextBox txtObservacion;
        private Base.FlatButton btnCancelar;
        private Base.FlatButton btnSiguiente;
        private System.Windows.Forms.DateTimePicker dtpFechaNacimiento;
        private System.Windows.Forms.Label label4;
        private Base.FlatTextBox txtEdad;
        private System.Windows.Forms.Label label5;
        private Base.FlatTextBox txtId;
        private Base.FlatButton flatButton1;
        private Base.FlatTextBox txtResponsable;
        private System.Windows.Forms.CheckBox chkEsEspecial;
    }
}