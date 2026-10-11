using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VehiculosDB.Core.Dao;

namespace VehiculosDB.formularios
{
    public partial class frmPropietario : Form
    {

        private readonly PropietarioDao propietarioDao = new PropietarioDao();
        public frmPropietario()
        {
            InitializeComponent();
        }

        private void configuracionGrid()
        {
            dgvPropietario.AutoGenerateColumns = false;
            dgvPropietario.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPropietario.MultiSelect = false;
            dgvPropietario.Columns.Clear();

            dgvPropietario.Columns.Add(new DataGridViewTextBoxColumn { Name = "NombreCol", HeaderText = "Nombre", DataPropertyName = "Nombre", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            dgvPropietario.Columns.Add(new DataGridViewTextBoxColumn { Name = "ApellidoCol", HeaderText = "Apellido", DataPropertyName = "Apellido", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            dgvPropietario.Columns.Add(new DataGridViewTextBoxColumn { Name = "DUICol", HeaderText = "DUI", DataPropertyName = "DUI", Width = 250 });
            dgvPropietario.Columns.Add(new DataGridViewTextBoxColumn { Name = "TelefonoCol", HeaderText = "Telefono", DataPropertyName = "Telefono", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });
            dgvPropietario.Columns.Add(new DataGridViewTextBoxColumn { Name = "DireccionCol", HeaderText = "Direccion", DataPropertyName = "Direccion", AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill });


        }

        private void Carga(string filtro = "")
        {
            try
            {
                dgvPropietario.DataSource = propietarioDao.getAll(filtro);
                dgvPropietario.ClearSelection();
                dgvPropietario.CurrentCell = null;
            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void frmPropietario_Load(object sender, EventArgs e)
        {
            configuracionGrid();
            Carga();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmInsertarPopietario frm = new frmInsertarPopietario();
           
            if (frm.ShowDialog() == DialogResult.OK)
            {
                Carga();
            }
        }
    }
}
