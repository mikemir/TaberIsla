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
        protected IUnityContainer _container = null;
        public FrmPrincipal(IUnityContainer container)
        {

            if (container == null)
                throw new ArgumentNullException(nameof(container));

            _container = container;
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnNuevoResponsable_Click(object sender, EventArgs e)
        {
            var frmNuevoResponsable = new FrmNuevoEditarResponsable(_container.Resolve<IResponsablesBL>());
            frmNuevoResponsable.Show(this);
        }

        private void btnListNaufragos_Click(object sender, EventArgs e)
        {
            var frmListNaufragos = new FrmListNaufragos(_container.Resolve<IResponsablesBL>());
            frmListNaufragos.Show(this);
        }

        private void btnListResponsables_Click(object sender, EventArgs e)
        {
            var frmListResponsables = new FrmListResponsables(_container.Resolve<IResponsablesBL>());
            frmListResponsables.Show(this);
        }

        public void Received(object result)
        {
            var frmNuevoNaufrago = new FrmNuevoEditarNaufrago();//ToDo: INaufragosBL
            frmNuevoNaufrago.Show(this);
        }
    }
}
