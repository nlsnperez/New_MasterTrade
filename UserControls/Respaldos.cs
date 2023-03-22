using New_MasterTrade.Base_de_Datos;
using New_MasterTrade.Cache;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New_MasterTrade.UserControls
{
    public partial class Respaldos : UserControl
    {
        CRUD_Bitacora bitacora = new CRUD_Bitacora();
        public Respaldos()
        {
            InitializeComponent();
        }

        private void bttnGenerar_Click(object sender, EventArgs e)
        {           

            if (MessageBox.Show("¿Desea generar un respaldo de la base de datos?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                SaveFileDialog guardar = new SaveFileDialog();
                guardar.Filter = "Archivo SQL (*.sql)|*.slq";
                guardar.InitialDirectory = @"~\Base de Datos\Respaldos";
                guardar.Title = "Guardar archivo de respaldo";

                if (guardar.ShowDialog() == DialogResult.OK)
                {
                    Respaldo respaldo = new Respaldo();
                    respaldo.Respaldar(guardar.FileName);
                    bitacora.Create(UserData.Id, Modulos.Respaldos, Accion.GenerarRespaldo(UserData.NombreUsuario));
                    MessageBox.Show("La base de datos fue actualizada con éxito", "RESPALDO COMPPLETADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }            
        }

        private void bttnRestaurar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Reemplazar los registros de la base de datos por los del respaldo?\n\nEsta acción no se puede deshacer.", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                OpenFileDialog restaurar = new OpenFileDialog();
                restaurar.Filter = "Archivo SQL (*.sql)|*.slq";
                restaurar.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                restaurar.Title = "Seleccione archivo de respaldo";

                if (restaurar.ShowDialog() == DialogResult.OK)
                {
                    Respaldo respaldo = new Respaldo();
                    respaldo.Restaurar(restaurar.FileName);
                    bitacora.Create(UserData.Id, Modulos.Respaldos, Accion.RestaurarBaseDeDatos(UserData.NombreUsuario));
                    MessageBox.Show("La base de datos fue actualizada con éxito", "RESPALDO COMPPLETADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }            
        }
    }
}
