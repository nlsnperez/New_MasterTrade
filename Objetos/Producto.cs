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
        public String Codigo { get; set; }
        public String Nombre { get; set; }
        public String Categoria { get; set; }
        public float Costo { get; set; }
        public int StockMax { get; set; }
        public int StockMin { get; set; }

        public Producto(int id, string codigo, string nombre, string categoria, float costo, int stockMax, int stockMin)
        {
            Id = id;
            Codigo = codigo;
            Nombre = nombre;
            Categoria = categoria;
            Costo = costo;
            StockMax = stockMax;
            StockMin = stockMin;
        }

        public bool IsEmpty()
        {
            if (this.Codigo == "" || this.Nombre == "" || this.Categoria == "" || this.Costo == 0 || this.StockMax == 0 || this.StockMin == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CompararStock()
        {
            if (this.StockMax < this.StockMin)
            {
                return false;
            }
            else return true;
        }
    }
}
