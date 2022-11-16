using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_MasterTrade.Objetos
{
    class Factura
    {
        public int Id { get; set; }
        public int Vendedor { get; set; }
        public int OrdenVenta { get; set; }
        public int MetodoPago { get; set; }
        public int Impuesto { get; set; }
        public decimal Total_Bs { get; set; }
        public decimal Total_Us { get; set; }

        public Factura(int id, int vendedor, int ordenVenta, int metodoPago, int impuesto, decimal total_Bs, decimal total_Us)
        {
            Id = id;
            Vendedor = vendedor;
            OrdenVenta = ordenVenta;
            MetodoPago = metodoPago;
            Impuesto = impuesto;
            Total_Bs = total_Bs;
            Total_Us = total_Us;
        }
    }
}
