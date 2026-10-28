namespace VehiculosDB.formularios.FormsMantenimientos
{
    partial class frmMantenimientos
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
            btnEliminar = new Button();
            btnCerrar = new Button();
            btnEditar = new Button();
            btnAgregar = new Button();
            dgvMantenimiento = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvMantenimiento).BeginInit();
            SuspendLayout();
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(672, 216);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(139, 51);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(672, 293);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(139, 51);
            btnCerrar.TabIndex = 4;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(672, 139);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(139, 51);
            btnEditar.TabIndex = 5;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(672, 69);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(139, 51);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // dgvMantenimiento
            // 
            dgvMantenimiento.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMantenimiento.Location = new Point(11, 11);
            dgvMantenimiento.Margin = new Padding(2);
            dgvMantenimiento.Name = "dgvMantenimiento";
            dgvMantenimiento.RowHeadersWidth = 62;
            dgvMantenimiento.Size = new Size(636, 361);
            dgvMantenimiento.TabIndex = 3;
            // 
            // frmMantenimientos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(840, 407);
            Controls.Add(btnEliminar);
            Controls.Add(btnCerrar);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Controls.Add(dgvMantenimiento);
            Name = "frmMantenimientos";
            Text = "Mantenimientos";
            Load += frmMantenimientos_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMantenimiento).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnEliminar;
        private Button btnCerrar;
        private Button btnEditar;
        private Button btnAgregar;
        private DataGridView dgvMantenimiento;
    }
}