using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Depcom.TaberIsla.WinForm.Base
{
    public class FlatMaskedTextBox : MaskedTextBox
    {
        public FlatMaskedTextBox()
        {
            this.BackColor = Color.Gainsboro;
            this.BorderStyle = BorderStyle.FixedSingle;
        }
    }
}
