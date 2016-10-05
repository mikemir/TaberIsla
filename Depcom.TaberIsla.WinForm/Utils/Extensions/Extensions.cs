using CSharpVerbalExpressions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Depcom.TaberIsla.WinForm.Utils.Extensions
{
    public static class Extensions
    {
        public static void SetCantidad(this Label obj, int value)
        {
            if (value > 0 && value < 400)
                obj.ForeColor = Color.Green;
            else if (value > 400 && value < 450)
                obj.ForeColor = Color.Orange;
            else if (value > 450 && value < 499)
                obj.ForeColor = Color.Red;
            else
                obj.ForeColor = Color.Black;

            obj.Text = value.ToString().PadLeft(3, '0');
        }
    }
}
