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
    internal class CRUD_Garantia : Conexion
    {
        public DataTable Tabla()
        {
            try
            {
                con.Open();
                DataTable resultados = new DataTable();
                using (MySqlCommand command = new MySqlCommand())
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT g.id_gar, ov.num_ove, p.ser_pro, p.des_pro, dv.can_dve, g.fin_gar, g.ffi_gar FROM garantia g INNER JOIN detalle_venta dv ON g.id_dve = dv.id_dve INNER JOIN producto p ON dv.id_pro = p.id_pro INNER JOIN orden_venta ov ON dv.id_ove = ov.id_ove", con);
                    adapter.Fill(resultados);
                }
                Console.WriteLine("Tabla encontrada!");
                return resultados;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
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
                    MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT g.id_gar, ov.num_ove, p.ser_pro, p.des_pro, dv.can_dve, g.fin_gar, g.ffi_gar FROM garantia g INNER JOIN detalle_venta dv ON g.id_dve = dv.id_dve INNER JOIN producto p ON dv.id_pro = p.id_pro INNER JOIN orden_venta ov ON dv.id_ove = ov.id_ove WHERE ov.num_ove LIKE '"+filtro+"%' OR p.id_pro LIKE '" + filtro + "%' OR P.des_pro LIKE '" + filtro + "%' OR g.fin_gar LIKE '" + filtro + "%' OR g.ffi_gar LIKE '" + filtro + "%'", con);
                    adapter.Fill(resultados);
                }
                Console.WriteLine("Tabla encontrada!");
                return resultados;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            return null;
        }

        public DataTable GarantiasVigentes()
        {
            try
            {
                con.Open();
                DataTable resultados = new DataTable();
                using (MySqlCommand command = new MySqlCommand())
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT g.id_gar, ov.num_ove, p.ser_pro, p.des_pro, dv.can_dve, g.fin_gar, g.ffi_gar FROM garantia g INNER JOIN detalle_venta dv ON g.id_dve = dv.id_dve INNER JOIN producto p ON dv.id_pro = p.id_pro INNER JOIN orden_venta ov ON dv.id_ove = ov.id_ove WHERE g.ffi_gar < "+System.DateTime.Now.Date, con);
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
            finally
            {
                con.Close();
            }
            return null;
        }

        public DataTable GarantiasExpiradas()
        {
            try
            {
                con.Open();
                DataTable resultados = new DataTable();
                using (MySqlCommand command = new MySqlCommand())
                {
                    MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT g.id_gar, ov.num_ove, p.ser_pro, p.des_pro, dv.can_dve, g.fin_gar, g.ffi_gar FROM garantia g INNER JOIN detalle_venta dv ON g.id_dve = dv.id_dve INNER JOIN producto p ON dv.id_pro = p.id_pro INNER JOIN orden_venta ov ON dv.id_ove = ov.id_ove WHERE g.ffi_gar > " + System.DateTime.Now.Date, con);
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
            finally
            {
                con.Close();
            }
            return null;
        }
    }
}
