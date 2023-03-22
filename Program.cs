using MySql.Data.MySqlClient;
using New_MasterTrade.Base_de_Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New_MasterTrade
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Conexion conexion = new Conexion();
            try
            {
                conexion.con.Open();
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Login());
                conexion.con.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("No se encontró una conexion a la base de datos\n" + ex.Message, "¡ERROR!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
    }
}
