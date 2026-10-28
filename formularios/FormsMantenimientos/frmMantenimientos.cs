using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VehiculosDB.Core.Clases;
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

        private int? GetIdSeleccionado()
        {
            if (dgvMantenimiento.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un registo", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            if (dgvMantenimiento.CurrentRow.DataBoundItem is Mantenimientos paMantenimientos)
                return paMantenimientos.IdMantenimiento;

            return null;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmInsertarMantenimiento frm = new frmInsertarMantenimiento();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                Cargar();

            }


        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var id = GetIdSeleccionado();
            if (!id.HasValue)
            {
                MessageBox.Show("Seleccione un registro");
                return;
            }

            var respuesta = MessageBox.Show(
                "¿Desea eliminar el registro seleccionado?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.No)
                return;

            try
            {
                if (mantenimientosDao.delete(id.Value))
                {
                    Cargar();
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar el registro.",
                        "Aviso",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show("No se pudo eliminar el registro" + ex.Message,
                    "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            var id = GetIdSeleccionado();
            if (!id.HasValue)
            {
                MessageBox.Show("Seleccione una fila");
                return;
            }
           

            frmActualizarMantenimiento frm = new frmActualizarMantenimiento(id.Value);

            if (frm.ShowDialog() == DialogResult.OK) { 
            
                Cargar();
            }
        }
    }
}
