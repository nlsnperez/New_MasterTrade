using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New_MasterTrade.Base_de_Datos
{
    class CRUD_Bitacora : Conexion
    {
        public void Create(int usuario, string modulo, string accion)
        {
            try
            {
                con.Open();
                using (MySqlCommand command = new MySqlCommand())
                {
                    command.CommandText = "INSERT INTO `bitacora`(`id_usu`, `mod_bit`, `acc_bit`, `fec_bit`) VALUES (@usuario,@modulo,@accion,@fecha)";
                    command.CommandType = CommandType.Text;
                    command.Connection = con;

                    command.Parameters.Add("@usuario", MySqlDbType.Int32).Value = usuario;
                    command.Parameters.Add("@modulo", MySqlDbType.VarChar).Value = modulo;
                    command.Parameters.Add("@accion", MySqlDbType.VarChar).Value = accion;
                    command.Parameters.Add("@fecha", MySqlDbType.DateTime).Value = System.DateTime.Now;

                    command.ExecuteNonQuery();
                }
                Console.WriteLine("Nueva bitacora");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public DataTable RegistrosBitacora()
        {
            DataTable bitacora = new DataTable();
            String sql = "SELECT b.*, u.usr_usu FROM bitacora b INNER JOIN usuario u ON b.id_usu = u.id_usu ORDER BY id_bit ASC";
            con.Open();
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, con);
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                adaptador.Fill(bitacora);
                return bitacora;
            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
            return bitacora;
        }

        public DataTable BuscarBitacora(string filtro)
        {
            DataTable facturas = new DataTable();
            String sql = "SELECT b.*, u.usr_usu FROM bitacora b INNER JOIN usuario u ON b.id_usu = u.id_usu WHERE b.id_bit LIKE '%" + filtro + "%' OR b.mod_bit LIKE '%" + filtro + "%' OR u.usr_usu LIKE '%" + filtro + "%' ORDER BY id_bit ASC";
            con.Open();
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, con);
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                adaptador.Fill(facturas);
                return facturas;
            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
            return facturas;
        }
    }
}
