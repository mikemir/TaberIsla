using Depcom.TaberIsla.WinForm.Utils.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Depcom.TaberIsla.WinForm.Base
{
    public class FlatButton : Button
    {
        public FlatButton()
        {
            Size = new Size(100, 35);
            FlatStyle = FlatStyle.Flat;
            ForeColor = Color.FromArgb(255, 25, 25, 25);
            Font = new Font("Segoe UI", 10, FontStyle.Bold);
        }
    }
}
