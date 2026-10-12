namespace VehiculosDB.formularios
{
    partial class frmPropietario
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
            dgvPropietario = new DataGridView();
            btnAgregar = new Button();
            btnEditar = new Button();
            btnCerrar = new Button();
            btnEliminar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvPropietario).BeginInit();
            SuspendLayout();
            // 
            // dgvPropietario
            // 
            dgvPropietario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPropietario.Location = new Point(0, 0);
            dgvPropietario.Margin = new Padding(2);
            dgvPropietario.Name = "dgvPropietario";
            dgvPropietario.RowHeadersWidth = 62;
            dgvPropietario.Size = new Size(636, 361);
            dgvPropietario.TabIndex = 0;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(682, 24);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(139, 51);
            btnAgregar.TabIndex = 1;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(682, 94);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(139, 51);
            btnEditar.TabIndex = 1;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(682, 248);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(139, 51);
            btnCerrar.TabIndex = 1;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(682, 171);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(139, 51);
            btnEliminar.TabIndex = 2;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // frmPropietario
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 360);
            Controls.Add(btnEliminar);
            Controls.Add(btnCerrar);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Controls.Add(dgvPropietario);
            Margin = new Padding(2);
            Name = "frmPropietario";
            Text = "Propietario";
            Load += frmPropietario_Load;
            ((System.ComponentModel.ISupportInitialize)dgvPropietario).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvPropietario;
        private Button btnAgregar;
        private Button btnEditar;
        private Button btnCerrar;
        private Button btnEliminar;
    }
}