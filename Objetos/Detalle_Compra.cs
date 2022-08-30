using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_MasterTrade.Objetos
{
    class Detalle_Compra
    {
        public string Compra{ get; set; }
        public string Producto{ get; set; }
        public int Cantidad{ get; set; }
        public float Precio{ get; set; }

        public Detalle_Compra(/*string compra, */string producto, int cantidad, float precio)
        {
            //Compra = compra;
            Producto = producto;
            Cantidad = cantidad;
            Precio = precio;
        }
    }
}
