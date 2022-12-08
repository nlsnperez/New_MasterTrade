using MySql.Data.MySqlClient;
using New_MasterTrade.Objetos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New_MasterTrade.Base_de_Datos
{
    class CRUD_Compras : Conexion
    {
        public void Crear(Compra compra)
        {
            try
            {
                con.Open();
                using (MySqlCommand command = new MySqlCommand())
                {
                    command.CommandText = "INSERT INTO `orden_compra`(`id_oco`, `id_prv`, `id_tca`, `num_oco`, `tot_oco`, `fec_oco`, `hor_oco`, `act_oco`) VALUES (@id, @proveedor,@tasacambio,@norden,@total,@fecha,@hora,@activo)";
                    command.CommandType = CommandType.Text;
                    command.Connection = con;

                    command.Parameters.Add("@id", MySqlDbType.Int32).Value = compra.Id;
                    command.Parameters.Add("@proveedor", MySqlDbType.Int32).Value = compra.Proveedor;
                    command.Parameters.Add("@tasacambio", MySqlDbType.Int32).Value = compra.TasaCambio;
                    command.Parameters.Add("@norden", MySqlDbType.VarChar).Value = compra.NumeroOrden;
                    command.Parameters.Add("@total", MySqlDbType.Decimal).Value = compra.Total;
                    command.Parameters.Add("@fecha", MySqlDbType.Date).Value = System.DateTime.Today;
                    command.Parameters.Add("@hora", MySqlDbType.Time).Value = System.DateTime.Now.TimeOfDay;
                    command.Parameters.Add("@activo", MySqlDbType.Int32).Value = 1;

                    command.ExecuteNonQuery();
                    MessageBox.Show("La orden de compra fue registrada con éxito.", "¡REGISTRO EXITOSO!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        command.CommandText = "INSERT INTO `detalle_compra`(`id_oco`, `id_pro`, `can_dco`, `tot_dco`) VALUES (@ocompra,@producto,@cantidad,@total)";
                        command.CommandType = CommandType.Text;
                        command.Connection = con;

                        command.Parameters.Add("@ocompra", MySqlDbType.Int32).Value = detalle[i].IdOrden;
                        command.Parameters.Add("@producto", MySqlDbType.Int32).Value = detalle[i].Producto;
                        command.Parameters.Add("@cantidad", MySqlDbType.Int32).Value = detalle[i].Cantidad;
                        command.Parameters.Add("@total", MySqlDbType.Decimal).Value = detalle[i].TotalBs;

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

        public int GetIdCompras()
        {
            int x = 0;
            try
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM `orden_compra` ORDER BY id_oco DESC", con);
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
            return x+1;
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

        public DataTable Compras()
        {
            DataTable facturas = new DataTable();
            String sql = "SELECT oc.*, p.raz_prv FROM orden_compra oc INNER JOIN proveedor p ON oc.id_prv = p.id_prv ORDER BY id_oco ASC";
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

        public DataTable BuscarCompras(string filtro)
        {
            DataTable facturas = new DataTable();
            String sql = "SELECT oc.*, p.raz_prv FROM orden_compra oc INNER JOIN proveedor p ON oc.id_prv = p.id_prv WHERE oc.id_oco LIKE '%" + filtro + "%' OR p.raz_prv LIKE '%" + filtro + "%' OR oc.num_oco LIKE '%" + filtro+ "%' OR p.doc_prv LIKE '%" + filtro+"%' ORDER BY id_oco ASC";
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

        public DataTable Moneda()
        {
            DataTable facturas = new DataTable();
            String sql = "SELECT * FROM moneda WHERE act_mon = 1 ORDER BY id_mon ASC";
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

        public DataTable TasaDeCambio(int id)
        {
            DataTable facturas = new DataTable();
            String sql = "SELECT * FROM tasa_cambio WHERE act_tca = 1 AND id_mon = "+id;
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

        public decimal Valor_TasaCambio(int id)
        {
            decimal x = 0;
            try
            {
                MySqlCommand command = new MySqlCommand("SELECT * FROM `tasa_cambio` WHERE id_tca = "+id+"", con);
                con.Open();
                MySqlDataReader reader = command.ExecuteReader();
                reader.Read();
                if (reader.HasRows) x = reader.GetDecimal(3);
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
