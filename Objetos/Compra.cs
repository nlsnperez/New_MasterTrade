using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_MasterTrade.Objetos
{
    class Compra
    {
        public int Id { get; set; }
        public string NumeroOrden{ get; set; }
        public int Proveedor { get; set; }
        public DateTime Fecha { get; set; }

        public Compra(int id, string numeroOrden, int proveedor, DateTime fecha)
        {
            Id = id;
            NumeroOrden = numeroOrden;
            Proveedor = proveedor;
            Fecha = fecha;
        }

        public bool IsEmpty()
        {
            if (this.Id == 0 || this.Proveedor == 0)
            {
                return true;
            }
            return false;
        }
    }
}
