using Depcom.TaberIsla.BusinessLogic.Interfaces;
using Depcom.TaberIsla.Domain;
using Depcom.TaberIsla.WinForm.Base;
using Microsoft.Practices.Unity;
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
    public partial class FrmNuevoEditarResponsable : FlatForm
    {
        private IResponsablesBL _responsablesBl = null;

        public FrmNuevoEditarResponsable(IResponsablesBL responsablesBl)
        {
            if (responsablesBl == null)
                throw new ArgumentNullException(nameof(responsablesBl));

            _responsablesBl = responsablesBl;
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            try
            {
                var responsable = new Responsable();
                responsable.Dui = txtDui.Text.Trim();
                responsable.Nombres = txtNombres.Text.Trim();
                responsable.Apellidos = txtApellidos.Text.Trim();
                responsable.Telefono1 = txtTelefono1.Text.Trim();
                responsable.Telefono2 = txtTelefono2.Text.Trim();
                responsable.Direccion = txtDireccion.Text.Trim();

                //_responsablesBl.Insert(responsable);

                if(MessageBox.Show(this, "¿Desea continuar con el ingreso de los naufragos?", "", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var frmNuevoEditarNaufrago = new FrmNuevoEditarNaufrago();
                    frmNuevoEditarNaufrago.Show();
                }

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
