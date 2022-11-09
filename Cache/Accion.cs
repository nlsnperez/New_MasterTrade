using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_MasterTrade.Cache
{
    public static class Accion
    {
        public static string IniciarSesion(string x)
        {
            return "El usuario "+x+" inició sesión en el sistema";
        }
        public static string NuevoRegistro(string x, string y)
        {
            return "El usuario " + x + " registró la entrada de "+y+" al el sistema";
        }
        public static string RegistroActualizado(string x, string y)
        {
            return "El usuario " + x + " actualizó la entrada de " + y + " en el sistema";
        }
        public static string RegistroDesactivado(string x, string y)
        {
            return "El usuario " + x + " desactivó la entrada de " + y + " en el sistema";
        }
        public static string NuevaVenta(string x, string y)
        {
            return "El usuario " + x + " registró la venta " + y + " en el sistema";
        }
        public static string NuevaCompra(string x, string y)
        {
            return "El usuario " + x + " registró la compra " + y + " en el sistema";
        }
        public static string CerrarSesion(string x)
        {
            return "El usuario " + x + " cerró su sesión en el sistema";
        }
    }
}
