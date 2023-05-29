using FormGanado.Clases.ComboBox;
using FormGanado.Clases.Registro;
using System;
using System.Windows.Forms;

namespace FormGanado
{
    public partial class FormGestionGanado : Form
    {
        public FormGestionGanado()
        {
            InitializeComponent();

            //Cargar ranchos,tipo de ganado cbx
            GetDatosCbx datosCombo = new GetDatosCbx();
            cbxRegistroRancho.Items.AddRange(datosCombo.GetRanchos().ToArray());
            cbxRegistroTipoGanado.Items.AddRange(datosCombo.GetGanadoTipo().ToArray());

            dgvCargarDatos();
        }

        //Cargar datos cbx propietarios
        private void cbxRegistroRancho_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxRegistroPropietario.Items.Clear();
            
            string rancho = cbxRegistroRancho.SelectedItem.ToString();

            GetDatosCbx datosCombo = new GetDatosCbx();
            cbxRegistroPropietario.Items.AddRange(datosCombo.GetRanchoPropietarios(rancho).ToArray());
            cbxRegistroPropietario.SelectedIndex = 0;
        }

        //Cargar datos cbx raza
        private void cbxRegistroTipoGanado_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxRegistroRaza.Items.Clear();

            string ganado = cbxRegistroTipoGanado.SelectedItem.ToString();

            GetDatosCbx datosCombo = new GetDatosCbx();
            cbxRegistroRaza.Items.AddRange(datosCombo.GetGanadoRazas(ganado).ToArray());
            cbxRegistroRaza.SelectedIndex = 0;
        }

        //Registro de datos
        private void btnRegistro_Click(object sender, EventArgs e)
        {
            GetDatosCbx datos = new GetDatosCbx();
            Ganado ganadoRegistro = new Ganado(cbxRegistroRancho.Text,cbxRegistroPropietario.Text,cbxRegistroTipoGanado.Text,cbxRegistroRaza.Text,txtRegistroMarquilla.Text,rtbRegistroDescipcion.Text,dtpRegistroFechaNacimiento.Text,Convert.ToDouble(txtRegistroPeso.Text),datos.GetGanadoRazaValor(cbxRegistroTipoGanado.Text,cbxRegistroRaza.Text),Convert.ToDouble(txtRegistroValorVentaKgP.Text));

            RegistroGanado registro = new RegistroGanado(ganadoRegistro);

            dgvCargarDatos();

            //Clear
            cbxRegistroRancho.SelectedIndex = 0;
            cbxRegistroTipoGanado.SelectedIndex = 0;
            txtRegistroMarquilla.Text = "";
            rtbRegistroDescipcion.Text = "";
            txtRegistroPeso.Text = "";
            txtRegistroValorVentaKgP.Text = "";
            dtpRegistroFechaNacimiento.ResetText();
        }

        //Cargar datos al dataGridView
        private void dgvCargarDatos() {
            DatosRegistros registros = new DatosRegistros();

            if (registros.Ganados != null) {
                var datos = new BindingSource();
                datos.DataSource = registros.Ganados;
                dgvRegistros.DataSource = datos;
                dgvHeaders(dgvRegistros);
            }
        }

        private void dgvHeaders(DataGridView dataGrid) {
            dataGrid.Columns[0].HeaderText = "Rancho";
            dataGrid.Columns[1].HeaderText = "Propietario";
            dataGrid.Columns[2].HeaderText = "Tipo de ganado";
            dataGrid.Columns[3].HeaderText = "Raza";
            dataGrid.Columns[4].HeaderText = "Marquilla";
            dataGrid.Columns[5].HeaderText = "Descripción";
            dataGrid.Columns[6].HeaderText = "Fecha de nacimiento";
            dataGrid.Columns[7].HeaderText = "Edad años";
            dataGrid.Columns[8].HeaderText = "Peso Kg";
            dataGrid.Columns[9].HeaderText = "Valor por Kg";
            dataGrid.Columns[10].HeaderText = "Valor";
            dataGrid.Columns[11].HeaderText = "%Venta valor kg";
            dataGrid.Columns[12].HeaderText = "Venta ganancia por Kg";
            dataGrid.Columns[13].HeaderText = "Venta ganancia total";
            dataGrid.Columns[14].HeaderText = "Venta total";
        }
    }
}
