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
        public int Cliente { get; set; }
        public int Tasa_Cambio { get; set; }
        public string NumeroOrden { get; set; }
        public DateTime FechaYHora { get; set; }

        public Venta(int id, int cliente, int tasa_cambio, string numeroOrden, DateTime fechaYHora)
        {
            Id = id;
            Cliente = cliente;
            Tasa_Cambio = tasa_cambio;
            NumeroOrden = numeroOrden;
            FechaYHora = fechaYHora;
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
