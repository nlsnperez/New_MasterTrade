using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_MasterTrade.Objetos
{
    class Producto
    {
        public int Id { get; set; }
        public string Serial { get; set; }
        public string Descripcion { get; set; }
        public int Marca { get; set; }
        public int Categoria { get; set; }
        public decimal Precio_Compra { get; set; }
        public decimal Precio_Venta { get; set; }
        public bool Estado { get; set; }
        public byte[] Imagen { get; set; }

        public Producto(string serial, string descripcion, int marca, int categoria, decimal precio_Compra, decimal precio_Venta, bool estado, byte[] imagen)
        {
            Serial = serial;
            Descripcion = descripcion;
            Marca = marca;
            Categoria = categoria;
            Precio_Compra = precio_Compra;
            Precio_Venta = precio_Venta;
            Estado = estado;
            Imagen = imagen;
        }
    }
}
