using Depcom.TaberIsla.BusinessLogic;
using Depcom.TaberIsla.BusinessLogic.Interfaces;
using Depcom.TaberIsla.Domain;
using Depcom.TaberIsla.WinForm.Base;
using Depcom.TaberIsla.WinForm.Formularios;
using Depcom.TaberIsla.WinForm.Services;
using Depcom.TaberIsla.WinForm.Services.Interfaces;
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
    public partial class FrmPrincipal : FlatForm
    {
        public FrmPrincipal(IUnityContainer container)
            : base(container)
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void btnNuevoResponsable_Click(object sender, EventArgs e)
        {

        }

        private void btnListNaufragos_Click(object sender, EventArgs e)
        {
            var frmListNaufragos = new FrmListNaufragos(_container);
            frmListNaufragos.ShowDialog(this);
        }
    }
}
