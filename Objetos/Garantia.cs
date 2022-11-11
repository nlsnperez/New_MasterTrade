using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_MasterTrade.Objetos
{
    class Garantia
    {
        public int Id { get; set; }
        public int Detalle { get; set; }
        public DateTime Fecha_Inicio { get; set; }
        public DateTime Fecha_Final { get; set; }

        public Garantia(int id, int detalle, DateTime fecha_Inicio, DateTime fecha_Final)
        {
            Id = id;
            Detalle = detalle;
            Fecha_Inicio = fecha_Inicio;
            Fecha_Final = fecha_Final;
        }
    }
}
