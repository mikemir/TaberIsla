using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Depcom.TaberIsla.WinForm.Base
{
    public class FlatForm : Form
    {
        protected IUnityContainer _container = null;
        public FlatForm(IUnityContainer container)
        {
            if (container == null)
                throw new ArgumentNullException(nameof(container));

            this.MaximizeBox = false;
            this.BackColor = Color.White;
            this.Size = new Size(500, 600);
            this.ForeColor = Color.FromArgb(255, 25, 25, 25);
            this.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));

            _container = container;
        }
    }
}
