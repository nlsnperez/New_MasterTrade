using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_MasterTrade.Objetos
{
    public class Detalle
    {
        public string Venta{ get; set; }
        public string Producto{ get; set; }
        public int Cantidad{ get; set; }
        public float Precio{ get; set; }

        public Detalle(string venta, string producto, int cantidad, float precio)
        {
            Venta = venta;
            Producto = producto;
            Cantidad = cantidad;
            Precio = precio;
        }
    }
}
