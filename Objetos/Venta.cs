using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_MasterTrade.Objetos
{
    public class Venta
    {
        public int Id { get; set; }
        public string NumeroOrden { get; set; }
        public int Cliente { get; set; }
        public DateTime Fecha { get; set; }

        public Venta(int id, string numeroOrden, int cliente, DateTime fecha)
        {
            Id = id;
            NumeroOrden = numeroOrden;
            Cliente = cliente;
            Fecha = fecha;
        }

        public bool IsEmpty()
        {
            if (this.Id == 0 || this.Cliente == 0)
            {
                return true;
            }
            return false;
        }
    }
}
