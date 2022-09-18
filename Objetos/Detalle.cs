using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_MasterTrade.Objetos
{
    class Detalle
    {
        public string Producto{ get; set; }
        public int Cantidad{ get; set; }
        public float Precio{ get; set; }

        public Detalle(string producto, int cantidad, float precio)
        {
            Producto = producto;
            Cantidad = cantidad;
            Precio = precio;
        }
    }
}
