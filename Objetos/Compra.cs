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
        public List<Detalle_Compra> Detalle{ get; set; }

        public Compra(/*string numero_Control,*/ string proveedor, List<Detalle_Compra> detalle)
        {
            //Numero_Control = numero_Control;
            Proveedor = proveedor;
            Detalle = detalle;
        }

        public void Generar_Codigo(string documento, int x)
        {
            Numero_Control = "MTC"+x.ToString("0000000");
        }
    }
}
