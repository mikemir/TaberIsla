using Depcom.TaberIsla.BusinessLogic.Interfaces;
using Depcom.TaberIsla.Domain;
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
    public partial class FrmDarBajaNaufrago : FlatForm
    {
        private readonly IBajasBL _bajasBl;
        private readonly INaufragosBL _naufragosBl;

        public FrmDarBajaNaufrago(IBajasBL bajasBl, INaufragosBL naufragosBl)
        {
            if (bajasBl == null)
                throw new ArgumentNullException(nameof(bajasBl));

            if (naufragosBl == null)
                throw new ArgumentNullException(nameof(naufragosBl));

            _naufragosBl = naufragosBl;
            _bajasBl = bajasBl;
            InitializeComponent();
        }

        private void FrmDarBajaNaufrago_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtCorrelativo.Text))
            {
                MessageBox.Show("Debe ingresar un correlativo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string correlativo = txtCorrelativo.Text.Trim();
            var naufrago = _naufragosBl.Find(correlativo).SingleOrDefault();

            if(naufrago == null)
            {
                MessageBox.Show($"El naufrago con el correlativo {correlativo} no se encuentra.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var baja = _bajasBl.Find(b => b.IdNaufrago == naufrago.Id).SingleOrDefault();

            if (baja != null)
            {
                MessageBox.Show($"El naufrago con el correlativo {correlativo}: {naufrago.Nombres} {naufrago.Apellidos} ya se encuentra dado de baja.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var bajaNaufrago = new Baja { IdNaufrago = naufrago.Id, FechaHoraIngreso = DateTime.Now };

            try
            {
                _bajasBl.Insert(bajaNaufrago);

                MessageBox.Show($"Listo Naufrago {naufrago.Nombres} {naufrago.Apellidos} dado de baja.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtCorrelativo.Text = string.Empty;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
