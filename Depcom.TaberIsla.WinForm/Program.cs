using Depcom.TaberIsla.DepencyResolver;
using Depcom.TaberIsla.WinForm.Services;
using Depcom.TaberIsla.WinForm.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Depcom.TaberIsla.WinForm
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            var container = BootStrapper.Run();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmPrincipal(container));
        }
    }
}
