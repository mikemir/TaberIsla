using Depcom.TaberIsla.BusinessLogic.Interfaces;
using Depcom.TaberIsla.WinForm.Base;
using Depcom.TaberIsla.WinForm.Services;
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
    public partial class FrmListResponsables : FlatForm
    {
        private IResponsablesBL _responsablesBl = null;
        public FrmListResponsables(IResponsablesBL responsablesBl)
        {
            if (responsablesBl == null)
                throw new ArgumentNullException(nameof(responsablesBl));

            _responsablesBl = responsablesBl;
            InitializeComponent();
        }

        private void FrmListResponsables_Load(object sender, EventArgs e)
        {
            var serviceNaufragos = new ResponsablesServices(_responsablesBl);
            dgvResponsables.AutoGenerateColumns = false;
            dgvResponsables.DataSource = serviceNaufragos.GetAll();
        }
    }
}
