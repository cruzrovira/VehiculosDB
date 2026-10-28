namespace VehiculosDB.formularios.FormsMantenimientos
{
    partial class frmActualizarMantenimiento
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
            btnActualizar = new Button();
            btnCerrar = new Button();
            cbxTipoMantenimiento = new ComboBox();
            dtpFechaMantenimiento = new DateTimePicker();
            txtObservaciones = new TextBox();
            txtCosto = new TextBox();
            txtPlace = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(182, 252);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(94, 29);
            btnActualizar.TabIndex = 24;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(297, 252);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(94, 29);
            btnCerrar.TabIndex = 25;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // cbxTipoMantenimiento
            // 
            cbxTipoMantenimiento.FormattingEnabled = true;
            cbxTipoMantenimiento.Location = new Point(187, 197);
            cbxTipoMantenimiento.Name = "cbxTipoMantenimiento";
            cbxTipoMantenimiento.Size = new Size(204, 28);
            cbxTipoMantenimiento.TabIndex = 23;
            // 
            // dtpFechaMantenimiento
            // 
            dtpFechaMantenimiento.Location = new Point(187, 64);
            dtpFechaMantenimiento.Name = "dtpFechaMantenimiento";
            dtpFechaMantenimiento.Size = new Size(308, 27);
            dtpFechaMantenimiento.TabIndex = 17;
            // 
            // txtObservaciones
            // 
            txtObservaciones.Location = new Point(187, 150);
            txtObservaciones.Name = "txtObservaciones";
            txtObservaciones.Size = new Size(341, 27);
            txtObservaciones.TabIndex = 21;
            // 
            // txtCosto
            // 
            txtCosto.Location = new Point(187, 106);
            txtCosto.Name = "txtCosto";
            txtCosto.Size = new Size(125, 27);
            txtCosto.TabIndex = 19;
            // 
            // txtPlace
            // 
            txtPlace.Location = new Point(187, 16);
            txtPlace.Name = "txtPlace";
            txtPlace.ReadOnly = true;
            txtPlace.Size = new Size(125, 27);
            txtPlace.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 205);
            label5.Name = "label5";
            label5.Size = new Size(165, 20);
            label5.TabIndex = 22;
            label5.Text = "Tipo de Mantenimiento";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 157);
            label4.Name = "label4";
            label4.Size = new Size(111, 20);
            label4.TabIndex = 20;
            label4.Text = "Obsservaciones";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 113);
            label3.Name = "label3";
            label3.Size = new Size(47, 20);
            label3.TabIndex = 18;
            label3.Text = "Costo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 69);
            label2.Name = "label2";
            label2.Size = new Size(47, 20);
            label2.TabIndex = 16;
            label2.Text = "Fecha";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 24);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 13;
            label1.Text = "Vehiculo";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // frmActualizarMantenimiento
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(626, 333);
            Controls.Add(btnActualizar);
            Controls.Add(btnCerrar);
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
            Name = "frmActualizarMantenimiento";
            Text = "Actualizar Mantenimiento";
            Load += frmActualizarMantenimiento_Load;
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnActualizar;
        private Button btnCerrar;
        private ComboBox cbxTipoMantenimiento;
        private DateTimePicker dtpFechaMantenimiento;
        private TextBox txtObservaciones;
        private TextBox txtCosto;
        private TextBox txtPlace;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ErrorProvider errorProvider1;
    }
}