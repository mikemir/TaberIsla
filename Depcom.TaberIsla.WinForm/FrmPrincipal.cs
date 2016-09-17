using Depcom.TaberIsla.BusinessLogic;
using Depcom.TaberIsla.BusinessLogic.Interfaces;
using Depcom.TaberIsla.Domain;
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
    public partial class FrmPrincipal : Form
    {
        IUnityContainer _container = null;
        public FrmPrincipal(IUnityContainer container)
        {
            if (container == null)
                throw new ArgumentNullException(nameof(container));

            _container = container;
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            var service = new ResponsablesServices(_container.Resolve<IResponsablesBL>());
            dgvResponsables.DataSource = service.GetAll();
        }
    }
}
