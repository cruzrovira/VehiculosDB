namespace VehiculosDB.formularios
{
    partial class frmActualizarPropietario
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
            mtxtDui = new MaskedTextBox();
            mtxtTelefono = new MaskedTextBox();
            btnCerrar = new Button();
            btnActualizar = new Button();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtDireccion = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            SuspendLayout();
            // 
            // mtxtDui
            // 
            mtxtDui.Location = new Point(140, 126);
            mtxtDui.Mask = "00000000-0";
            mtxtDui.Name = "mtxtDui";
            mtxtDui.Size = new Size(178, 27);
            mtxtDui.TabIndex = 19;
            // 
            // mtxtTelefono
            // 
            mtxtTelefono.Location = new Point(140, 93);
            mtxtTelefono.Mask = "0000-0000";
            mtxtTelefono.Name = "mtxtTelefono";
            mtxtTelefono.Size = new Size(178, 27);
            mtxtTelefono.TabIndex = 17;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(185, 234);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(118, 48);
            btnCerrar.TabIndex = 23;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnActualizar
            // 
            btnActualizar.Location = new Point(25, 234);
            btnActualizar.Name = "btnActualizar";
            btnActualizar.Size = new Size(118, 48);
            btnActualizar.TabIndex = 22;
            btnActualizar.Text = "Actualizar";
            btnActualizar.UseVisualStyleBackColor = true;
            btnActualizar.Click += btnActualizar_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(24, 159);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 20;
            label5.Text = "Direccion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(25, 126);
            label4.Name = "label4";
            label4.Size = new Size(34, 20);
            label4.TabIndex = 18;
            label4.Text = "DUI";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(24, 93);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 16;
            label3.Text = "Teléfono";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 60);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 14;
            label2.Text = "Apellido";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 27);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 12;
            label1.Text = "Nombre";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(140, 159);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(178, 27);
            txtDireccion.TabIndex = 21;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(140, 57);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(178, 27);
            txtApellido.TabIndex = 15;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(140, 24);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(178, 27);
            txtNombre.TabIndex = 13;
            // 
            // frmActualizarPropietario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(376, 317);
            Controls.Add(mtxtDui);
            Controls.Add(mtxtTelefono);
            Controls.Add(btnCerrar);
            Controls.Add(btnActualizar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDireccion);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Name = "frmActualizarPropietario";
            Text = "Actualziar Propietario";
            Load += frmActualizarPropietario_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MaskedTextBox mtxtDui;
        private MaskedTextBox mtxtTelefono;
        private Button btnCerrar;
        private Button btnActualizar;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox txtDireccion;
        private TextBox txtApellido;
        private TextBox txtNombre;
    }
}