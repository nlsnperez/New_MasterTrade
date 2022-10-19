using New_MasterTrade.Base_de_Datos;
using New_MasterTrade.Objetos;
using System;
using System.Drawing;
using System.Windows;
using System.Windows.Forms;
using MessageBox = System.Windows.Forms.MessageBox;

namespace New_MasterTrade
{
    public partial class Personas : UserControl
    {
        private CRUDPersonas crud;
        bool IsCollapsed;
        public Personas()
        {
            InitializeComponent();
        }

        private void Personas_Load(object sender, EventArgs e)
        {
            Config();
        }

        public void Config()
        {
            crud = new CRUDPersonas();
            panelSlide.Size = panelSlide.MinimumSize;
            txtDocumento.MaxLength = 9;
            txtRazonSocial.MaxLength = 100;
            txtDireccion.MaxLength = 500;
            txtTelefono.MaxLength = 15;
            txtCorreo.MaxLength = 100;
            Config_Botones("INICIO");
            tablaPersonas.AutoGenerateColumns = false;
            FillComboBoxes();
            RefreshTable(1);
        }

        //BOTONES//

        private void bttnGuardar_Click(object sender, EventArgs e)
        {
            if (GetPersona().IsEmpty())
            {
                MessageBox.Show("Complete todos los campos!");
            }
            else
            {
                if (!GetPersona().ValidDocumento())
                {
                    MessageBox.Show(GetPersona().Documento + " no es un número de documento válido. Inténtelo de nuevo.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (!GetPersona().ValidPhone())
                    {
                        MessageBox.Show(GetPersona().Telefono + " no es un número de teléfono válido. Inténtelo de nuevo.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        if (!GetPersona().ValidEmail())
                        {
                            MessageBox.Show(GetPersona().Correo.ToUpper()+" no es una dirección de correo válida. Inténtelo de nuevo.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            if (MessageBox.Show("Desea registrar el " + comboOcupacion.SelectedItem.ToString().ToLower() + ": " + GetPersona().Documento + "?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                if (comboOcupacion.SelectedIndex == 0)
                                {
                                    crud.Create(GetPersona(), "clientes");
                                    Clear();
                                    comboTabla.SelectedIndex = 0;
                                    RefreshTable(1);
                                    timerSlide.Start();
                                }
                                else
                                {
                                    crud.Create(GetPersona(), "proveedores");
                                    Clear();
                                    comboTabla.SelectedIndex = 1;
                                    RefreshTable(2);
                                    timerSlide.Start();
                                }
                            }
                        }
                    }
                }
                
            }            
        }

        private void bttnActualizar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea actualizar los datos del " + comboOcupacion.SelectedItem.ToString().ToLower() + ": " + GetPersona().Documento + "?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (comboOcupacion.SelectedIndex == 0)
                {
                    crud.Update(GetPersona(), "clientes");
                    Clear();
                    RefreshTable(1);
                    timerSlide.Start();
                }
                else
                {
                    crud.Update(GetPersona(), "proveedores");
                    Clear();
                    RefreshTable(2);
                    timerSlide.Start();
                }
            }            
        }

        private void tablaPersonas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                comboDocumento.SelectedIndex = DocumentoIndex(tablaPersonas.Rows[e.RowIndex].Cells[0].Value.ToString()[0]);
                txtDocumento.Text = tablaPersonas.Rows[e.RowIndex].Cells[0].Value.ToString().Remove(0, 1);
                txtRazonSocial.Text = tablaPersonas.Rows[e.RowIndex].Cells[1].Value.ToString();
                txtDireccion.Text = tablaPersonas.Rows[e.RowIndex].Cells[2].Value.ToString();
                txtTelefono.Text = tablaPersonas.Rows[e.RowIndex].Cells[3].Value.ToString();
                txtCorreo.Text = tablaPersonas.Rows[e.RowIndex].Cells[4].Value.ToString();
                txtDocumento.Enabled = false;
                comboDocumento.Enabled = false;
                comboTabla.Enabled = false;
                comboOcupacion.Enabled = false;
                Config_Botones("SELECCIÓN");
                if (comboTabla.SelectedIndex == 0)
                {
                    comboOcupacion.SelectedIndex = 0;
                }
                else
                {
                    comboOcupacion.SelectedIndex = 1;
                }
                timerSlide.Start();
            }
            else
            {
                if (e.ColumnIndex == 6)
                {
                    if (MessageBox.Show("Desea eliminar los datos del" + comboTabla.SelectedItem.ToString().ToLower() + ": " + tablaPersonas.Rows[e.RowIndex].Cells[0].Value.ToString() + "?", "CONFIRMAR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        if (comboTabla.SelectedIndex == 0)
                        {
                            crud.Delete(tablaPersonas.Rows[e.RowIndex].Cells[0].Value.ToString(), "clientes");
                            Clear();
                            RefreshTable(1);
                        }
                        else
                        {
                            crud.Delete(tablaPersonas.Rows[e.RowIndex].Cells[0].Value.ToString(), "proveedores");
                            Clear();
                            RefreshTable(2);
                        }
                    }
                }
            }
        }

