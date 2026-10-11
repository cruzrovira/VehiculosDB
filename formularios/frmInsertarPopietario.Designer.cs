namespace VehiculosDB.formularios
{
    partial class frmInsertarPopietario
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
            txtNombre = new TextBox();
            label1 = new Label();
            txtApellido = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtDireccion = new TextBox();
            label5 = new Label();
            btnAgregar = new Button();
            btnCerrar = new Button();
            mtxtTelefono = new MaskedTextBox();
            mtxtDui = new MaskedTextBox();
            SuspendLayout();
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(149, 33);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(178, 27);
            txtNombre.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 36);
            label1.Name = "label1";
            label1.Size = new Size(64, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre";
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(149, 66);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(178, 27);
            txtApellido.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 69);
            label2.Name = "label2";
            label2.Size = new Size(66, 20);
            label2.TabIndex = 2;
            label2.Text = "Apellido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(33, 102);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 4;
            label3.Text = "Teléfono";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 135);
            label4.Name = "label4";
            label4.Size = new Size(34, 20);
            label4.TabIndex = 6;
            label4.Text = "DUI";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(149, 168);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(178, 27);
            txtDireccion.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(33, 168);
            label5.Name = "label5";
            label5.Size = new Size(72, 20);
            label5.TabIndex = 8;
            label5.Text = "Direccion";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(34, 243);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(118, 48);
            btnAgregar.TabIndex = 10;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(194, 243);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(118, 48);
            btnCerrar.TabIndex = 11;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // mtxtTelefono
            // 
            mtxtTelefono.Location = new Point(149, 102);
            mtxtTelefono.Mask = "0000-0000";
            mtxtTelefono.Name = "mtxtTelefono";
            mtxtTelefono.Size = new Size(178, 27);
            mtxtTelefono.TabIndex = 5;
            // 
            // mtxtDui
            // 
            mtxtDui.Location = new Point(149, 135);
            mtxtDui.Mask = "00000000-0";
            mtxtDui.Name = "mtxtDui";
            mtxtDui.Size = new Size(178, 27);
            mtxtDui.TabIndex = 7;
            // 
            // frmInsertarPopietario
            // 
            AcceptButton = btnAgregar;
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(401, 326);
            Controls.Add(mtxtDui);
            Controls.Add(mtxtTelefono);
            Controls.Add(btnCerrar);
            Controls.Add(btnAgregar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDireccion);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Name = "frmInsertarPopietario";
            Text = "Insertar Popietario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNombre;
        private Label label1;
        private TextBox txtApellido;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtDireccion;
        private Label label5;
        private Button btnAgregar;
        private Button btnCerrar;
        private MaskedTextBox mtxtTelefono;
        private MaskedTextBox mtxtDui;
    }
}