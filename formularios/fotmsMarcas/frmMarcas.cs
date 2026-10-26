using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VehiculosDB.Core.Clases;
using VehiculosDB.Core.Dao;

namespace VehiculosDB.formularios.fotmsMarcas
{
    public partial class frmMarcas : Form
    {

        private readonly MarcasDao marcasDao = new MarcasDao();
        public frmMarcas()
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
            dgvMarcas.AutoGenerateColumns = false;
            dgvMarcas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvMarcas.MultiSelect = false;
            dgvMarcas.AllowUserToAddRows = false;
            dgvMarcas.ReadOnly = true;
            dgvMarcas.ScrollBars = ScrollBars.Vertical;
            dgvMarcas.Columns.Clear();

            configureCols(dgvMarcas, "NombreMarcaCol", "Nombre Marca", "NombreMarca");



        }


        private void Carga(string filtro = "")
        {
            try
            {
                dgvMarcas.DataSource = marcasDao.getAll(filtro);
                dgvMarcas.ClearSelection();
                dgvMarcas.CurrentCell = null;
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

        private int? GetIdSeleccionado()
        {
            if (dgvMarcas.CurrentRow == null)
            {
                MessageBox.Show("Debe Selecionar un reguitro", "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning
                    );
                return null;
            }
            if (dgvMarcas.CurrentRow.DataBoundItem is Marcas marca)
            {
                return marca.IdMarca;
            }

            return null;
        }
        private void frmMarcas_Load(object sender, EventArgs e)
        {
            configuracionGrid();
            Carga();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            var id = GetIdSeleccionado();
            if (!id.HasValue)
            {
                MessageBox.Show("Selecione un reguistro");
                return;
            }

            var respuesta = MessageBox.Show("¿Desea eliminar el reguistro selecionado?",
                "Confirmar eliminacion", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (respuesta == DialogResult.No)
            {
                return;
            }

            try
            {

                if (marcasDao.delete(id.Value))
                {
                    Carga();
                }
                else
                {

                    MessageBox.Show("No se pudo eliminar el registro", "Aviso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information
                        );

                }
            }
            catch (ApplicationException ex)
            {

                MessageBox.Show("No se puedo eliminar el reguistro " + ex.Message,
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning
                    );
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error inesperado " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error
                    );
            }
        }
    }
}
