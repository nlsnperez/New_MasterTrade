using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_MasterTrade.Objetos
{
    public class Venta
    {
        public int Id { get; set; }
        public string Numero_Control { get; set; }
        public int Cliente { get; set; }
        public string ClienteNombre { get; set; }
        public int MetodoPago { get; set; }
        public string MetodoPagoDescripcion { get; set; }
        public DateTime FechaRegistro { get; set; }
        public List<Detalle> Detalle { get; set; }

        public Venta(string numero_Control, int cliente, int metodoPago, DateTime fechaRegistro, List<Detalle> detalle)
        {
            Numero_Control = numero_Control;
            Cliente = cliente;
            MetodoPago = metodoPago;
            FechaRegistro = fechaRegistro;
            Detalle = detalle;
        }

        public Venta()
        {
        }
    }
}
