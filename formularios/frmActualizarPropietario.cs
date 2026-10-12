using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using VehiculosDB.Core.Clases;
using VehiculosDB.Core.Dao;

namespace VehiculosDB.formularios
{
    public partial class frmActualizarPropietario : Form
    {

        private PropietarioDao propietarioDao = new PropietarioDao();
        private int _id;
        public frmActualizarPropietario(int idPropietario)
        {
            InitializeComponent();
            _id = idPropietario;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            Propietario propietario = new Propietario(_id, 
                txtNombre.Text.Trim(), 
                txtApellido.Text.Trim(), 
                mtxtDui.Text.Trim(),
                mtxtTelefono.Text.Trim(),
                txtDireccion.Text.Trim()
                );

            try
            {

                if (propietarioDao.update(propietario))
                {

                    DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se puedo actualizar el reguistri", "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }

            }
            catch (ApplicationException ex) { 
            
                MessageBox.Show(ex.Message, "Aviso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
            catch( Exception ex)
            {
                MessageBox.Show("Error inesperado " +ex.Message, "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        private void frmActualizarPropietario_Load(object sender, EventArgs e)
        {
            var p = propietarioDao.getById(_id);
            if (p == null)
            {
                MessageBox.Show("Propietario no encontrado", "Aviso",
                    MessageBoxButtons.OK, 
                    MessageBoxIcon.Warning);
    
            }

            txtNombre.Text = p.Nombre;
            txtApellido.Text = p.Apellido;
            mtxtDui.Text = p.Dui;
            mtxtTelefono.Text = p.Telefono ?? "";
            txtDireccion.Text = p.Direccion ?? "";
        }
    }
}
