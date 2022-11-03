using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using System.Net;
using System.Windows;

namespace New_MasterTrade.Servicios_de_Correo
{
    public abstract class ServidorCorreoMaestro
    {
        private SmtpClient clienteSMTP;
        protected string Remitente { get; set; }
        protected string Contrasegna { get; set; }
        protected string Servidor { get; set; }
        protected int Puerto { get; set; }
        protected bool ssl { get; set; }

        protected void IniciarClienteSMTP()
        {
            clienteSMTP = new SmtpClient();
            clienteSMTP.Credentials = new NetworkCredential(Remitente, Contrasegna);
            clienteSMTP.Host = Servidor;
            clienteSMTP.Port = Puerto;
            clienteSMTP.EnableSsl = ssl;
        }

        public void EnviarCorreo(string asunto, string cuerpo, string destinatario)
        {
            MailMessage mensaje = new MailMessage();
            try
            {
                mensaje.From = new MailAddress(Remitente);
                mensaje.To.Add(destinatario);
                mensaje.Subject = asunto;
                mensaje.Body = cuerpo;
                mensaje.Priority = MailPriority.Normal;

                clienteSMTP.Send(mensaje);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                mensaje.Dispose();
                clienteSMTP.Dispose();
            }
        }
    }
}
