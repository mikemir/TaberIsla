namespace Depcom.TaberIsla.WinForm.Formularios
{
    partial class FrmDarBajaNaufrago
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtCorrelativo = new Depcom.TaberIsla.WinForm.Base.FlatTextBox();
            this.btnCancelar = new Depcom.TaberIsla.WinForm.Base.FlatButton();
            this.btnAceptar = new Depcom.TaberIsla.WinForm.Base.FlatButton();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "Correlativo:";
            // 
            // txtCorrelativo
            // 
            this.txtCorrelativo.BackColor = System.Drawing.Color.Gainsboro;
            this.txtCorrelativo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCorrelativo.Location = new System.Drawing.Point(133, 39);
            this.txtCorrelativo.Name = "txtCorrelativo";
            this.txtCorrelativo.Size = new System.Drawing.Size(206, 25);
            this.txtCorrelativo.TabIndex = 11;
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Gainsboro;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnCancelar.Location = new System.Drawing.Point(35, 91);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(139, 35);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Text = "CANCELAR";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAceptar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAceptar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnAceptar.Location = new System.Drawing.Point(200, 91);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(139, 35);
            this.btnAceptar.TabIndex = 13;
            this.btnAceptar.Text = "ACEPTAR";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // FrmDarBajaNaufrago
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 168);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCorrelativo);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmDarBajaNaufrago";
            this.Text = "FrmDarBajaNaufrago";
            this.Load += new System.EventHandler(this.FrmDarBajaNaufrago_Load);
            this.Controls.SetChildIndex(this.txtCorrelativo, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.btnAceptar, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private Base.FlatTextBox txtCorrelativo;
        private Base.FlatButton btnCancelar;
        private Base.FlatButton btnAceptar;
    }
}