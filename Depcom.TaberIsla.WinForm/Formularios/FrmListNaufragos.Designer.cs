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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvNaufragos = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCorrelativo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colApellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaNac = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colResponsable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colObservacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCrear = new Depcom.TaberIsla.WinForm.Base.FlatButton();
            this.btnEditar = new Depcom.TaberIsla.WinForm.Base.FlatButton();
            this.btnBorrar = new Depcom.TaberIsla.WinForm.Base.FlatButton();
            this.txtBusqueda = new Depcom.TaberIsla.WinForm.Base.FlatTextBox();
            this.flatButton1 = new Depcom.TaberIsla.WinForm.Base.FlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNaufragos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvNaufragos
            // 
            this.dgvNaufragos.AllowUserToAddRows = false;
            this.dgvNaufragos.AllowUserToDeleteRows = false;
            this.dgvNaufragos.AllowUserToOrderColumns = true;
            this.dgvNaufragos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvNaufragos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNaufragos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colCorrelativo,
            this.colNombres,
            this.colApellidos,
            this.colFechaNac,
            this.colResponsable,
            this.colObservacion});
            this.dgvNaufragos.Location = new System.Drawing.Point(12, 68);
            this.dgvNaufragos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvNaufragos.MultiSelect = false;
            this.dgvNaufragos.Name = "dgvNaufragos";
            this.dgvNaufragos.ReadOnly = true;
            this.dgvNaufragos.RowHeadersVisible = false;
            this.dgvNaufragos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNaufragos.Size = new System.Drawing.Size(710, 371);
            this.dgvNaufragos.TabIndex = 0;
            this.dgvNaufragos.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNaufragos_CellEnter);
            // 
            // colId
            // 
            this.colId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colId.DataPropertyName = "Id";
            this.colId.HeaderText = "ID";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Visible = false;
            this.colId.Width = 133;
            // 
            // colCorrelativo
            // 
            this.colCorrelativo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colCorrelativo.DataPropertyName = "Correlativo";
            dataGridViewCellStyle1.Format = "000";
            dataGridViewCellStyle1.NullValue = null;
            this.colCorrelativo.DefaultCellStyle = dataGridViewCellStyle1;
            this.colCorrelativo.HeaderText = "Correlativo";
            this.colCorrelativo.Name = "colCorrelativo";
            this.colCorrelativo.ReadOnly = true;
            this.colCorrelativo.Width = 80;
            // 
            // colNombres
            // 
            this.colNombres.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colNombres.DataPropertyName = "Nombres";
            this.colNombres.HeaderText = "Nombres";
            this.colNombres.Name = "colNombres";
            this.colNombres.ReadOnly = true;
            this.colNombres.Width = 180;
            // 
            // colApellidos
            // 
            this.colApellidos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colApellidos.DataPropertyName = "Apellidos";
            this.colApellidos.HeaderText = "Apellidos";
            this.colApellidos.Name = "colApellidos";
            this.colApellidos.ReadOnly = true;
            this.colApellidos.Width = 180;
            // 
            // colFechaNac
            // 
            this.colFechaNac.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colFechaNac.DataPropertyName = "FechaNacimiento";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.colFechaNac.DefaultCellStyle = dataGridViewCellStyle2;
            this.colFechaNac.HeaderText = "Fecha nac.";
            this.colFechaNac.Name = "colFechaNac";
            this.colFechaNac.ReadOnly = true;
            this.colFechaNac.Width = 90;
            // 
            // colResponsable
            // 
            this.colResponsable.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colResponsable.DataPropertyName = "Responsable.Nombres";
            this.colResponsable.HeaderText = "Responsable";
            this.colResponsable.Name = "colResponsable";
            this.colResponsable.ReadOnly = true;
            this.colResponsable.Visible = false;
            // 
            // colObservacion
            // 
            this.colObservacion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.colObservacion.DataPropertyName = "Observacion";
            this.colObservacion.HeaderText = "Observación";
            this.colObservacion.Name = "colObservacion";
            this.colObservacion.ReadOnly = true;
            this.colObservacion.Width = 210;
            // 
            // btnCrear
            // 
            this.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrear.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCrear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnCrear.Location = new System.Drawing.Point(12, 20);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(128, 35);
            this.btnCrear.TabIndex = 2;
            this.btnCrear.Text = "CREAR DUMMIE";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnEditar.Location = new System.Drawing.Point(158, 20);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(100, 35);
            this.btnEditar.TabIndex = 3;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Enabled = false;
            this.btnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnBorrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnBorrar.Location = new System.Drawing.Point(622, 20);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(100, 35);
            this.btnBorrar.TabIndex = 4;
            this.btnBorrar.Text = "BORRAR";
            this.btnBorrar.UseVisualStyleBackColor = true;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.BackColor = System.Drawing.Color.Gainsboro;
            this.txtBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBusqueda.Location = new System.Drawing.Point(296, 25);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(213, 25);
            this.txtBusqueda.TabIndex = 5;
            this.txtBusqueda.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.txtBusqueda.TextChanged += new System.EventHandler(this.txtBusqueda_TextChanged);
            // 
            // flatButton1
            // 
            this.flatButton1.Enabled = false;
            this.flatButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flatButton1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.flatButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.flatButton1.Location = new System.Drawing.Point(508, 25);
            this.flatButton1.Margin = new System.Windows.Forms.Padding(0);
            this.flatButton1.Name = "flatButton1";
            this.flatButton1.Size = new System.Drawing.Size(71, 25);
            this.flatButton1.TabIndex = 6;
            this.flatButton1.Text = "Búsqueda";
            this.flatButton1.UseVisualStyleBackColor = true;
            // 
            // FrmListNaufragos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.flatButton1);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.dgvNaufragos);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmListNaufragos";
            this.Text = "Listado de náufragos";
            this.Load += new System.EventHandler(this.FrmListNaufragos_Load);
            this.Controls.SetChildIndex(this.dgvNaufragos, 0);
            this.Controls.SetChildIndex(this.btnCrear, 0);
            this.Controls.SetChildIndex(this.btnEditar, 0);
            this.Controls.SetChildIndex(this.btnBorrar, 0);
            this.Controls.SetChildIndex(this.txtBusqueda, 0);
            this.Controls.SetChildIndex(this.flatButton1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNaufragos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNaufragos;
        private Base.FlatButton btnCrear;
        private Base.FlatButton btnEditar;
        private Base.FlatButton btnBorrar;
        private Base.FlatTextBox txtBusqueda;
        private Base.FlatButton flatButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCorrelativo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaNac;
        private System.Windows.Forms.DataGridViewTextBoxColumn colResponsable;
        private System.Windows.Forms.DataGridViewTextBoxColumn colObservacion;
    }
}