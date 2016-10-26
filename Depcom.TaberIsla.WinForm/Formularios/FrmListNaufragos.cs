using Depcom.TaberIsla.BusinessLogic.Interfaces;
using Depcom.TaberIsla.Domain;
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
        private readonly INaufragosBL _naufragosBl;
        private readonly IResponsablesBL _responsablesBl;

        public FrmListNaufragos(INaufragosBL naufragosBl, IResponsablesBL responsablesBl)
        {
            if (naufragosBl == null)
                throw new ArgumentNullException(nameof(naufragosBl));

            if (responsablesBl == null)
                throw new ArgumentNullException(nameof(responsablesBl));

            _naufragosBl = naufragosBl;
            _responsablesBl = responsablesBl;
            InitializeComponent();
        }

        private void FrmListNaufragos_Load(object sender, EventArgs e)
        {
            try
            {
                LoadNaufragos(txtBusqueda.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }

        private void LoadNaufragos(string parametroBusqueda)
        {
            dgvNaufragos.AutoGenerateColumns = false;
            var serviceNaufragos = new NaufragosServices(_naufragosBl);

            dgvNaufragos.DataSource = string.IsNullOrEmpty(parametroBusqueda)
                    ? serviceNaufragos.GetAll() : serviceNaufragos.Find(parametroBusqueda);
        }

        public void Received(object result)
        {
            LoadNaufragos(txtBusqueda.Text);
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if(_idNaufragoSelected != 0)
            {
                var frm = new FrmNuevoEditarNaufrago(_naufragosBl, _idNaufragoSelected);
                frm.Show(this);
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

        private void txtBusqueda_TextChanged(object sender, EventArgs e)
        {
           LoadNaufragos(txtBusqueda.Text);
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            var frm = new FrmLogin();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                if (MessageBox.Show("¿Esta seguro que desea crear un registro DUMMIE?", "Crear Dummie", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    var correlativo = _naufragosBl.Count() + 1;
                    var responsable = _responsablesBl.GetByDUI("00000000-0");

                    _naufragosBl.Insert(new Naufrago
                    {
                        Correlativo = correlativo,
                        Nombres = "DEPCOM",
                        Apellidos = "DUMMIE",
                        FechaNacimiento = new DateTime(),
                        Responsable = responsable ?? new Responsable { Dui = "00000000-0", Nombres = "DEPCOM", Apellidos = "DUMMIE", Direccion = "", Telefono1 = "", Telefono2 = "" }
                    });

                    LoadNaufragos("");
                }
            }
        }
    }
}
