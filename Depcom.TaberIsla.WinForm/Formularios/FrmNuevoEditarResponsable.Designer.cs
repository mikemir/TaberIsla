﻿namespace Depcom.TaberIsla.WinForm.Formularios
{
    partial class FrmNuevoEditarResponsable
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
            this.txtDui = new Depcom.TaberIsla.WinForm.Base.FlatTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSiguiente = new Depcom.TaberIsla.WinForm.Base.FlatButton();
            this.btnCancelar = new Depcom.TaberIsla.WinForm.Base.FlatButton();
            this.txtNombres = new Depcom.TaberIsla.WinForm.Base.FlatTextBox();
            this.txtApellidos = new Depcom.TaberIsla.WinForm.Base.FlatTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTelefono1 = new Depcom.TaberIsla.WinForm.Base.FlatTextBox();
            this.txtTelefono2 = new Depcom.TaberIsla.WinForm.Base.FlatTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDireccion = new Depcom.TaberIsla.WinForm.Base.FlatTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDui
            // 
            this.txtDui.BackColor = System.Drawing.Color.Gainsboro;
            this.txtDui.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDui.Location = new System.Drawing.Point(91, 32);
            this.txtDui.MaxLength = 10;
            this.txtDui.Name = "txtDui";
            this.txtDui.Size = new System.Drawing.Size(133, 25);
            this.txtDui.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "DUI:";
            // 
            // btnSiguiente
            // 
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguiente.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnSiguiente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnSiguiente.Location = new System.Drawing.Point(358, 324);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(100, 35);
            this.btnSiguiente.TabIndex = 2;
            this.btnSiguiente.Text = "Siguiente";
            this.btnSiguiente.UseVisualStyleBackColor = true;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnCancelar.Location = new System.Drawing.Point(242, 324);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 35);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtNombres
            // 
            this.txtNombres.BackColor = System.Drawing.Color.Gainsboro;
            this.txtNombres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombres.Location = new System.Drawing.Point(91, 76);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(367, 25);
            this.txtNombres.TabIndex = 4;
            // 
            // txtApellidos
            // 
            this.txtApellidos.BackColor = System.Drawing.Color.Gainsboro;
            this.txtApellidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtApellidos.Location = new System.Drawing.Point(91, 120);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(367, 25);
            this.txtApellidos.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Nombres:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Apellidos:";
            // 
            // txtTelefono1
            // 
            this.txtTelefono1.BackColor = System.Drawing.Color.Gainsboro;
            this.txtTelefono1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefono1.Location = new System.Drawing.Point(91, 168);
            this.txtTelefono1.Name = "txtTelefono1";
            this.txtTelefono1.Size = new System.Drawing.Size(133, 25);
            this.txtTelefono1.TabIndex = 8;
            // 
            // txtTelefono2
            // 
            this.txtTelefono2.BackColor = System.Drawing.Color.Gainsboro;
            this.txtTelefono2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTelefono2.Location = new System.Drawing.Point(331, 168);
            this.txtTelefono2.Name = "txtTelefono2";
            this.txtTelefono2.Size = new System.Drawing.Size(127, 25);
            this.txtTelefono2.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 170);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Telefono 1:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(253, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Telefono 2:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.Color.Gainsboro;
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDireccion.Location = new System.Drawing.Point(91, 215);
            this.txtDireccion.Multiline = true;
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(367, 83);
            this.txtDireccion.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 217);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Dirección:";
            // 
            // FrmNuevoEditarResponsable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 399);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTelefono2);
            this.Controls.Add(this.txtTelefono1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtApellidos);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDui);
            this.Name = "FrmNuevoEditarResponsable";
            this.Text = "Creación de responsable";
            this.Controls.SetChildIndex(this.txtDui, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.btnSiguiente, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.txtNombres, 0);
            this.Controls.SetChildIndex(this.txtApellidos, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtTelefono1, 0);
            this.Controls.SetChildIndex(this.txtTelefono2, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txtDireccion, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Base.FlatTextBox txtDui;
        private System.Windows.Forms.Label label1;
        private Base.FlatButton btnSiguiente;
        private Base.FlatButton btnCancelar;
        private Base.FlatTextBox txtNombres;
        private Base.FlatTextBox txtApellidos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Base.FlatTextBox txtTelefono1;
        private Base.FlatTextBox txtTelefono2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Base.FlatTextBox txtDireccion;
        private System.Windows.Forms.Label label6;
    }
}