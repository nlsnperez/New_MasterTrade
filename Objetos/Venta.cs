using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_MasterTrade.Objetos
{
    class Venta
    {
        public string Numero_Control { get; set; }
        public string Cliente { get; set; }
        public List<Detalle> Detalle { get; set; }

        public Venta(string cliente, List<Detalle> detalle)
        {
            Cliente = cliente;
            Detalle = detalle;
        }

        public void Generar_Codigo(int x)
        {
            Numero_Control = "MTV" + x.ToString("0000000");
        }
    }
}
