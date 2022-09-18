using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_MasterTrade.Objetos
{
    class Compra
    {
        public string Numero_Control{ get; set; }
        public string Proveedor{ get; set; }
        public List<Detalle> Detalle{ get; set; }

        public Compra(string proveedor, List<Detalle> detalle)
        {
            Proveedor = proveedor;
            Detalle = detalle;
        }

        public void Generar_Codigo(int x)
        {
            Numero_Control = "MTC"+x.ToString("0000000");
        }
    }
}
