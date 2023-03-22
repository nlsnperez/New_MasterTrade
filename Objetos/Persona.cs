using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace New_MasterTrade.Objetos
{
    public class Persona
    {
        public int Id{ get; set; }
        public int Nivel{ get; set; }
        public string Documento{ get; set; }
        public string RazonSocial{ get; set; }
        public string Direccion{ get; set; }
        public string Telefono{ get; set; }
        public string Correo{ get; set; }

        public Persona(int id, int nivel, string documento, string razonSocial, string direccion, string telefono, string correo)
        {
            Id = id;
            Nivel = nivel;
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

        public bool ValidDocumento()
        {
            string regex = "^(V|E|J|G)+[0-9]{5,9}$";
            return Regex.IsMatch(this.Documento, regex, RegexOptions.IgnoreCase);
        }

        public bool ValidEmail()
        {
            string regex = @"^[^@\s]+@[^@\s]+\.(com|net|org|gov|ve)$";
            return Regex.IsMatch(this.Correo, regex, RegexOptions.IgnoreCase);
        }

        public bool ValidPhone()
        {
            string regex = "^(0251|0414|0424|0412|0416|0426)[0-9]{7}$";
            return Regex.IsMatch(this.Telefono, regex, RegexOptions.IgnoreCase);
        }
    }
}
