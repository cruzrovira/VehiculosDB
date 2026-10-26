using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VehiculosDB.Core.Clases;
using VehiculosDB.Core.Dao;
using VehiculosDB.formularios.FromsVehiculo;

namespace VehiculosDB.formularios.FormsMantenimientos
{
    public partial class frmInsertarMantenimiento : Form
    {
        private int idVehiculo=-1;
        public frmInsertarMantenimiento()
        {
            InitializeComponent();
        }

        private void frmInsertarMantenimiento_Load(object sender, EventArgs e)
        {
            CargarTiposMantenimientos();
        }

        private void CargarTiposMantenimientos()
        {
            TiposMantenimientoDao tiposMantenimientoDao = new TiposMantenimientoDao();
            var tipos = tiposMantenimientoDao.getAll();

            tipos.Insert(0, new TiposMantenimiento
            {
                IdTipoMantenimiento = 0,
                NombreTipo = "Seleccione un tipo de mantenimiento"

            });

            cbxTipoMantenimiento.DataSource = tipos;
            cbxTipoMantenimiento.DisplayMember = "NombreTipo";
            cbxTipoMantenimiento.ValueMember = "IdTipoMantenimiento";


        }

        private void btnAsociarVehiculo_Click(object sender, EventArgs e)
        {
            frmBuscarVehiculo frm = new frmBuscarVehiculo();
            if (frm.ShowDialog() == DialogResult.OK && frm.vehiculoSeleccionado != null)
            {
                txtPlace.Text = frm.vehiculoSeleccionado.Placa;
                idVehiculo = frm.vehiculoSeleccionado.IdVehiculo;

            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if(validaciones()==false)
            {
                return;
            }


            MantenimientosDao mantenimientosDao = new MantenimientosDao();
            Mantenimientos mantenimientos = new Mantenimientos
            
            {
                IdVehiculo = idVehiculo,
                Fecha = dtpFechaMantenimiento.Value.Date,
                Costo = Decimal.Parse(txtCosto.Text),
                Observaciones = txtObservaciones.Text,
                IdTipoMantenimiento = Convert.ToInt32(cbxTipoMantenimiento.SelectedValue)
            };

            try
            {
                var id = mantenimientosDao.insert(mantenimientos);
                if (id > 0)
                {
                    MessageBox.Show("Sea creado un mantenimiento", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se puedo registrar el mantenimiento",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }
            catch (ApplicationException ex)
            {
                MessageBox.Show(ex.Message, "Aviso",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            catch (Exception ex)
            {

                MessageBox.Show("error inesperado :" + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private bool validaciones()
        {
            if (idVehiculo <= 0) { 
               errorProvider1.SetError(txtPlace, "Seleccione un vehículo");
               txtPlace.Focus();
               return false;
            }
            errorProvider1.Clear();

            if (string.IsNullOrWhiteSpace(txtCosto.Text)) {
            
                errorProvider1.SetError(txtCosto, "Ingrese un costo");
                txtCosto.Focus();
                return false;
            }
            errorProvider1.Clear();
            decimal costo;

            if (!decimal.TryParse(txtCosto.Text, out costo)) { 
                errorProvider1.SetError(txtCosto, "Ingrese un costo numerico");
                txtCosto.Focus();
                txtCosto.Clear();
                return false;
            }
            errorProvider1.Clear();

            if (costo <= 0) { 
                errorProvider1.SetError(txtCosto, "Ingrese un costo mayor a 0");
                txtCosto.Focus();
                txtCosto.Clear();
                return false;
            }
            errorProvider1.Clear();

            if (cbxTipoMantenimiento.SelectedIndex <= 0) {
                errorProvider1.SetError(cbxTipoMantenimiento, "Seleccione un tipo de mantenimiento");
                cbxTipoMantenimiento.Focus();
                return false;
            }
            errorProvider1.Clear();

            return true;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
