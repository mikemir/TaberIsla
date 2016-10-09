using Depcom.TaberIsla.BusinessLogic.Interfaces;
using Depcom.TaberIsla.WinForm.Base;
using Depcom.TaberIsla.WinForm.Services;
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
    public partial class FrmListNaufragos : FlatForm, ICommunicable
    {
        private int _idNaufragoSelected;
        private INaufragosBL _naufragosBl = null;
        public FrmListNaufragos(INaufragosBL naufragosBl)
        {
            if (naufragosBl == null)
                throw new ArgumentNullException(nameof(naufragosBl));

            _naufragosBl = naufragosBl;
            InitializeComponent();
        }

        private void FrmListNaufragos_Load(object sender, EventArgs e)
        {
            try
            {
                LoadNaufragos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void LoadNaufragos()
        {
            dgvNaufragos.AutoGenerateColumns = false;

            var serviceNaufragos = new NaufragosServices(_naufragosBl);
            dgvNaufragos.DataSource = serviceNaufragos.GetAll();
        }

        private void dgvNaufragos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void Received(object result)
        {
            LoadNaufragos();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if(_idNaufragoSelected != 0)
            {
                var frm = new FrmNuevoEditarNaufrago(_naufragosBl, _idNaufragoSelected);
                frm.Show();
            }
            else
            {
                MessageBox.Show("No se ha seleccionado un naúfrago para editar.");
            }
        }

        private void dgvNaufragos_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            _idNaufragoSelected = Convert.ToInt32(dgvNaufragos.Rows[e.RowIndex].Cells["colId"].Value);
        }
    }
}
