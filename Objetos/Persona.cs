using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace New_MasterTrade.Objetos
{
    class Persona
    {
        public string Documento{ get; set; }
        public string RazonSocial{ get; set; }
        public string Direccion{ get; set; }
        public string Telefono{ get; set; }
        public string Correo{ get; set; }

        public Persona(string documento, string razonSocial, string direccion, string telefono, string correo)
        {
            Documento = documento;
            RazonSocial = razonSocial;
            Direccion = direccion;
            Telefono = telefono;
            Correo = correo;
        }

        public bool IsEmpty()
        {
            if (this.Documento == "" || this.RazonSocial == "" || this.Direccion == "" || this.Telefono == "" || this.Correo == "")
            {
                return true;
            }
            return false;
        }

        public bool ValidEmail()
        {
            string regex = @"^[^@\s]+@[^@\s]+\.(com|net|org|gov|ve)$";
            return Regex.IsMatch(this.Correo, regex, RegexOptions.IgnoreCase);
        }
    }
}
