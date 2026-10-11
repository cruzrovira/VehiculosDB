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
    public partial class frmInsertarPopietario : Form
    {
        public frmInsertarPopietario()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            PropietarioDao propietarioDao = new PropietarioDao();
            Propietario propietario = new Propietario(-1, txtNombre.Text.Trim(),
                txtApellido.Text.Trim() ,mtxtDui.Text.Trim(),
                mtxtTelefono.Text.Trim(),txtDireccion.Text.Trim() );

            try { 
            
              var id =  propietarioDao.insert(propietario);

                if (id > 0) {

                    MessageBox.Show("El propietario se ha agregado correctamente.",
                        "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    DialogResult = DialogResult.OK;
                    this.Close();

                }
                else {
                    MessageBox.Show("No se pudo agregar el propietario.",
                          "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Ocurrió un error al agregar el propietario: " + ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
