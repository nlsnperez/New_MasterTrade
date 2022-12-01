using New_MasterTrade.Base_de_Datos;
using New_MasterTrade.Cache;
using New_MasterTrade.UserControls;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace New_MasterTrade
{
    public partial class SesionIniciada : Form
    {
        CRUD_Bitacora bitacora = new CRUD_Bitacora();
        CRUD_Usuarios usuario = new CRUD_Usuarios();
        Panel p = new Panel();
        public SesionIniciada()
        {
            InitializeComponent();
            bitacora.Create(UserData.Id, Modulos.InicioSesion, Accion.IniciarSesion(UserData.NombreUsuario));
        }

        private void SesionIniciada_Load(object sender, EventArgs e)
        {
            bttnClientes_Click(null, e);
            Config();
        }

        public void Config()
        {
            if (UserData.Nivel == 2)
            {
                bttnReportes.Visible = false;
                bttnMantenimiento.Visible = false;
                bttnAjustes.Visible = false;
                if (usuario.IsVendedor(UserData.Id))
                {
                    panelTransacciones.Size = new Size(160, 38);
                }
                else
                {
                    bttnTransacciones.Visible = false;
                }
            }
        }

        public void CerrarPaneles()
        {
            panelArchivo.Visible = false;
            panelTransacciones.Visible = false;
            panelReportes.Visible = false;
            panelMantenimiento.Visible = false;
            panelAjustes.Visible = false;

            bttnArchivo.Image = Properties.Resources.FlechaAbajo;
            bttnTransacciones.Image = Properties.Resources.FlechaAbajo;
            bttnMantenimiento.Image = Properties.Resources.FlechaAbajo;
            bttnReportes.Image = Properties.Resources.FlechaAbajo;
        }

        private void bttnMouseEnter(object sender, EventArgs e)
        {
            Button bttn = sender as Button;
            panelMenu.Controls.Add(p);
            p.BackColor = Color.FromArgb(255, 212, 100);
            p.Size = new Size(160, 5);
            p.Location = new Point(bttn.Location.X, bttn.Location.Y + 38);
        }

        private void MostrarUserControl(object pantalla)
        {
            if (panelContenedor.Controls.Count > 0) panelContenedor.Controls.Clear();
            UserControl control = pantalla as UserControl;
            control.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(control);
            this.panelContenedor.Tag = control;
            control.Show();
        }

        private void MostrarDialog(object pantalla)
        {
            UserControl control = pantalla as UserControl;
            Form x = new Form();
            x.Size = control.Size;
            x.StartPosition = FormStartPosition.CenterScreen;
            x.FormBorderStyle = FormBorderStyle.None;
            x.Controls.Add(control);
            x.ShowDialog();
        }

        private void bttnMouseLeave(object sender, EventArgs e)
        {
            panelMenu.Controls.Remove(p);
        }

        private void bttnSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar sesión?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Login salir_al_login = new Login();
                bitacora.Create(UserData.Id, Modulos.CerrarSesion, Accion.CerrarSesion(UserData.NombreUsuario));
                this.Hide();
                this.Dispose();
                salir_al_login.Show();
            }
        }

        private void bttnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }    

        private void bttnProductos_Click(object sender, EventArgs e)
        {
            MostrarUserControl(new Productos());
            CerrarPaneles();
        }

        private void bttnComprar_Click(object sender, EventArgs e)
        {
            MostrarUserControl(new Comprar());
            CerrarPaneles();
        }

        private void bttnUsuarios_Click(object sender, EventArgs e)
        {
            MostrarUserControl(new Usuarios());
            CerrarPaneles();
        }

        private void bttnArchivo_Click(object sender, EventArgs e)
        {
            if (panelArchivo.Visible == false)
            {
                panelArchivo.Visible = true;
                bttnArchivo.Image = Properties.Resources.FlechaArriba;

                panelTransacciones.Visible = false;
                bttnTransacciones.Image = Properties.Resources.FlechaAbajo;

                panelReportes.Visible = false;
                bttnReportes.Image = Properties.Resources.FlechaAbajo;

                panelMantenimiento.Visible = false;
                bttnMantenimiento.Image = Properties.Resources.FlechaAbajo;

                panelAjustes.Visible = false;
            }
            else
            {
                panelArchivo.Visible = false;
                bttnArchivo.Image = Properties.Resources.FlechaAbajo;
            }
        }

        private void bttnTransacciones_Click(object sender, EventArgs e)
        {
            if (panelTransacciones.Visible == false)
            {
                panelTransacciones.Visible = true;
                bttnTransacciones.Image = Properties.Resources.FlechaArriba;

                panelArchivo.Visible = false;
                bttnArchivo.Image = Properties.Resources.FlechaAbajo;

                panelReportes.Visible = false;
                bttnReportes.Image = Properties.Resources.FlechaAbajo;

                panelMantenimiento.Visible = false;
                bttnMantenimiento.Image = Properties.Resources.FlechaAbajo;

                panelAjustes.Visible = false;
            }
            else
            {
                panelTransacciones.Visible = false;
                bttnTransacciones.Image = Properties.Resources.FlechaAbajo;
            }
        }

        private void bttnMantenimiento_Click(object sender, EventArgs e)
        {
            if (panelMantenimiento.Visible == false)
            {
                panelMantenimiento.Visible = true;
                bttnMantenimiento.Image = Properties.Resources.FlechaArriba;

                panelArchivo.Visible = false;
                bttnArchivo.Image = Properties.Resources.FlechaAbajo;

                panelTransacciones.Visible = false;
                bttnTransacciones.Image = Properties.Resources.FlechaAbajo;

                panelReportes.Visible = false;
                bttnReportes.Image = Properties.Resources.FlechaAbajo;

                panelAjustes.Visible = false;
            }
            else
            {
                panelMantenimiento.Visible = false;
                bttnMantenimiento.Image = Properties.Resources.FlechaAbajo;
            }
        }

        private void bttnVender_Click(object sender, EventArgs e)
        {
            MostrarUserControl(new Vender());
            CerrarPaneles();
        }

        private void bttnCompras_Click(object sender, EventArgs e)
        {
            MostrarUserControl(new Compras());
            CerrarPaneles();
        }

        private void bttnVentas_Click(object sender, EventArgs e)
        {
            MostrarUserControl(new Ventas());
            CerrarPaneles();
        }

        private void bttnBitacora_Click(object sender, EventArgs e)
        {
            MostrarUserControl(new RegistrosBitacora());
            CerrarPaneles();
        }

        private void bttnAjustes_Click(object sender, EventArgs e)
        {
            panelMantenimiento.Visible = false;
        }

        private void bttnProveedores_Click(object sender, EventArgs e)
        {
            MostrarUserControl(new Proveedores());
            CerrarPaneles();
        }

        private void bttnClientes_Click(object sender, EventArgs e)
        {
            MostrarUserControl(new Clientes());
            CerrarPaneles();
        }

        private void bttnRespaldo_Click(object sender, EventArgs e)
        {
            MostrarUserControl(new Respaldos());
            CerrarPaneles();
        }

        private void bttnReportes_Click(object sender, EventArgs e)
        {
            if (panelReportes.Visible == false)
            {
                panelReportes.Visible = true;
                bttnReportes.Image = Properties.Resources.FlechaArriba;

                panelArchivo.Visible = false;
                bttnArchivo.Image = Properties.Resources.FlechaAbajo;

                panelTransacciones.Visible = false;
                bttnTransacciones.Image = Properties.Resources.FlechaAbajo;

                panelMantenimiento.Visible = false;
                bttnMantenimiento.Image = Properties.Resources.FlechaAbajo;

                panelAjustes.Visible = false;
            }
            else
            {
                panelReportes.Visible = false;
                bttnReportes.Image = Properties.Resources.FlechaAbajo;
            }
        }

        private void bttnAjustes_Click_1(object sender, EventArgs e)
        {
            if (panelAjustes.Visible == false)
            {
                panelAjustes.Visible = true;

                panelArchivo.Visible = false;
                bttnArchivo.Image = Properties.Resources.FlechaAbajo;

                panelTransacciones.Visible = false;
                bttnTransacciones.Image = Properties.Resources.FlechaAbajo;

                panelReportes.Visible = false;
                bttnReportes.Image = Properties.Resources.FlechaAbajo;

                panelMantenimiento.Visible = false;
                bttnMantenimiento.Image = Properties.Resources.FlechaAbajo;
            }
            else
            {
                panelAjustes.Visible = false;
            }
        }

        private void bttnCategorias_Click(object sender, EventArgs e)
        {
            MostrarDialog(new Categorias());
            CerrarPaneles();
        }

        private void bttnMarcas_Click(object sender, EventArgs e)
        {
            
            MostrarDialog(new Marcas());
            CerrarPaneles();
        }

        private void bttnModelos_Click(object sender, EventArgs e)
        {
            
            MostrarDialog(new Modelos());
            CerrarPaneles();
        }

        private void bttnReportesCliente_Click(object sender, EventArgs e)
        {
            MostrarUserControl(new ReportesCliente());
            CerrarPaneles();
        }

        private void bttnReportesProveedor_Click(object sender, EventArgs e)
        {
            MostrarUserControl(new ReportesProveedor());
            CerrarPaneles();
        }

        private void bttnReportesProducto_Click(object sender, EventArgs e)
        {
            MostrarUserControl(new ReportesProducto());
            CerrarPaneles();
        }

        private void bttnImpuestos_Click(object sender, EventArgs e)
        {
            MostrarDialog(new Impuestos());
            CerrarPaneles();
        }

        private void bttnMonedas_Click(object sender, EventArgs e)
        {
            MostrarDialog(new Monedas());
            CerrarPaneles();
        }

        private void bttnVendedores_Click(object sender, EventArgs e)
        {
            MostrarUserControl(new Vendedores());
            CerrarPaneles();
        }

        private void bttnGarantias_Click(object sender, EventArgs e)
        {
            MostrarUserControl(new Garantias());
            CerrarPaneles();
        }

        private void bttnReportesVenta_Click(object sender, EventArgs e)
        {
            CerrarPaneles();
        }

        private void bttnReportesCompra_Click(object sender, EventArgs e)
        {
            CerrarPaneles();
        }

        private void bttnMetodosPago_Click(object sender, EventArgs e)
        {
            MostrarDialog(new MetodosDePago());
            CerrarPaneles();
        }
    }
}
