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
        private bool _validClosed;
        private int _idResponsable;
        private IResponsablesBL _responsablesBl;

        public FrmNuevoEditarResponsable(IResponsablesBL responsablesBl)
        {
            if (responsablesBl == null)
                throw new ArgumentNullException(nameof(responsablesBl));

            _responsablesBl = responsablesBl;
            _tipoAcceso = TipoAcceso.Nuevo;
            InitializeComponent();
        }

        public FrmNuevoEditarResponsable(IResponsablesBL responsablesBl, int idResponsable)
        {
            if (responsablesBl == null)
                throw new ArgumentNullException(nameof(responsablesBl));

            _responsablesBl = responsablesBl;
            _tipoAcceso = TipoAcceso.Editar;
            _idResponsable = idResponsable;
            InitializeComponent();
        }

        private void FrmNuevoEditarResponsable_Load(object sender, EventArgs e)
        {
            _validClosed = true;

            if(_tipoAcceso == TipoAcceso.Editar)
            {
                var responsable = _responsablesBl.GetByKey(_idResponsable);

                txtId.Text = _idResponsable.ToString();
                txtNombres.Text = responsable.Nombres;
                txtApellidos.Text = responsable.Apellidos;
                txtTelefono1.Text = responsable.Telefono1;
                txtTelefono2.Text = responsable.Telefono2;
                txtDireccion.Text = responsable.Direccion;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            Responsable responsable;
            var messageBoxText = " Responsable ingresado. ¿Desea continuar con el ingreso de los naufragos?";

            if (!ValidarCampos())
            {
                MessageBox.Show("Hay datos invalidos (revisar campos en rojo), no se puede guardar el responsable.", "Error de datos.");
                return;
            }

            if(txtDui.Text.Length < 10)
            {
                txtDui.BackColor = Color.Tomato;
                var msjFail = "El 'DUI' ingresado no es válido.";
                MessageBox.Show(msjFail, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtTelefono1.Text.Length < 8)
            {
                txtTelefono1.BackColor = Color.Tomato;
                var msjFail = "El 'Telefono 1' ingresado no es válido.";
                MessageBox.Show(msjFail, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtTelefono2.Text.Length < 8)
            {
                txtTelefono2.BackColor = Color.Tomato;
                var msjFail = "El 'Telefono 2' ingresado no es válido.";
                MessageBox.Show(msjFail, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

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
                        ((ICommunicable)Owner).Received(responsable);
                    }
                }
                else
                {
                    if (Owner is ICommunicable)
                    {
                        ((ICommunicable)Owner).Received(null);
                    }
                }

                _validClosed = false;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void txt_Validating(object sender, CancelEventArgs e)
        {
            var txt = sender as TextBoxBase;
            if (txt == null) return;

            txt.BackColor = !string.IsNullOrWhiteSpace(txt.Text) ? Color.Gainsboro : Color.Tomato;
        }

        public bool ValidarCampos()
        {
            var resultado = true;

            foreach (var item in Controls)
            {
                var txt = item as TextBoxBase;
                if (txt == null) continue;
                if (txt.Name == "txtId") continue;

                if (string.IsNullOrWhiteSpace(txt.Text))
                {
                    resultado = false;
                    break;
                }
            }

            return resultado;
        }

        private void txtDui_Leave(object sender, EventArgs e)
        {
            if (!txtDui.IsDuiValid())
            {
                txtDui.BackColor = Color.Tomato;
                MessageBox.Show("El DUI ingresado no es válido.");
            }
            else
            {
                txtDui.BackColor = Color.Gainsboro;
                if (_tipoAcceso == TipoAcceso.Editar) return;

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

        private void FrmNuevoEditarResponsable_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_validClosed) return;

            if (MessageBox.Show("¿Está seguro de cerrar la ventana? perderá todos los datos ingresados.",
                "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
