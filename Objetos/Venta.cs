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
        public int Cliente { get; set; }
        public int MetodoPago { get; set; }
        public List<Detalle> Detalle { get; set; }

        public Venta(string numero_Control, int cliente, int metodoPago, List<Detalle> detalle)
        {
            Numero_Control = numero_Control;
            Cliente = cliente;
            MetodoPago = metodoPago;
            Detalle = detalle;
        }
    }
}
