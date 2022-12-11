using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_MasterTrade.Objetos
{
    public class Detalle
    {
        public int Id { get; set; }
        public int IdOrden { get; set; }
        public int Producto { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public decimal TotalBs { get; set; }

        public Detalle(int id, int idOrden, int producto, int cantidad, decimal precio, decimal totalBs)
        {
            Id = id;
            IdOrden = idOrden;
            Producto = producto;
            Cantidad = cantidad;
            Precio = precio;
            TotalBs = totalBs;
        }
    }
}
