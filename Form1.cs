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
    public partial class Form1 : Form
    {
        DS_Reportes ds_reportes = new DS_Reportes();
        DS_ReportesTableAdapters.DataTable_ocoTableAdapter dta_oco = new DS_ReportesTableAdapters.DataTable_ocoTableAdapter();

        public Form1()
        {
            InitializeComponent();
            AbrirReporte();
        }

        private void AbrirReporte()
        {
            try
            {
                dta_oco.Fill(ds_reportes.DataTable_oco, id_oco: 11);
                Reporte_OC reporteoc = new Reporte_OC();
                string direccion = @"~\Reportes\Reporte_OC.rpt";
                reporteoc.Load(direccion);
                reporteoc.SetDataSource(ds_reportes);
                CRV_Ventana.ReportSource = reporteoc;
                CRV_Ventana.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
