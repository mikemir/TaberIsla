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
    public partial class FrmNuevoEditarNaufrago : FlatForm
    {
        private int _idNaufrago;
        private bool _validClosed;
        private Responsable _responsable;
        private INaufragosBL _naufragosBl;

        public FrmNuevoEditarNaufrago(INaufragosBL naufragosBl, Responsable responsable)
        {
            if (naufragosBl == null)
                throw new ArgumentNullException(nameof(naufragosBl));

            _naufragosBl = naufragosBl;
            _tipoAcceso = TipoAcceso.Nuevo;
            _responsable = responsable;
            InitializeComponent();
        }

        public FrmNuevoEditarNaufrago(INaufragosBL naufragosBl, int idNaufrago)
        {
            if (naufragosBl == null)
                throw new ArgumentNullException(nameof(naufragosBl));

            _naufragosBl = naufragosBl;
            _tipoAcceso = TipoAcceso.Editar;
            _idNaufrago = idNaufrago;
            InitializeComponent();
        }

        private void FrmNuevoEditarNaufrago_Load(object sender, EventArgs e)
        {
            _validClosed = true;

            if (_tipoAcceso == TipoAcceso.Nuevo)
            {
                dtpFechaNacimiento.Value = DateTime.Now.AddYears(-12);
                txtResponsable.Text = $"{_responsable.Nombres} {_responsable.Apellidos}";
            }
            else if(_tipoAcceso == TipoAcceso.Editar)
            {
                var naufrago = _naufragosBl.GetByKey(_idNaufrago);

                txtId.Text = _idNaufrago.ToString();
                txtNombres.Text = naufrago.Nombres;
                txtApellidos.Text = naufrago.Apellidos;
                dtpFechaNacimiento.Value = naufrago.FechaNacimiento;
                txtResponsable.Text = $"{naufrago.Responsable.Nombres} {naufrago.Responsable.Apellidos}";
                txtEdad.Text = ((DateTime.Now - naufrago.FechaNacimiento).Days / 365).ToString();
                txtObservacion.Text = naufrago.Observacion;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            Naufrago naufrago;

            if (!ValidarCampos())
            {
                MessageBox.Show("Hay datos invalidos (revisar campos en rojo), no se puede guardar el naufrago.", "Error de datos.");
                return;
            }

            try
            {
                var correlativo = _naufragosBl.Count() + 1;

                naufrago = string.IsNullOrEmpty(txtId.Text)
                    ? new Naufrago() : _naufragosBl.GetByKey(int.Parse(txtId.Text));

                naufrago.Nombres = txtNombres.Text.Trim();
                naufrago.Apellidos = txtApellidos.Text.Trim();
                naufrago.FechaNacimiento = dtpFechaNacimiento.Value;
                naufrago.Observacion = string.IsNullOrWhiteSpace(txtObservacion.Text) ? null : txtObservacion.Text;

                switch (_tipoAcceso)
                {
                    case TipoAcceso.None:
                        break;
                    case TipoAcceso.Nuevo:
                        naufrago.Correlativo = correlativo;
                        naufrago.Responsable = _responsable; //Se agrega el responsable injectado

                        _naufragosBl.Insert(naufrago);
                        break;
                    case TipoAcceso.Editar:
                        _naufragosBl.Update(naufrago);
                        break;
                    default:
                        throw new Exception($"Error en formulario {this.Name}: tipo de acceso incorrecto.");
                }

                var messageBoxText = $"El Naufrago ingresado tiene el correlativo {naufrago.Correlativo.ToString("000")} " +
                    $"¿Desea continuar con el ingreso de un nuevo naufrago para el responsable {naufrago.Responsable.Nombres} {naufrago.Responsable.Apellidos}?";

                if (MessageBox.Show(this, messageBoxText, "Ingreso naufrago", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    if (Owner is ICommunicable)
                    {
                        ((ICommunicable)Owner).Received(_responsable);
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
                if (txt.Name == "txtObservacion") continue;

                if (string.IsNullOrWhiteSpace(txt.Text))
                {
                    resultado = false;
                    break;
                }
            }

            return resultado;
        }

        private void dtpFechaNacimiento_Validating(object sender, CancelEventArgs e)
        {
            var dtp = sender as DateTimePicker;
            var edadNaufrago = (DateTime.Now - dtp.Value).Days / 365;

            if (dtp == null) return;

            if (edadNaufrago > 12 || edadNaufrago <= 7)
            {
                dtp.CalendarTitleBackColor = Color.Tomato;
                MessageBox.Show($"La  edad ({edadNaufrago}años) del Naufrago no es apta para inscripción en la Taber Isla.");
                e.Cancel = true;
            }
            else
            {
                txtEdad.Text = $"{edadNaufrago.ToString()} años";
                dtp.CalendarTitleBackColor = Color.White;
            }
        }

        private void FrmNuevoEditarNaufrago_FormClosing(object sender, FormClosingEventArgs e)
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
