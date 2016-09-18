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
            this.btnListResponsables.Enabled = false;
            this.btnListResponsables.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListResponsables.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnListResponsables.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnListResponsables.Location = new System.Drawing.Point(247, 303);
            this.btnListResponsables.Name = "btnListResponsables";
            this.btnListResponsables.Size = new System.Drawing.Size(170, 47);
            this.btnListResponsables.TabIndex = 2;
            this.btnListResponsables.Text = "RESPONSABLES";
            this.btnListResponsables.UseVisualStyleBackColor = false;
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
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.flatButton4);
            this.Controls.Add(this.btnListResponsables);
            this.Controls.Add(this.btnListNaufragos);
            this.Controls.Add(this.btnNuevoResponsable);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "FrmPrincipal";
            this.Text = "DEPCOM ESTADISTICO - Taber Isla v1.0";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private FlatButton btnNuevoResponsable;
        private FlatButton btnListNaufragos;
        private FlatButton btnListResponsables;
        private FlatButton flatButton4;
    }
}