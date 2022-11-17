using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace New_MasterTrade.Objetos
{
    class Usuario
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Contrasegna { get; set; }
        public string Correo { get; set; }
        public string Documento { get; set; }
        public string Nombre { get; set; }
        public int Nivel { get; set; }

        public Usuario(string userName, string contrasegna, string correo, string documento, string nombre, int nivel)
        {
            UserName = userName;
            Contrasegna = contrasegna;
            Correo = correo;
            Documento = documento;
            Nombre = nombre;
            Nivel = nivel;
        }

        public bool IsEmpty()
        {
            if (this.UserName == "" || this.Contrasegna == "" || this.Documento == "" || this.Nombre == "")
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
    }
}
