using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using VehiculosDB.Core.Clases;
using VehiculosDB.Core.Dao;

namespace VehiculosDB.formularios.FromsVehiculo
{

    public partial class frmBuscarVehiculo : Form
    {

        VehiculoDao vehiculoDao = new VehiculoDao();
        internal Vehiculos? vehiculoSeleccionado; 

        public frmBuscarVehiculo()
        {
            InitializeComponent();
        }

        private void configureCols(DataGridView dataGridView, string Name, string headerText, string dataPropertyName)
        {

            dataGridView.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = Name,
                HeaderText = headerText,
                DataPropertyName = dataPropertyName
            });
        }
        private void configuracionGrid()
        {
            dgvVehiculo.AutoGenerateColumns = false;
            dgvVehiculo.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvVehiculo.MultiSelect = false;
            dgvVehiculo.AllowUserToAddRows = false;
            dgvVehiculo.ReadOnly = true;
            dgvVehiculo.ScrollBars = ScrollBars.Vertical;
            dgvVehiculo.Columns.Clear();

            configureCols(dgvVehiculo, "PlacaCol", "Placa", "Placa");
            configureCols(dgvVehiculo, "ModeloCol", "Modelo", "Modelo");
            configureCols(dgvVehiculo, "AnioCol", "Año", "Anio");
            configureCols(dgvVehiculo, "ColorCol", "Color", "Color");
            configureCols(dgvVehiculo, "NombreMarcaCol", "Nombre Marca", "NombreMarca");
            configureCols(dgvVehiculo, "DUICol", "DUI", "DUI");
            configureCols(dgvVehiculo, "NombreTipoCol", "Nombre Tipo", "NombreTipo");



        }




        private void Carga(string filtro = "")
        {

            try
            {
                dgvVehiculo.DataSource = vehiculoDao.getAll(filtro);
                dgvVehiculo.ClearSelection();
                dgvVehiculo.CurrentCell = null;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado" + ex.Message);

            }
        }
        private void frmBuscarVehiculo_Load(object sender, EventArgs e)
        {
            configuracionGrid();
            Carga();
        }

        private void txtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            Carga(txtBuscar.Text);
        }


        private Vehiculos GetVehiculo() {
            if (dgvVehiculo.CurrentRow == null) {
                MessageBox.Show("Debe selecionar un registro ", "Aviso", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return null;
            }
            if (dgvVehiculo.CurrentRow.DataBoundItem is Vehiculos paVehiculo) {
                return paVehiculo;
            } 

            return null;

        }

        private void btnSelecionar_Click(object sender, EventArgs e)
        {
            if (GetVehiculo() == null)
            {
                MessageBox.Show("Selecione una fila");
                return;
            }
            else {

                vehiculoSeleccionado = GetVehiculo();
                this.DialogResult = DialogResult.OK;
            }

        }
    }
}
