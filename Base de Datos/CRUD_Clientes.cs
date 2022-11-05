using MySql.Data.MySqlClient;
using New_MasterTrade.Objetos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New_MasterTrade.Base_de_Datos
{
    class CRUD_Clientes : Conexion
    {
        public void Create(Persona persona)
        {
            try
            {
                con.Open();
                using (MySqlCommand command = new MySqlCommand())
                {
                    command.CommandText = "INSERT INTO `cliente`(`doc_cli`, `raz_cli`, `dir_cli`, `tel_cli`, `cor_cli`, `act_cli`) VALUES (@documento,@nombre,@direccion,@telefono,@email, @act)";
                    command.CommandType = CommandType.Text;
                    command.Connection = con;

                    command.Parameters.Add("@documento", MySqlDbType.VarChar).Value = persona.Documento;
                    command.Parameters.Add("@nombre", MySqlDbType.VarChar).Value = persona.RazonSocial;
                    command.Parameters.Add("@direccion", MySqlDbType.VarChar).Value = persona.Direccion;
                    command.Parameters.Add("@telefono", MySqlDbType.VarChar).Value = persona.Telefono;
                    command.Parameters.Add("@email", MySqlDbType.VarChar).Value = persona.Correo;
                    command.Parameters.Add("@act", MySqlDbType.Int32).Value = 1;

                    command.ExecuteNonQuery();
                }
                MessageBox.Show("El registro se completó de manera satisfactoria.", "¡REGISTRO EXITOSO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public DataTable Tabla()
        {
            try
            {
                con.Open();
                DataTable resultados = new DataTable();
                using (MySqlCommand command = new MySqlCommand())
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM `cliente`", con);
                    adapter.Fill(resultados);
                    con.Close();
                }
                Console.WriteLine("Tabla encontrada!");
                return resultados;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;
        }

        public DataTable BuscarTabla(string filtro)
        {
            try
            {
                con.Open();
                DataTable resultados = new DataTable();
                using (MySqlCommand command = new MySqlCommand())
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM `cliente`  WHERE `doc_cli` LIKE '%" + filtro + "%' OR `raz_cli` LIKE '%" + filtro + "%' ORDER BY id_cli ASC", con);
                    adapter.Fill(resultados);
                    con.Close();
                }
                Console.WriteLine("Tabla productos encontrada!");
                return resultados;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        public DataTable ClienteDatos(string filtro)
        {
            DataTable cliente = new DataTable();
            String sql = "SELECT * FROM `cliente` WHERE `id_cli` LIKE '" + filtro + "%' OR `doc_cli` LIKE '%" + filtro + "%' OR `raz_cli` LIKE '%" + filtro + "%'";
            con.Open();
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, con);
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                adaptador.Fill(cliente);
                return cliente;
            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
            return cliente;
        }
    }
}
