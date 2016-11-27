using Depcom.TaberIsla.BusinessLogic;
using Depcom.TaberIsla.BusinessLogic.Interfaces;
using Depcom.TaberIsla.Domain;
using Depcom.TaberIsla.WinForm.Base;
using Depcom.TaberIsla.WinForm.Formularios;
using Depcom.TaberIsla.WinForm.Services;
using Depcom.TaberIsla.WinForm.Services.Interfaces;
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
using Depcom.TaberIsla.WinForm.Utils.Extensions;
using System.Net.Mail;
using System.Net;
using System.Globalization;

namespace Depcom.TaberIsla.WinForm
{
    public enum TipoAcceso
    {
        None,
        Nuevo,
        Editar
    }

    public partial class FrmPrincipal : FlatForm, ICommunicable
    {
        private INaufragosBL _naufragosBl;
        private IResponsablesBL _responsablesBl;
        private IBajasBL _bajasBl;

        public FrmPrincipal(IUnityContainer container)
        {

            if (container == null)
                throw new ArgumentNullException(nameof(container));

            _responsablesBl = container.Resolve<IResponsablesBL>();
            _naufragosBl = container.Resolve<INaufragosBL>();
            _bajasBl = container.Resolve<IBajasBL>();
            InitializeComponent();
        }

        public void LoadEstadist()
        {
            try
            {
                var countNaufragos = _naufragosBl.Count();
                var countDummies = _naufragosBl.Count(n => n.Nombres == "DUMMIE");
                btnListNaufragos.Text = $"NAUFRAGOS ({countNaufragos})";

                lblCantidadTotal.SetCantidad(countNaufragos);
                lblTotalReal.SetCantidad(countNaufragos - countDummies);
                lblCantidadRestante.SetCantidad(500 - countNaufragos);
                lblRestantesReal.SetCantidad(500 - countNaufragos - countDummies);

                lblBajas.Text = _bajasBl.GetAll().Count.ToString();

                var countResponsables = _responsablesBl.GetAll().Count;
                btnListResponsables.Text = $"RESPONSABLES ({countResponsables})";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Se ha producido un error: {ex.Message}");
            }
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            LoadEstadist();
        }

        private void btnNuevoResponsable_Click(object sender, EventArgs e)
        {
            var frmNuevoResponsable = new FrmNuevoEditarResponsable(_responsablesBl);
            frmNuevoResponsable.Show(this);
        }

        private void btnListNaufragos_Click(object sender, EventArgs e)
        {
            var frmListNaufragos = new FrmListNaufragos(_naufragosBl, _responsablesBl);
            frmListNaufragos.Show(this);
        }

        private void btnListResponsables_Click(object sender, EventArgs e)
        {
            var frmListResponsables = new FrmListResponsables(_responsablesBl);
            frmListResponsables.Show(this);
        }

        public void Received(object result)
        {
            LoadEstadist();

            if (result == null) return;

            if(result is Responsable)
            {
                var responsable = result as Responsable;

                var frmNuevoNaufrago = new FrmNuevoEditarNaufrago(_naufragosBl, responsable);
                frmNuevoNaufrago.Show(this);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            LoadEstadist();
        }

        private string GetTurno(DateTime time)
        {
            string result = "";
            var hour = time.Hour;

            if(time.DayOfWeek == DayOfWeek.Sunday)
            {
                if (hour > 7 && hour < 9)
                    result = "DOM 7AM";
                if (hour > 9 && hour < 11)
                    result = "DOM 9AM";
                if (hour > 11 && hour < 13)
                    result = "DOM 11AM";
                if (hour > 15 && hour < 17)
                    result = "DOM 11AM";
                if (hour > 17 && hour < 19)
                    result = "DOM 11AM";
            }
            else
            {
                var culture = new CultureInfo("es-SV");
                var day = culture.DateTimeFormat.GetDayName(time.DayOfWeek);
                result = day.ToUpper();
            }

            return result;
        }

        private void btnEnviarReporte_Click(object sender, EventArgs e)
        {

            try
            {
                var turno = GetTurno(DateTime.Now);
                var countNaufragos = _naufragosBl.Count();
                var countDummies = _naufragosBl.Count(n => n.Nombres == "DUMMIE");
                var subject = $"REPORTE TABER ISLA - TURNO {turno} {DateTime.Now.ToString("dd-MM-yyyy")}";

                var smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.Credentials = new NetworkCredential("depcom.estadistico@gmail.com", "tbbDepcomEstadistico2016");
                smtp.EnableSsl = true;

                var msj = new MailMessage();
                msj.Subject = subject;
                msj.From = new MailAddress("depcom.estadistico@gmail.com");
                msj.To.Add(new MailAddress("nightware.emir@gmail.com"));
                msj.To.Add(new MailAddress("ijam.1602@gmail.com"));
                msj.To.Add(new MailAddress("shuviota@gmail.com"));

                StringBuilder builder = new StringBuilder();
                builder.Append($"<h3>{subject}</h3>");
                builder.Append($"<b>TOTAL NÁUFRAGOS:</b> {countNaufragos} <br>");
                builder.Append($"<b>TOTAL DUMMIES:</b> {countDummies} <br>");
                builder.Append($"<b>TOTAL REAL:</b> {countNaufragos - countDummies} <br>");

                msj.Body = builder.ToString();
                msj.IsBodyHtml = true;

                smtp.Send(msj);
            }
            catch (Exception ex)
            {

                MessageBox.Show($"El correo no pudo ser enviado: {ex.Message}", "Error");
            }
        }

        private void btnDarBaja_Click(object sender, EventArgs e)
        {
            var frmDarBaja = new FrmDarBajaNaufrago(_bajasBl, _naufragosBl);
            frmDarBaja.Show(this);
        }
    }
}
