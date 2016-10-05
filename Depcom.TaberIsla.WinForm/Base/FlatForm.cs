using Depcom.TaberIsla.WinForm.Utils.Interfaces;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Depcom.TaberIsla.WinForm.Base
{
    public class FlatForm : Form
    {
        private Panel panelTop;
        private Panel panelBootom;
        protected TipoAcceso _tipoAcceso = TipoAcceso.Nuevo;

        public FlatForm()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelBootom = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            //
            // panelTop
            //
            this.panelTop.BackColor = System.Drawing.Color.Silver;
            this.panelTop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(484, 10);
            this.panelTop.TabIndex = 0;
            //
            // panelBootom
            //
            this.panelBootom.BackColor = System.Drawing.Color.Gray;
            this.panelBootom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBootom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBootom.Location = new System.Drawing.Point(0, 346);
            this.panelBootom.Name = "panelBootom";
            this.panelBootom.Size = new System.Drawing.Size(484, 15);
            this.panelBootom.TabIndex = 1;
            //
            // FlatForm
            //
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(484, 361);
            this.Controls.Add(this.panelBootom);
            this.Controls.Add(this.panelTop);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FlatForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
        }

    }
}
