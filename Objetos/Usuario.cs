using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_MasterTrade.Objetos
{
    class Usuario
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Contrasegna { get; set; }
        public string Documento { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Nivel { get; set; }

        public Usuario(int iD, string userName, string contrasegna, string documento, string nombre, string apellido, string nivel)
        {
            ID = iD;
            UserName = userName;
            Contrasegna = contrasegna;
            Documento = documento;
            Nombre = nombre;
            Apellido = apellido;
            Nivel = nivel;
        }
    }
}
