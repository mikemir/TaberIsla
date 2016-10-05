using Depcom.TaberIsla.BusinessLogic.Interfaces;
using Depcom.TaberIsla.Domain;
using Depcom.TaberIsla.WinForm.Base;
using Depcom.TaberIsla.WinForm.Utils.Extensions;
using Depcom.TaberIsla.WinForm.Utils.Interfaces;
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

        public FrmNuevoEditarResponsable(IResponsablesBL responsablesBl, TipoAcceso tipoAcceso)
        {
            if (responsablesBl == null)
                throw new ArgumentNullException(nameof(responsablesBl));

            _responsablesBl = responsablesBl;
            _tipoAcceso = tipoAcceso;

            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            Responsable responsable;
            var messageBoxText = "¿Desea continuar con el ingreso de los naufragos?";

            try
            {
                responsable = string.IsNullOrEmpty(txtId.Text)
                    ? new Responsable() : _responsablesBl.GetByKey(int.Parse(txtId.Text));

                responsable.Dui = txtDui.Text.Trim();
                responsable.Nombres = txtNombres.Text.Trim();
                responsable.Apellidos = txtApellidos.Text.Trim();
                responsable.Telefono1 = txtTelefono1.Text.Trim();
                responsable.Telefono2 = txtTelefono2.Text.Trim();
                responsable.Direccion = txtDireccion.Text.Trim();

                switch (_tipoAcceso)
                {
                    case TipoAcceso.None:
                        break;
                    case TipoAcceso.Nuevo:
                        _responsablesBl.Insert(responsable);
                        break;
                    case TipoAcceso.Editar:
                        _responsablesBl.Update(responsable);
                        break;
                    default:
                        throw new Exception($"Error en formulario {this.Name}: tipo de acceso incorrecto.");
                }

                if(MessageBox.Show(this, messageBoxText, "Ingreso naufrago", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if(Owner is ICommunicable)
                    {
                        ((ICommunicable)Owner).Received(null);
                    }
                }

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void txtNombres_Validating(object sender, CancelEventArgs e)
        {
            var txt = sender as TextBox;
            if (txt == null) return;

            if (txt.IsEmpty())
            {
                txt.BackColor = Color.Tomato;
                MessageBox.Show("El 'Nombre' ingresado no es válido.");
                e.Cancel = true;
            }
            else
            {
                txt.BackColor = Color.Gainsboro;
            }
        }

        private void txtApellidos_Validating(object sender, CancelEventArgs e)
        {
            var txt = sender as TextBox;
            if (txt == null) return;

            if (txt.IsEmpty())
            {
                txt.BackColor = Color.Tomato;
                MessageBox.Show("El 'Apellido' ingresado no es válido.");
                e.Cancel = true;
            }
            else
            {
                txt.BackColor = Color.Gainsboro;
            }
        }

        private void txtTelefono1_Validating(object sender, CancelEventArgs e)
        {
            var txt = sender as TextBoxBase;
            if (txt == null) return;

            if (!txt.IsTelephone())
            {
                txt.BackColor = Color.Tomato;
                MessageBox.Show("El 'Telefono 1' ingresado no es válido.");
                e.Cancel = true;
            }
            else
            {
                txt.BackColor = Color.Gainsboro;
            }
        }

        private void txtTelefono2_Validating(object sender, CancelEventArgs e)
        {
            var txt = sender as TextBoxBase;
            if (txt == null) return;

            if (!txt.IsTelephone())
            {
                txt.BackColor = Color.Tomato;
                MessageBox.Show("El 'Telefono 2' ingresado no es válido.");
                e.Cancel = true;
            }
            else
            {
                txt.BackColor = Color.Gainsboro;
            }
        }

        private void txtDireccion_Validating(object sender, CancelEventArgs e)
        {
            var txt = sender as TextBox;
            if (txt == null) return;

            if (txt.IsEmpty())
            {
                txt.BackColor = Color.Tomato;
                MessageBox.Show("La 'Dirección' ingresado no es válido.");
                e.Cancel = true;
            }
            else
            {
                txt.BackColor = Color.Gainsboro;
            }
        }

        private void txtDui_Validating(object sender, CancelEventArgs e)
        {
            if (!txtDui.IsDuiValid())
            {
                txtDui.BackColor = Color.Tomato;
                MessageBox.Show("El DUI ingresado no es válido.");
                e.Cancel = true;
            }
            else
            {
                txtDui.BackColor = Color.Gainsboro;
                var responsable = _responsablesBl.GetByDUI(txtDui.Text);

                if (responsable != null)
                {
                    txtId.Text = responsable.Id.ToString();
                    txtNombres.Text = responsable.Nombres;
                    txtApellidos.Text = responsable.Apellidos;
                    txtTelefono1.Text = responsable.Telefono1;
                    txtTelefono2.Text = responsable.Telefono2;
                    txtDireccion.Text = responsable.Direccion;

                    _tipoAcceso = TipoAcceso.Editar;
                }
            }
        }
    }
}
