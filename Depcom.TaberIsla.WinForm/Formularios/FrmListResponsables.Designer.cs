namespace Depcom.TaberIsla.WinForm.Formularios
{
    partial class FrmListResponsables
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
            this.dgvResponsables = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResponsables)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvResponsables
            // 
            this.dgvResponsables.AllowUserToAddRows = false;
            this.dgvResponsables.AllowUserToDeleteRows = false;
            this.dgvResponsables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResponsables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResponsables.Location = new System.Drawing.Point(0, 0);
            this.dgvResponsables.Name = "dgvResponsables";
            this.dgvResponsables.ReadOnly = true;
            this.dgvResponsables.Size = new System.Drawing.Size(484, 361);
            this.dgvResponsables.TabIndex = 0;
            // 
            // FrmListResponsables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.dgvResponsables);
            this.Name = "FrmListResponsables";
            this.Text = "Responsables";
            this.Load += new System.EventHandler(this.FrmListResponsables_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResponsables)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvResponsables;
    }
}