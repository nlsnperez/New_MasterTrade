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
    internal class CRUD_IMMOTA : Conexion
    {
        public DataTable TablaImpuestos()
        {
            try
            {
                con.Open();
                DataTable resultados = new DataTable();
                using (MySqlCommand command = new MySqlCommand())
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM `impuesto`", con);
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

        public void Create_Impuesto(string impuesto, decimal porcentaje)
        {
            try
            {
                con.Open();
                using (MySqlCommand command = new MySqlCommand())
                {
                    command.CommandText = "INSERT INTO `impuesto`(`des_imp`, `por_imp`, `act_imp`) VALUES (@impuesto,@porcentaje,@activo)";
                    command.CommandType = CommandType.Text;
                    command.Connection = con;

                    command.Parameters.Add("@impuesto", MySqlDbType.VarChar).Value = impuesto.ToUpper();
                    command.Parameters.Add("@porcentaje", MySqlDbType.Decimal).Value = porcentaje;
                    command.Parameters.Add("@activo", MySqlDbType.Int32).Value = 1;

                    command.ExecuteNonQuery();
                }
                MessageBox.Show("El registro se registró de manera satisfactoria.", "¡DATOS ACTUALIZADOS!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public void Update_Impuesto(int id, string impuesto, decimal porcentaje)
        {
            try
            {
                con.Open();
                using (MySqlCommand command = new MySqlCommand())
                {
                    command.CommandText = "UPDATE `impuesto` SET `des_imp`=@impuesto,`por_imp`=@porcentaje WHERE `id_imp` = @id";
                    command.CommandType = CommandType.Text;
                    command.Connection = con;

                    command.Parameters.Add("@impuesto", MySqlDbType.VarChar).Value = impuesto.ToUpper();
                    command.Parameters.Add("@porcentaje", MySqlDbType.Decimal).Value = porcentaje;
                    command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;

                    command.ExecuteNonQuery();
                }
                MessageBox.Show("El registro se actualizó de manera satisfactoria.", "¡DATOS ACTUALIZADOS!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public void Delete_Impuesto(int id, int x)
        {
            string mensaje = "";
            try
            {
                con.Open();
                using (MySqlCommand command = new MySqlCommand())
                {
                    command.CommandText = "UPDATE `impuesto` SET `act_imp`=@activo WHERE `id_imp` = @id";
                    command.CommandType = CommandType.Text;
                    command.Connection = con;

                    command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
                    command.Parameters.Add("@activo", MySqlDbType.Int32).Value = x;

                    command.ExecuteNonQuery();
                }

                if (x == 0)
                {
                    mensaje = "El registro se eliminó de manera satisfactoria.";
                }
                else
                {
                    mensaje = "El registro se restauró de manera satisfactoria.";
                }

                MessageBox.Show(mensaje, "¡DATOS ACTUALIZADOS!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public int NuevoId_Impuesto()
        {
            int x = 0;
            try
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM impuesto ORDER BY id_imp DESC", con);
                con.Open();
                MySqlDataReader reader = command.ExecuteReader();
                reader.Read();
                if (reader.HasRows) x = reader.GetInt32(0);
                reader.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
            return x + 1;
        }

        public DataTable TablaMoneda()
        {
            try
            {
                con.Open();
                DataTable resultados = new DataTable();
                using (MySqlCommand command = new MySqlCommand())
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM `moneda`", con);
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

        public void Create_Moneda(string moneda)
        {
            try
            {
                con.Open();
                using (MySqlCommand command = new MySqlCommand())
                {
                    command.CommandText = "INSERT INTO `moneda`(`nom_mon`, `act_mon`) VALUES (@moneda,@activo)";
                    command.CommandType = CommandType.Text;
                    command.Connection = con;

                    command.Parameters.Add("@moneda", MySqlDbType.VarChar).Value = moneda.ToUpper();
                    command.Parameters.Add("@activo", MySqlDbType.Int32).Value = 1;

                    command.ExecuteNonQuery();
                }
                MessageBox.Show("El registro se registró de manera satisfactoria.", "¡DATOS ACTUALIZADOS!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public void Update_Moneda(int id, string moneda)
        {
            try
            {
                con.Open();
                using (MySqlCommand command = new MySqlCommand())
                {
                    command.CommandText = "UPDATE `moneda` SET `nom_mon`=@moneda WHERE `id_mon` = @id";
                    command.CommandType = CommandType.Text;
                    command.Connection = con;

                    command.Parameters.Add("@moneda", MySqlDbType.VarChar).Value = moneda.ToUpper();
                    command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;

                    command.ExecuteNonQuery();
                }
                MessageBox.Show("El registro se actualizó de manera satisfactoria.", "¡DATOS ACTUALIZADOS!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public void Delete_Moneda(int id, int x)
        {
            string mensaje = "";
            try
            {
                con.Open();
                using (MySqlCommand command = new MySqlCommand())
                {
                    command.CommandText = "UPDATE `moneda` SET `act_mon`=@activo WHERE `id_mon` = @id";
                    command.CommandType = CommandType.Text;
                    command.Connection = con;

                    command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
                    command.Parameters.Add("@activo", MySqlDbType.Int32).Value = x;

                    command.ExecuteNonQuery();
                }

                if (x == 0)
                {
                    mensaje = "El registro se eliminó de manera satisfactoria.";
                }
                else
                {
                    mensaje = "El registro se restauró de manera satisfactoria.";
                }

                MessageBox.Show(mensaje, "¡DATOS ACTUALIZADOS!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public int NuevoId_Moneda()
        {
            int x = 0;
            try
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM moneda ORDER BY id_mon DESC", con);
                con.Open();
                MySqlDataReader reader = command.ExecuteReader();
                reader.Read();
                if (reader.HasRows) x = reader.GetInt32(0);
                reader.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
            return x + 1;
        }

        public DataTable TablaTasaCambio(int id)
        {
            try
            {
                con.Open();
                DataTable resultados = new DataTable();
                using (MySqlCommand command = new MySqlCommand())
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM `tasa_cambio` WHERE id_mon = "+id, con);
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

        public void Create_TasaCambio(int moneda, string tasa_cambio, decimal valor)
        {
            try
            {
                con.Open();
                using (MySqlCommand command = new MySqlCommand())
                {
                    command.CommandText = "INSERT INTO `tasa_cambio`(`id_mon`, `des_tca`, `val_tca`, `act_tca`) VALUES (@moneda,@tasacambio,@valor,@activo)";
                    command.CommandType = CommandType.Text;
                    command.Connection = con;

                    command.Parameters.Add("@moneda", MySqlDbType.Int32).Value = moneda;
                    command.Parameters.Add("@tasacambio", MySqlDbType.VarChar).Value = tasa_cambio.ToUpper();
                    command.Parameters.Add("@valor", MySqlDbType.VarChar).Value = valor;
                    command.Parameters.Add("@activo", MySqlDbType.Int32).Value = 1;

                    command.ExecuteNonQuery();
                }
                MessageBox.Show("El registro se registró de manera satisfactoria.", "¡DATOS ACTUALIZADOS!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public void Update_TasaCambio(int id, string tasa_cambio, decimal valor)
        {
            try
            {
                con.Open();
                using (MySqlCommand command = new MySqlCommand())
                {
                    command.CommandText = "UPDATE `tasa_cambio` SET `des_tca`=@tasacambio,`val_tca`=@valor WHERE `id_tca` = @id";
                    command.CommandType = CommandType.Text;
                    command.Connection = con;

                    command.Parameters.Add("@tasacambio", MySqlDbType.VarChar).Value = tasa_cambio.ToUpper();
                    command.Parameters.Add("@valor", MySqlDbType.Decimal).Value = valor;
                    command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;

                    command.ExecuteNonQuery();
                }
                MessageBox.Show("El registro se actualizó de manera satisfactoria.", "¡DATOS ACTUALIZADOS!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public void Delete_TasaCambio(int id, int x)
        {
            string mensaje = "";
            try
            {
                con.Open();
                using (MySqlCommand command = new MySqlCommand())
                {
                    command.CommandText = "UPDATE `tasa_cambio` SET `act_tca`=@activo WHERE `id_tca` = @id";
                    command.CommandType = CommandType.Text;
                    command.Connection = con;

                    command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
                    command.Parameters.Add("@activo", MySqlDbType.Int32).Value = x;

                    command.ExecuteNonQuery();
                }

                if (x == 0)
                {
                    mensaje = "El registro se eliminó de manera satisfactoria.";
                }
                else
                {
                    mensaje = "El registro se restauró de manera satisfactoria.";
                }

                MessageBox.Show(mensaje, "¡DATOS ACTUALIZADOS!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public int NuevoId_TasaCambio()
        {
            int x = 0;
            try
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM tasa_cambio ORDER BY id_tca DESC", con);
                con.Open();
                MySqlDataReader reader = command.ExecuteReader();
                reader.Read();
                if (reader.HasRows) x = reader.GetInt32(0);
                reader.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
            return x + 1;
        }

        public string NombreMoneda(int id)
        {
            string x = "";
            try
            {
                MySqlCommand command = new MySqlCommand("SELECT m.nom_mon FROM tasa_cambio tc INNER JOIN moneda m ON tc.id_mon = m.id_mon WHERE tc.id_mon = "+id, con);
                con.Open();
                MySqlDataReader reader = command.ExecuteReader();
                reader.Read();
                if (reader.HasRows) x = reader.GetString(0);
                reader.Close();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
            return x;
        }
    }
}
