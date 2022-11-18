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
        public decimal TotalBs { get; set; }

        public Detalle(int idOrden, int producto, int cantidad, decimal totalBs)
        {
            IdOrden = idOrden;
            Producto = producto;
            Cantidad = cantidad;
            TotalBs = totalBs;
        }
    }
}
