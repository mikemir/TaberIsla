namespace Depcom.TaberIsla.WinForm.Formularios
{
    partial class FrmListNaufragos
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
            this.dgvNaufragos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNaufragos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNaufragos
            // 
            this.dgvNaufragos.AllowUserToAddRows = false;
            this.dgvNaufragos.AllowUserToDeleteRows = false;
            this.dgvNaufragos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNaufragos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvNaufragos.Location = new System.Drawing.Point(0, 0);
            this.dgvNaufragos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvNaufragos.Name = "dgvNaufragos";
            this.dgvNaufragos.ReadOnly = true;
            this.dgvNaufragos.Size = new System.Drawing.Size(565, 472);
            this.dgvNaufragos.TabIndex = 0;
            // 
            // FrmListNaufragos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 472);
            this.Controls.Add(this.dgvNaufragos);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmListNaufragos";
            this.Text = "Naufragos";
            this.Load += new System.EventHandler(this.FrmListNaufragos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNaufragos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNaufragos;
    }
}