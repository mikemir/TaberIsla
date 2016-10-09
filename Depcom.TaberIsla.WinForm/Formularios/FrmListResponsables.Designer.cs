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
            this.colID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDUI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelefono1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTelefono2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDireccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResponsables)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvResponsables
            // 
            this.dgvResponsables.AllowUserToAddRows = false;
            this.dgvResponsables.AllowUserToDeleteRows = false;
            this.dgvResponsables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResponsables.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colID,
            this.colDUI,
            this.colNombres,
            this.colApellidos,
            this.colTelefono1,
            this.colTelefono2,
            this.colDireccion});
            this.dgvResponsables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvResponsables.Location = new System.Drawing.Point(0, 10);
            this.dgvResponsables.Name = "dgvResponsables";
            this.dgvResponsables.ReadOnly = true;
            this.dgvResponsables.RowHeadersVisible = false;
            this.dgvResponsables.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvResponsables.Size = new System.Drawing.Size(734, 436);
            this.dgvResponsables.TabIndex = 0;
            // 
            // colID
            // 
            this.colID.DataPropertyName = "Id";
            this.colID.HeaderText = "ID";
            this.colID.Name = "colID";
            this.colID.ReadOnly = true;
            this.colID.Visible = false;
            // 
            // colDUI
            // 
            this.colDUI.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colDUI.DataPropertyName = "Dui";
            this.colDUI.HeaderText = "DUI";
            this.colDUI.Name = "colDUI";
            this.colDUI.ReadOnly = true;
            // 
            // colNombres
            // 
            this.colNombres.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNombres.DataPropertyName = "Nombres";
            this.colNombres.HeaderText = "Nombes";
            this.colNombres.Name = "colNombres";
            this.colNombres.ReadOnly = true;
            // 
            // colApellidos
            // 
            this.colApellidos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colApellidos.DataPropertyName = "Apellidos";
            this.colApellidos.HeaderText = "Apellidos";
            this.colApellidos.Name = "colApellidos";
            this.colApellidos.ReadOnly = true;
            // 
            // colTelefono1
            // 
            this.colTelefono1.DataPropertyName = "Telefono1";
            this.colTelefono1.HeaderText = "Telefono 1";
            this.colTelefono1.Name = "colTelefono1";
            this.colTelefono1.ReadOnly = true;
            // 
            // colTelefono2
            // 
            this.colTelefono2.DataPropertyName = "Telefono2";
            this.colTelefono2.HeaderText = "Telefono 2";
            this.colTelefono2.Name = "colTelefono2";
            this.colTelefono2.ReadOnly = true;
            // 
            // colDireccion
            // 
            this.colDireccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.colDireccion.DataPropertyName = "Direccion";
            this.colDireccion.HeaderText = "Dirección";
            this.colDireccion.Name = "colDireccion";
            this.colDireccion.ReadOnly = true;
            this.colDireccion.Width = 87;
            // 
            // FrmListResponsables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.dgvResponsables);
            this.Name = "FrmListResponsables";
            this.Text = "Responsables";
            this.Load += new System.EventHandler(this.FrmListResponsables_Load);
            this.Controls.SetChildIndex(this.dgvResponsables, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvResponsables)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvResponsables;
        private System.Windows.Forms.DataGridViewTextBoxColumn colID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDUI;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelefono1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTelefono2;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDireccion;
    }
}