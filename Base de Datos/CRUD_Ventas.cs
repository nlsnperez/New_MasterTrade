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
    class CRUD_Ventas : Conexion
    {
        public void Crear(Venta venta)
        {
            try
            {
                con.Open();
                using (MySqlCommand command = new MySqlCommand())
                {
                    command.CommandText = "INSERT INTO `orden_venta`(`id_cli`, `num_ove`, `fec_ove`) VALUES (@cliente,@norden,@fecha)";
                    command.CommandType = CommandType.Text;
                    command.Connection = con;

                    command.Parameters.Add("@cliente", MySqlDbType.VarChar).Value = venta.Cliente; 
                    command.Parameters.Add("@norden", MySqlDbType.VarChar).Value = venta.NumeroOrden;
                    command.Parameters.Add("@fecha", MySqlDbType.DateTime).Value = venta.Fecha;

                    command.ExecuteNonQuery();
                    MessageBox.Show("La orden de venta fue registrada con éxito.", "¡REGISTRO EXITOSO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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

        public void CrearDetalle(List<Detalle> detalle)
        {
            for (int i = 0; i <= detalle.Count - 1; i++)
            {
                try
                {
                    con.Open();
                    using (MySqlCommand command = new MySqlCommand())
                    {
                        command.CommandText = "INSERT INTO `detalle_venta`(`id_ove`, `id_pro`, `can_dve`, `tbs_dve`, `tus_dve`) VALUES (@oventa,@producto,@cantidad,@totBs,@totUsd)";
                        command.CommandType = CommandType.Text;
                        command.Connection = con;

                        command.Parameters.Add("@oventa", MySqlDbType.Int32).Value = detalle[i].IdOrden;
                        command.Parameters.Add("@producto", MySqlDbType.Int32).Value = detalle[i].Producto;
                        command.Parameters.Add("@cantidad", MySqlDbType.Int32).Value = detalle[i].Cantidad;
                        command.Parameters.Add("@totBs", MySqlDbType.Decimal).Value = detalle[i].TotalBs;
                        command.Parameters.Add("@totUsd", MySqlDbType.Decimal).Value = detalle[i].TotalUSD;

                        command.ExecuteNonQuery();
                        Console.WriteLine("Detalle registrado "+i+"!");
                    }
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
        }

        public int GetIdVentas()
        {
            int x = 0;
            try
            {
                MySqlCommand command = new MySqlCommand("SELECT COUNT(`id_ove`) AS ventas FROM orden_venta", con);
                con.Open();
                MySqlDataReader reader = command.ExecuteReader();
                reader.Read();
                if (reader.HasRows) x = Int32.Parse(reader["ventas"].ToString());
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

        public DataTable Impuestos()
        {
            DataTable categorias = new DataTable();
            String sql = "SELECT * FROM `impuesto`";
            con.Open();
            try
            {
                MySqlCommand comando = new MySqlCommand(sql, con);
                MySqlDataAdapter adaptador = new MySqlDataAdapter(comando);
                adaptador.Fill(categorias);
                return categorias;
            }
            catch (MySqlException ex)
            {

                MessageBox.Show(ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }
            return categorias;
        }
    }
}
