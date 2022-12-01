using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_MasterTrade.Objetos
{
    public class Producto
    {
        public int Id { get; set; }
        public string Serial { get; set; }
        public string Descripcion { get; set; }
        public int Marca { get; set; }
        public int Categoria { get; set; }
        public int Modelo { get; set; }
        public decimal Precio_Compra { get; set; }
        public decimal Precio_Venta { get; set; }
        public int Garantia { get; set; }
        public byte[] Imagen { get; set; }

        public Producto(int id, string serial, string descripcion, int marca, int categoria, int modelo, decimal precio_Compra, decimal precio_Venta, int garantia, byte[] imagen)
        {
            Id = id;
            Serial = serial;
            Descripcion = descripcion;
            Marca = marca;
            Categoria = categoria;
            Modelo = modelo;
            Precio_Compra = precio_Compra;
            Precio_Venta = precio_Venta;
            Garantia = garantia;
            Imagen = imagen;
        }

        public bool TamagnoSerial()
        {
            if (this.Serial.Length < 10 || this.Serial.Length > 13)
            {
                return false;
            }
            return true;
        }

        public bool IsEmpty()
        {
            if (this.Serial == "" || this.Descripcion == "" || this.Precio_Compra == 0 || this.Precio_Venta == 0)
            {
                return true;
            }
            return false;
        }

        public bool PrecioCorrecto()
        {
            if (Precio_Compra < Precio_Venta)
            {
                return true;
            }
            return false;
        }
    }
}
