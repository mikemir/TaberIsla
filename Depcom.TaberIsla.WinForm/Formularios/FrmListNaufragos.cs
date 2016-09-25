﻿using Depcom.TaberIsla.BusinessLogic.Interfaces;
using Depcom.TaberIsla.WinForm.Base;
using Depcom.TaberIsla.WinForm.Services;
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
    public partial class FrmListNaufragos : FlatForm
    {
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
                var serviceNaufragos = new NaufragosServices(_naufragosBl);
                dgvNaufragos.DataSource = serviceNaufragos.GetAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
    }
}
