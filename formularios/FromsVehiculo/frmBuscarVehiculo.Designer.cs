namespace VehiculosDB.formularios.FromsVehiculo
{
    partial class frmBuscarVehiculo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtBuscar = new TextBox();
            btnSelecionar = new Button();
            dgvVehiculo = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvVehiculo).BeginInit();
            SuspendLayout();
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(12, 12);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(350, 27);
            txtBuscar.TabIndex = 0;
            txtBuscar.KeyUp += txtBuscar_KeyUp;
            // 
            // btnSelecionar
            // 
            btnSelecionar.Location = new Point(402, 9);
            btnSelecionar.Name = "btnSelecionar";
            btnSelecionar.Size = new Size(129, 32);
            btnSelecionar.TabIndex = 1;
            btnSelecionar.Text = "Selecionar";
            btnSelecionar.UseVisualStyleBackColor = true;
            btnSelecionar.Click += btnSelecionar_Click;
            // 
            // dgvVehiculo
            // 
            dgvVehiculo.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvVehiculo.Location = new Point(12, 66);
            dgvVehiculo.Name = "dgvVehiculo";
            dgvVehiculo.RowHeadersWidth = 51;
            dgvVehiculo.Size = new Size(721, 221);
            dgvVehiculo.TabIndex = 2;
            // 
            // frmBuscarVehiculo
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(743, 300);
            Controls.Add(dgvVehiculo);
            Controls.Add(btnSelecionar);
            Controls.Add(txtBuscar);
            Name = "frmBuscarVehiculo";
            Text = "Buscar Vehiculo";
            Load += frmBuscarVehiculo_Load;
            ((System.ComponentModel.ISupportInitialize)dgvVehiculo).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBuscar;
        private Button btnSelecionar;
        private DataGridView dgvVehiculo;
    }
}