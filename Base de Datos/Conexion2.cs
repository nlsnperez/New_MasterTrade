﻿using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace New_MasterTrade.Base_de_Datos
{
    class Conexion2
    {
        public MySqlConnection con;

        public Conexion2()
        {
            string host = "localhost";
            string db = "mastertrade";
            string port = "3306";
            string usuario = "root";
            string contrasegna = "";
            string linea_conexion = "datasource =" + host + "; database =" + db + "; port =" + port + "; user =" + usuario + "; password =" + contrasegna + "; sslMode = none";
            con = new MySqlConnection(linea_conexion);
        }
    }
}