        private void bttnCancelar_Click(object sender, EventArgs e)
        {
            Clear();
        }     
        //BOTONES//

        //CONFIGURACIÓN///

        public void Clear()
        {
            txtDocumento.Text = "";
            txtRazonSocial.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtCorreo.Text = "";
            comboOcupacion.SelectedIndex = 0;
            comboDocumento.SelectedIndex = 0;
            comboOcupacion.Enabled = true;
            comboDocumento.Enabled = true;
            txtDocumento.Enabled = true;
            comboTabla.Enabled = true;
            Config_Botones("INICIO");
        }

        
        public void FillComboBoxes()
        {
            if (comboDocumento.Items.Count > 0) comboDocumento.Items.Clear();
            if (comboOcupacion.Items.Count > 0) comboOcupacion.Items.Clear();
            if (comboTabla.Items.Count > 0) comboTabla.Items.Clear();
            comboDocumento.Items.Add("V");
            comboDocumento.Items.Add("E");
            comboDocumento.Items.Add("J");
            comboDocumento.Items.Add("G");
            comboDocumento.SelectedIndex = 0;

            comboOcupacion.Items.Add("CLIENTE");
            comboOcupacion.Items.Add("PROVEEDOR");
            comboOcupacion.SelectedIndex = 0;

            comboTabla.Items.Add("CLIENTES");
            comboTabla.Items.Add("PROVEEDORES");
            comboTabla.SelectedIndex = 0;
        }

        public void Config_Botones(String modo)
        {
            switch (modo)
            {
                case "INICIO":
                    bttnGuardar.Enabled = true;
                    bttnActualizar.Enabled = false;
                    bttnCancelar.Enabled = true;
                    break;
                case "SELECCIÓN":
                    bttnGuardar.Enabled = false;
                    bttnActualizar.Enabled = true;
                    bttnCancelar.Enabled = true;
                    break;
            }
        }

        //CONFIGURACIÓN///

        //TABLA//

        public void RefreshTable(int x)
        {
            switch (x)
            {
                case 1:
                    tablaPersonas.DataSource = crud.GetTable();
                    break;
                case 2:
                    tablaPersonas.DataSource = crud.GetTableProveedores();
                    break;
                case 3:
                    tablaPersonas.DataSource = crud.SearchTable(comboTabla.SelectedItem.ToString().ToLower(), txtBuscar.Text);
                    break;
            }
        }

        private void comboTabla_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboTabla.SelectedIndex == 0)
            {
                RefreshTable(1);
            }
            else
            {
                RefreshTable(2);
            }
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            RefreshTable(3);
        }

        //TABLA//

        public int DocumentoIndex(char x)
        {
            switch (x)
            {
                case 'V':
                    return 0;
                    break;
                case 'E':
                    return 1;
                    break;
                case 'J':
                    return 2;
                    break;
                case 'G':
                    return 3;
                    break;
            }
            return 0;
        }

        private Persona GetPersona()
        {
            Persona persona = new Persona(comboDocumento.SelectedItem.ToString() + txtDocumento.Text, txtRazonSocial.Text.ToUpper(), txtDireccion.Text.ToUpper(), txtTelefono.Text, txtCorreo.Text.ToUpper());
            return persona;
        }

        private void OnlyNumbers(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void OnlyLetters(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void timerSlide_Tick(object sender, EventArgs e)
        {
            if (IsCollapsed)
            {
                panelSlide.Width += 50;
                if (panelSlide.Size == panelSlide.MaximumSize)
                {
                    timerSlide.Stop();
                    IsCollapsed = false;
                }
            }
            else
            {
                panelSlide.Width -= 50;
                if (panelSlide.Size == panelSlide.MinimumSize)
                {
                    timerSlide.Stop();
                    IsCollapsed = true;
                }
            }
        }

        private void bttnRegistrar_Click(object sender, EventArgs e)
        {
            timerSlide.Start();
        }

        private void bttnAtras_Click(object sender, EventArgs e)
        {
            Clear();
            timerSlide.Start();
        }
    }
}
