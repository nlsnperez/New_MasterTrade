using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_MasterTrade.Objetos
{
    public class Credencial
    {
        public int Id { get; set; }
        public string NombreUsuario { get; set; }
        public string Contrasegna { get; set; }

        public Credencial(int id, string nombreUsuario, string contrasegna)
        {
            Id = id;
            NombreUsuario = nombreUsuario;
            Contrasegna = contrasegna;
        }
    }
}
