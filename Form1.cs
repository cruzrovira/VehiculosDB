using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
using VehiculosDB.Core.Clases;
using VehiculosDB.Core.Lib;
using VehiculosDB.formularios;
using VehiculosDB.formularios.FormsMantenimientos;
using VehiculosDB.formularios.fotmsMarcas;
using VehiculosDB.formularios.FromsVehiculo;


namespace VehiculosDB
{
    public partial class frmPrincipal : Form
    {
        Cnn cnn = new Cnn();
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnOPen_Click(object sender, EventArgs e)
        {

            cnn.OpenDb();
            if (cnn != null)
            {
                MessageBox.Show("Conexión abierta correctamente",
                    "Información",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            cnn.CloseDb();
        }

        private void btnPropietario_Click(object sender, EventArgs e)
        {
            frmPropietario propietario = new frmPropietario();
            propietario.Show();
        }

        private void btnMantenimiento_Click(object sender, EventArgs e)
        {
            frmMantenimientos frm = new frmMantenimientos();
            frm.Show();
        }

        private void btnBuscarVehiculo_Click(object sender, EventArgs e)
        {
            frmBuscarVehiculo frm = new frmBuscarVehiculo();
            frm.Show();
        }

        private void btnMarcas_Click(object sender, EventArgs e)
        {
            frmMarcas frm = new frmMarcas();  
            frm.Show();
        }
    }
}
