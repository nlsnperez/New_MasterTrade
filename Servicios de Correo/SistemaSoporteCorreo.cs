using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_MasterTrade.Servicios_de_Correo
{
    class SistemaSoporteCorreo : ServidorCorreoMaestro
    {
        public SistemaSoporteCorreo()
        {
            Remitente = "sagitario20120@gmail.com";
            Contrasegna = "whoedqanieopdojs";
            Servidor = "smtp.gmail.com";
            Puerto = 587;
            ssl = true;

            IniciarClienteSMTP();
        }
    }
}
