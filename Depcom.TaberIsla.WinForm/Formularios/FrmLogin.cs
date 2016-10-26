using Depcom.TaberIsla.WinForm.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Depcom.TaberIsla.WinForm.Formularios
{
    public partial class FrmLogin : FlatForm
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            var usuario = txtUsuario.Text;
            var contrasena = txtContrasena.Text;

            if(usuario == "DEPCOM" && contrasena == "Depcom2016$%")
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
