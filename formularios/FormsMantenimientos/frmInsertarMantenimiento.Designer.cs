namespace VehiculosDB.formularios.FormsMantenimientos
{
    partial class frmInsertarMantenimiento
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            txtPlace = new TextBox();
            label2 = new Label();
            dtpFechaMantenimiento = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            txtCosto = new TextBox();
            txtObservaciones = new TextBox();
            label5 = new Label();
            cbxTipoMantenimiento = new ComboBox();
            btnAsociarVehiculo = new Button();
            btnCerrar = new Button();
            btnAgregar = new Button();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 16);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 0;
            label1.Text = "Vehiculo";
            // 
            // txtPlace
            // 
            txtPlace.Location = new Point(187, 8);
            txtPlace.Name = "txtPlace";
            txtPlace.ReadOnly = true;
            txtPlace.Size = new Size(125, 27);
            txtPlace.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 61);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 3;
            label2.Text = "Fecha";
            // 
            // dtpFechaMantenimiento
            // 
            dtpFechaMantenimiento.Location = new Point(187, 56);
            dtpFechaMantenimiento.Name = "dtpFechaMantenimiento";
            dtpFechaMantenimiento.Size = new Size(308, 27);
            dtpFechaMantenimiento.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 105);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 5;
            label3.Text = "Costo";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 149);
            label4.Name = "label4";
            label4.Size = new Size(111, 20);
            label4.TabIndex = 7;
            label4.Text = "Obsservaciones";
            // 
            // txtCosto
            // 
            txtCosto.Location = new Point(187, 98);
            txtCosto.Name = "txtCosto";
            txtCosto.Size = new Size(125, 27);
            txtCosto.TabIndex = 6;
            // 
            // txtObservaciones
            // 
            txtObservaciones.Location = new Point(187, 142);
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.Size = new Size(341, 27);
            txtObservaciones.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 197);
            label5.Name = "label5";
            label5.Size = new Size(165, 20);
            label5.TabIndex = 9;
            label5.Text = "Tipo de Mantenimiento";
            // 
            // cbxTipoMantenimiento
            // 
            cbxTipoMantenimiento.FormattingEnabled = true;
            cbxTipoMantenimiento.Location = new Point(187, 189);
            cbxTipoMantenimiento.Name = "cbxTipoMantenimiento";
            cbxTipoMantenimiento.Size = new Size(204, 28);
            cbxTipoMantenimiento.TabIndex = 10;
            // 
            // btnAsociarVehiculo
            // 
            btnAsociarVehiculo.Location = new Point(343, 7);
            btnAsociarVehiculo.Name = "btnAsociarVehiculo";
            btnAsociarVehiculo.Size = new Size(152, 29);
            btnAsociarVehiculo.TabIndex = 2;
            btnAsociarVehiculo.Text = "Asociar Vehiculo";
            btnAsociarVehiculo.UseVisualStyleBackColor = true;
            btnAsociarVehiculo.Click += btnAsociarVehiculo_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(297, 244);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(94, 29);
            btnCerrar.TabIndex = 12;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(182, 244);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 11;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmInsertarMantenimiento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(572, 305);
            Controls.Add(btnAgregar);
            Controls.Add(btnCerrar);
            Controls.Add(btnAsociarVehiculo);
            Controls.Add(cbxTipoMantenimiento);
            Controls.Add(dtpFechaMantenimiento);
            Controls.Add(txtObservaciones);
            Controls.Add(txtCosto);
            Controls.Add(txtPlace);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "frmInsertarMantenimiento";
            Text = "Insertar Mantenimiento";
            Load += frmInsertarMantenimiento_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtPlace;
        private Label label2;
        private DateTimePicker dtpFechaMantenimiento;
        private Label label3;
        private Label label4;
        private TextBox txtCosto;
        private TextBox txtObservaciones;
        private Label label5;
        private ComboBox cbxTipoMantenimiento;
        private Button btnAsociarVehiculo;
        private Button btnCerrar;
        private Button btnAgregar;
        private ErrorProvider errorProvider1;
    }
}