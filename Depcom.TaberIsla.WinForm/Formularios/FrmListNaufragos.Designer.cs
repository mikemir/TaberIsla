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
            this.btnCrear = new Depcom.TaberIsla.WinForm.Base.FlatButton();
            this.btnEditar = new Depcom.TaberIsla.WinForm.Base.FlatButton();
            this.btnBorrar = new Depcom.TaberIsla.WinForm.Base.FlatButton();
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
            this.colResponsable});
            this.dgvNaufragos.Location = new System.Drawing.Point(12, 68);
            this.dgvNaufragos.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvNaufragos.MultiSelect = false;
            this.dgvNaufragos.Name = "dgvNaufragos";
            this.dgvNaufragos.ReadOnly = true;
            this.dgvNaufragos.RowHeadersVisible = false;
            this.dgvNaufragos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNaufragos.Size = new System.Drawing.Size(710, 371);
            this.dgvNaufragos.TabIndex = 0;
            this.dgvNaufragos.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNaufragos_CellContentDoubleClick);
            this.dgvNaufragos.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvNaufragos_CellEnter);
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            this.colId.HeaderText = "ID";
            this.colId.Name = "colId";
            this.colId.ReadOnly = true;
            this.colId.Visible = false;
            this.colId.Width = 133;
            // 
            // colCorrelativo
            // 
            this.colCorrelativo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colCorrelativo.DataPropertyName = "Correlativo";
            dataGridViewCellStyle1.Format = "000";
            dataGridViewCellStyle1.NullValue = null;
            this.colCorrelativo.DefaultCellStyle = dataGridViewCellStyle1;
            this.colCorrelativo.HeaderText = "Correlativo";
            this.colCorrelativo.Name = "colCorrelativo";
            this.colCorrelativo.ReadOnly = true;
            // 
            // colNombres
            // 
            this.colNombres.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colNombres.DataPropertyName = "Nombres";
            this.colNombres.HeaderText = "Nombres";
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
            // colFechaNac
            // 
            this.colFechaNac.DataPropertyName = "FechaNacimiento";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.colFechaNac.DefaultCellStyle = dataGridViewCellStyle2;
            this.colFechaNac.HeaderText = "Fecha nacimiento";
            this.colFechaNac.Name = "colFechaNac";
            this.colFechaNac.ReadOnly = true;
            // 
            // colResponsable
            // 
            this.colResponsable.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.colResponsable.DataPropertyName = "Responsable.Nombres";
            this.colResponsable.HeaderText = "Responsable";
            this.colResponsable.Name = "colResponsable";
            this.colResponsable.ReadOnly = true;
            // 
            // btnCrear
            // 
            this.btnCrear.Enabled = false;
            this.btnCrear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrear.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnCrear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnCrear.Location = new System.Drawing.Point(12, 20);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(100, 35);
            this.btnCrear.TabIndex = 2;
            this.btnCrear.Text = "CREAR";
            this.btnCrear.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEditar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.btnEditar.Location = new System.Drawing.Point(133, 20);
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
            // FrmListNaufragos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(734, 461);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.dgvNaufragos);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FrmListNaufragos";
            this.Text = "Naufragos";
            this.Load += new System.EventHandler(this.FrmListNaufragos_Load);
            this.Controls.SetChildIndex(this.dgvNaufragos, 0);
            this.Controls.SetChildIndex(this.btnCrear, 0);
            this.Controls.SetChildIndex(this.btnEditar, 0);
            this.Controls.SetChildIndex(this.btnBorrar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgvNaufragos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNaufragos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCorrelativo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn colApellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaNac;
        private System.Windows.Forms.DataGridViewTextBoxColumn colResponsable;
        private Base.FlatButton btnCrear;
        private Base.FlatButton btnEditar;
        private Base.FlatButton btnBorrar;
    }
}