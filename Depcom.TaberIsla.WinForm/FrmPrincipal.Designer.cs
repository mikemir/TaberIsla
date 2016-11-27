using Depcom.TaberIsla.WinForm.Base;

namespace Depcom.TaberIsla.WinForm
{
    partial class FrmPrincipal
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
            this.btnDarBaja = new Depcom.TaberIsla.WinForm.Base.FlatButton();
            this.btnListResponsables = new Depcom.TaberIsla.WinForm.Base.FlatButton();
            this.btnListNaufragos = new Depcom.TaberIsla.WinForm.Base.FlatButton();
            this.btnNuevoResponsable = new Depcom.TaberIsla.WinForm.Base.FlatButton();
            this.lblCantidadTotal = new System.Windows.Forms.Label();
            this.lblCantidadRestante = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnActualizar = new Depcom.TaberIsla.WinForm.Base.FlatButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblRestantesReal = new System.Windows.Forms.Label();
            this.lblTotalReal = new System.Windows.Forms.Label();
            this.btnEnviarReporte = new Depcom.TaberIsla.WinForm.Base.FlatButton();
            this.label6 = new System.Windows.Forms.Label();
            this.lblBajas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDarBaja
            // 
            this.btnDarBaja.BackColor = System.Drawing.Color.DarkGray;
            this.btnDarBaja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDarBaja.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDarBaja.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnDarBaja.Location = new System.Drawing.Point(434, 303);
            this.btnDarBaja.Name = "btnDarBaja";
            this.btnDarBaja.Size = new System.Drawing.Size(170, 47);
            this.btnDarBaja.TabIndex = 3;
            this.btnDarBaja.Text = "ENTRADA";
            this.btnDarBaja.UseVisualStyleBackColor = false;
            this.btnDarBaja.Click += new System.EventHandler(this.btnDarBaja_Click);
            // 
            // btnListResponsables
            // 
            this.btnListResponsables.BackColor = System.Drawing.Color.Gainsboro;
            this.btnListResponsables.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListResponsables.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnListResponsables.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnListResponsables.Location = new System.Drawing.Point(247, 303);
            this.btnListResponsables.Name = "btnListResponsables";
            this.btnListResponsables.Size = new System.Drawing.Size(170, 47);
            this.btnListResponsables.TabIndex = 2;
            this.btnListResponsables.Text = "RESPONSABLES";
            this.btnListResponsables.UseVisualStyleBackColor = false;
            this.btnListResponsables.Click += new System.EventHandler(this.btnListResponsables_Click);
            // 
            // btnListNaufragos
            // 
            this.btnListNaufragos.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnListNaufragos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListNaufragos.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnListNaufragos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnListNaufragos.Location = new System.Drawing.Point(434, 113);
            this.btnListNaufragos.Name = "btnListNaufragos";
            this.btnListNaufragos.Size = new System.Drawing.Size(170, 170);
            this.btnListNaufragos.TabIndex = 1;
            this.btnListNaufragos.Text = "NAUFRAGOS";
            this.btnListNaufragos.UseVisualStyleBackColor = false;
            this.btnListNaufragos.Click += new System.EventHandler(this.btnListNaufragos_Click);
            // 
            // btnNuevoResponsable
            // 
            this.btnNuevoResponsable.BackColor = System.Drawing.Color.Tomato;
            this.btnNuevoResponsable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoResponsable.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnNuevoResponsable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnNuevoResponsable.Location = new System.Drawing.Point(247, 113);
            this.btnNuevoResponsable.Name = "btnNuevoResponsable";
            this.btnNuevoResponsable.Size = new System.Drawing.Size(170, 170);
            this.btnNuevoResponsable.TabIndex = 0;
            this.btnNuevoResponsable.Text = "NUEVO RESPONSABLE";
            this.btnNuevoResponsable.UseVisualStyleBackColor = false;
            this.btnNuevoResponsable.Click += new System.EventHandler(this.btnNuevoResponsable_Click);
            // 
            // lblCantidadTotal
            // 
            this.lblCantidadTotal.AutoSize = true;
            this.lblCantidadTotal.Location = new System.Drawing.Point(822, 398);
            this.lblCantidadTotal.Name = "lblCantidadTotal";
            this.lblCantidadTotal.Size = new System.Drawing.Size(49, 17);
            this.lblCantidadTotal.TabIndex = 4;
            this.lblCantidadTotal.Text = "ERROR";
            // 
            // lblCantidadRestante
            // 
            this.lblCantidadRestante.AutoSize = true;
            this.lblCantidadRestante.Location = new System.Drawing.Point(822, 417);
            this.lblCantidadRestante.Name = "lblCantidadRestante";
            this.lblCantidadRestante.Size = new System.Drawing.Size(49, 17);
            this.lblCantidadRestante.TabIndex = 5;
            this.lblCantidadRestante.Text = "ERROR";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(738, 398);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "TOTAL:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(738, 417);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "RESTANTES:";
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnActualizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnActualizar.Location = new System.Drawing.Point(763, 25);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(109, 32);
            this.btnActualizar.TabIndex = 8;
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 417);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "RESTANTES:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 398);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "TOTAL REAL:";
            // 
            // lblRestantesReal
            // 
            this.lblRestantesReal.AutoSize = true;
            this.lblRestantesReal.Location = new System.Drawing.Point(96, 417);
            this.lblRestantesReal.Name = "lblRestantesReal";
            this.lblRestantesReal.Size = new System.Drawing.Size(49, 17);
            this.lblRestantesReal.TabIndex = 10;
            this.lblRestantesReal.Text = "ERROR";
            // 
            // lblTotalReal
            // 
            this.lblTotalReal.AutoSize = true;
            this.lblTotalReal.Location = new System.Drawing.Point(96, 398);
            this.lblTotalReal.Name = "lblTotalReal";
            this.lblTotalReal.Size = new System.Drawing.Size(49, 17);
            this.lblTotalReal.TabIndex = 9;
            this.lblTotalReal.Text = "ERROR";
            // 
            // btnEnviarReporte
            // 
            this.btnEnviarReporte.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnEnviarReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEnviarReporte.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEnviarReporte.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnEnviarReporte.Location = new System.Drawing.Point(763, 63);
            this.btnEnviarReporte.Name = "btnEnviarReporte";
            this.btnEnviarReporte.Size = new System.Drawing.Size(109, 30);
            this.btnEnviarReporte.TabIndex = 13;
            this.btnEnviarReporte.Text = "ENVIAR REPORTE";
            this.btnEnviarReporte.UseVisualStyleBackColor = false;
            this.btnEnviarReporte.Click += new System.EventHandler(this.btnEnviarReporte_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "TOTAL BAJAS:";
            // 
            // lblBajas
            // 
            this.lblBajas.AutoSize = true;
            this.lblBajas.Location = new System.Drawing.Point(96, 25);
            this.lblBajas.Name = "lblBajas";
            this.lblBajas.Size = new System.Drawing.Size(49, 17);
            this.lblBajas.TabIndex = 14;
            this.lblBajas.Text = "ERROR";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblBajas);
            this.Controls.Add(this.btnEnviarReporte);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblRestantesReal);
            this.Controls.Add(this.lblTotalReal);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCantidadRestante);
            this.Controls.Add(this.lblCantidadTotal);
            this.Controls.Add(this.btnDarBaja);
            this.Controls.Add(this.btnListResponsables);
            this.Controls.Add(this.btnListNaufragos);
            this.Controls.Add(this.btnNuevoResponsable);
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmPrincipal";
            this.Text = "DEPCOM ESTADISTICO - Taber Isla v1.0";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.Controls.SetChildIndex(this.btnNuevoResponsable, 0);
            this.Controls.SetChildIndex(this.btnListNaufragos, 0);
            this.Controls.SetChildIndex(this.btnListResponsables, 0);
            this.Controls.SetChildIndex(this.btnDarBaja, 0);
            this.Controls.SetChildIndex(this.lblCantidadTotal, 0);
            this.Controls.SetChildIndex(this.lblCantidadRestante, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.btnActualizar, 0);
            this.Controls.SetChildIndex(this.lblTotalReal, 0);
            this.Controls.SetChildIndex(this.lblRestantesReal, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.btnEnviarReporte, 0);
            this.Controls.SetChildIndex(this.lblBajas, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlatButton btnNuevoResponsable;
        private FlatButton btnListNaufragos;
        private FlatButton btnListResponsables;
        private FlatButton btnDarBaja;
        private System.Windows.Forms.Label lblCantidadTotal;
        private System.Windows.Forms.Label lblCantidadRestante;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private FlatButton btnActualizar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblRestantesReal;
        private System.Windows.Forms.Label lblTotalReal;
        private FlatButton btnEnviarReporte;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblBajas;
    }
}