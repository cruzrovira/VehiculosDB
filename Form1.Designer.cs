namespace VehiculosDB
{
    partial class frmPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnOPen = new Button();
            btnClose = new Button();
            btnPropietario = new Button();
            btnMantenimiento = new Button();
            btnBuscarVehiculo = new Button();
            btnMarcas = new Button();
            SuspendLayout();
            // 
            // btnOPen
            // 
            btnOPen.Location = new Point(270, 60);
            btnOPen.Margin = new Padding(2);
            btnOPen.Name = "btnOPen";
            btnOPen.Size = new Size(90, 27);
            btnOPen.TabIndex = 0;
            btnOPen.Text = "Open";
            btnOPen.UseVisualStyleBackColor = true;
            btnOPen.Click += btnOPen_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(390, 60);
            btnClose.Margin = new Padding(2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(90, 27);
            btnClose.TabIndex = 0;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnPropietario
            // 
            btnPropietario.Location = new Point(366, 140);
            btnPropietario.Margin = new Padding(2);
            btnPropietario.Name = "btnPropietario";
            btnPropietario.Size = new Size(90, 27);
            btnPropietario.TabIndex = 1;
            btnPropietario.Text = "Propietario";
            btnPropietario.UseVisualStyleBackColor = true;
            btnPropietario.Click += btnPropietario_Click;
            // 
            // btnMantenimiento
            // 
            btnMantenimiento.Location = new Point(78, 157);
            btnMantenimiento.Name = "btnMantenimiento";
            btnMantenimiento.Size = new Size(131, 29);
            btnMantenimiento.TabIndex = 2;
            btnMantenimiento.Text = "Mantenimiento";
            btnMantenimiento.UseVisualStyleBackColor = true;
            btnMantenimiento.Click += btnMantenimiento_Click;
            // 
            // btnBuscarVehiculo
            // 
            btnBuscarVehiculo.Location = new Point(97, 226);
            btnBuscarVehiculo.Name = "btnBuscarVehiculo";
            btnBuscarVehiculo.Size = new Size(159, 29);
            btnBuscarVehiculo.TabIndex = 3;
            btnBuscarVehiculo.Text = "Buscar Vehiculo";
            btnBuscarVehiculo.UseVisualStyleBackColor = true;
            btnBuscarVehiculo.Click += btnBuscarVehiculo_Click;
            // 
            // btnMarcas
            // 
            btnMarcas.Location = new Point(458, 242);
            btnMarcas.Name = "btnMarcas";
            btnMarcas.Size = new Size(94, 29);
            btnMarcas.TabIndex = 4;
            btnMarcas.Text = "Marcas";
            btnMarcas.UseVisualStyleBackColor = true;
            btnMarcas.Click += btnMarcas_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(640, 360);
            Controls.Add(btnMarcas);
            Controls.Add(btnBuscarVehiculo);
            Controls.Add(btnMantenimiento);
            Controls.Add(btnPropietario);
            Controls.Add(btnClose);
            Controls.Add(btnOPen);
            Margin = new Padding(2);
            Name = "frmPrincipal";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnOPen;
        private Button btnClose;
        private Button btnPropietario;
        private Button btnMantenimiento;
        private Button btnBuscarVehiculo;
        private Button btnMarcas;
    }
}
