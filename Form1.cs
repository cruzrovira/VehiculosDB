using Microsoft.Data.SqlClient;
using Microsoft.IdentityModel.Tokens;
using VehiculosDB.Core.Clases;
using VehiculosDB.Core.Lib;
using VehiculosDB.formularios;

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
    }
}
