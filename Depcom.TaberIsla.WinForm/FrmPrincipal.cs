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

namespace Depcom.TaberIsla.WinForm
{
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

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

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
            var frmNuevoNaufrago = new FrmNuevoEditarNaufrago(_naufragosBl);
            frmNuevoNaufrago.Show(this);
        }
    }
}
