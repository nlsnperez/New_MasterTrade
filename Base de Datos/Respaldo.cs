using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New_MasterTrade.Base_de_Datos
{
    class Respaldo : Conexion
    {
        public void Respaldar (string ruta)
        {
            try
            {
                con.ConnectionString += "; Convert Zero Datetime=true";
                MySqlCommand comando = new MySqlCommand();
                MySqlBackup respaldo = new MySqlBackup(comando);
                comando.Connection = con;
                con.Open();
                respaldo.ExportToFile(ruta);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }

        public void Restaurar(string ruta)
        {
            try
            {
                string cadena = "datasource =localhost; database =new_mastertrade_backup; port =3306; user =root; password =; sslMode = none";
                MySqlConnection new_con = new MySqlConnection(cadena);

                MySqlCommand comando = new MySqlCommand();
                MySqlBackup respaldo = new MySqlBackup(comando);
                comando.Connection = new_con;
                new_con.Open();
                respaldo.ImportFromFile(ruta);
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
