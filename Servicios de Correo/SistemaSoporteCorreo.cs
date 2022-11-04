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
            Remitente = "noreply.mastertrade@gmail.com";
            Contrasegna = "lsvjwgsajwlcjkta";
            Servidor = "smtp.gmail.com";
            Puerto = 587;
            ssl = true;

            IniciarClienteSMTP();
        }
    }
}
