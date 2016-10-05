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
            this.flatButton4 = new Depcom.TaberIsla.WinForm.Base.FlatButton();
            this.btnListResponsables = new Depcom.TaberIsla.WinForm.Base.FlatButton();
            this.btnListNaufragos = new Depcom.TaberIsla.WinForm.Base.FlatButton();
            this.btnNuevoResponsable = new Depcom.TaberIsla.WinForm.Base.FlatButton();
            this.lblCantidadTotal = new System.Windows.Forms.Label();
            this.lblCantidadRestante = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // flatButton4
            // 
            this.flatButton4.BackColor = System.Drawing.Color.DarkGray;
            this.flatButton4.Enabled = false;
            this.flatButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flatButton4.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.flatButton4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.flatButton4.Location = new System.Drawing.Point(434, 303);
            this.flatButton4.Name = "flatButton4";
            this.flatButton4.Size = new System.Drawing.Size(170, 47);
            this.flatButton4.TabIndex = 3;
            this.flatButton4.Text = "OPCIONES";
            this.flatButton4.UseVisualStyleBackColor = false;
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
            this.lblCantidadTotal.Location = new System.Drawing.Point(92, 393);
            this.lblCantidadTotal.Name = "lblCantidadTotal";
            this.lblCantidadTotal.Size = new System.Drawing.Size(49, 17);
            this.lblCantidadTotal.TabIndex = 4;
            this.lblCantidadTotal.Text = "ERROR";
            // 
            // lblCantidadRestante
            // 
            this.lblCantidadRestante.AutoSize = true;
            this.lblCantidadRestante.Location = new System.Drawing.Point(92, 417);
            this.lblCantidadRestante.Name = "lblCantidadRestante";
            this.lblCantidadRestante.Size = new System.Drawing.Size(49, 17);
            this.lblCantidadRestante.TabIndex = 5;
            this.lblCantidadRestante.Text = "ERROR";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 393);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "TOTAL:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 417);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "RESTANTES:";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCantidadRestante);
            this.Controls.Add(this.lblCantidadTotal);
            this.Controls.Add(this.flatButton4);
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
            this.Controls.SetChildIndex(this.flatButton4, 0);
            this.Controls.SetChildIndex(this.lblCantidadTotal, 0);
            this.Controls.SetChildIndex(this.lblCantidadRestante, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FlatButton btnNuevoResponsable;
        private FlatButton btnListNaufragos;
        private FlatButton btnListResponsables;
        private FlatButton flatButton4;
        private System.Windows.Forms.Label lblCantidadTotal;
        private System.Windows.Forms.Label lblCantidadRestante;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}