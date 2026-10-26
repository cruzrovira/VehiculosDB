using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VehiculosDB.Core.Dao;

namespace VehiculosDB.formularios.FormsMantenimientos
{
    public partial class frmMantenimientos : Form
    {
        MantenimientosDao mantenimientosDao = new MantenimientosDao();
        public frmMantenimientos()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMantenimientos_Load(object sender, EventArgs e)
        {
            configuracionGrid();
            Cargar();
        }

        private void Cargar(string filtro = "")
        {
            try
            {

                dgvMantenimiento.DataSource = mantenimientosDao.getAll();
                dgvMantenimiento.ClearSelection();
                dgvMantenimiento.CurrentCell = null;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado" + ex.Message);

            }

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
            dgvMantenimiento.AutoGenerateColumns = false;
            dgvMantenimiento.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMantenimiento.MultiSelect = false;
            dgvMantenimiento.AllowUserToAddRows = false;
            dgvMantenimiento.ReadOnly = true;
            dgvMantenimiento.ScrollBars = ScrollBars.Vertical;
            dgvMantenimiento.Columns.Clear();

            configureCols(dgvMantenimiento, "PlacaCol", "Placa", "Placa");
            configureCols(dgvMantenimiento, "FechaCol", "Fecha", "Fecha");
            configureCols(dgvMantenimiento, "CostoCol", "Costo", "Costo");
            configureCols(dgvMantenimiento, "ObservacionesCol", "Observaciones", "Observaciones");
            configureCols(dgvMantenimiento, "NombreTipoCol", "NombreTipo", "NombreTipo");


        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmInsertarMantenimiento frm = new frmInsertarMantenimiento();
            if (frm.ShowDialog() == DialogResult.OK) {
                Cargar();

            }
                
                
         }
    }
}
