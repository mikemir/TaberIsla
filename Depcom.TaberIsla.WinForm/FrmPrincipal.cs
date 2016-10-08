using Depcom.TaberIsla.BusinessLogic;
using Depcom.TaberIsla.BusinessLogic.Interfaces;
using Depcom.TaberIsla.Domain;
using Depcom.TaberIsla.WinForm.Base;
using Depcom.TaberIsla.WinForm.Formularios;
using Depcom.TaberIsla.WinForm.Services;
using Depcom.TaberIsla.WinForm.Services.Interfaces;
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
using Depcom.TaberIsla.WinForm.Utils.Extensions;

namespace Depcom.TaberIsla.WinForm
{
    public enum TipoAcceso
    {
        None,
        Nuevo,
        Editar
    }

    public partial class FrmPrincipal : FlatForm, ICommunicable
    {
        private INaufragosBL _naufragosBl;
        private IResponsablesBL _responsablesBl;

        public FrmPrincipal(IUnityContainer container)
        {

            if (container == null)
                throw new ArgumentNullException(nameof(container));

            _responsablesBl = container.Resolve<IResponsablesBL>();
            _naufragosBl = container.Resolve<INaufragosBL>();
            InitializeComponent();
        }

        public void LoadEstadist()
        {
            try
            {
                var countNaufragos = _naufragosBl.GetAll().Count();
                btnListNaufragos.Text = $"NAUFRAGOS ({countNaufragos})";
                lblCantidadTotal.SetCantidad(countNaufragos);

                var countResponsables = _responsablesBl.GetAll().Count;
                btnListResponsables.Text = $"RESPONSABLES ({countResponsables})";
                lblCantidadRestante.SetCantidad(500 - countNaufragos);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Se ha producido un error: {ex.Message}");
            }
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            LoadEstadist();
        }

        private void btnNuevoResponsable_Click(object sender, EventArgs e)
        {
            var frmNuevoResponsable = new FrmNuevoEditarResponsable(_responsablesBl);
            frmNuevoResponsable.Show(this);
        }

        private void btnListNaufragos_Click(object sender, EventArgs e)
        {
            var frmListNaufragos = new FrmListNaufragos(_naufragosBl);
            frmListNaufragos.Show(this);
        }

        private void btnListResponsables_Click(object sender, EventArgs e)
        {
            var frmListResponsables = new FrmListResponsables(_responsablesBl);
            frmListResponsables.Show(this);
        }

        public void Received(object result)
        {
            LoadEstadist();

            if (result == null) return;

            if(result is Responsable)
            {
                var responsable = result as Responsable;

                var frmNuevoNaufrago = new FrmNuevoEditarNaufrago(_naufragosBl, responsable);
                frmNuevoNaufrago.Show(this);
            }
        }
    }
}
