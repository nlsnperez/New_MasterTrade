using CrystalDecisions.Shared;
using New_MasterTrade.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace New_MasterTrade
{
    public partial class FormReportes : Form
    {
        public FormReportes(object reporte)
        {
            InitializeComponent();
            AbrirReporte(reporte);
        }

        private void AbrirReporte(object reporte)
        {
            try
            {
                CRV_Ventana.ReportSource = reporte;
                CRV_Ventana.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
