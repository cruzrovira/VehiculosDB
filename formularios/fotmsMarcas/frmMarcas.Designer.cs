namespace VehiculosDB.formularios.fotmsMarcas
{
    partial class frmMarcas
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
            dgvMarcas = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvMarcas).BeginInit();
            SuspendLayout();
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(684, 170);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(139, 51);
            btnEliminar.TabIndex = 7;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            btnEliminar.Click += btnEliminar_Click;
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(684, 247);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(139, 51);
            btnCerrar.TabIndex = 4;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(684, 93);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(139, 51);
            btnEditar.TabIndex = 5;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(684, 23);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(139, 51);
            btnAgregar.TabIndex = 6;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // dgvMarcas
            // 
            dgvMarcas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMarcas.Location = new Point(11, 2);
            dgvMarcas.Margin = new Padding(2);
            dgvMarcas.Name = "dgvMarcas";
            dgvMarcas.RowHeadersWidth = 62;
            dgvMarcas.Size = new Size(636, 361);
            dgvMarcas.TabIndex = 3;
            // 
            // frmMarcas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(850, 374);
            Controls.Add(btnEliminar);
            Controls.Add(btnCerrar);
            Controls.Add(btnEditar);
            Controls.Add(btnAgregar);
            Controls.Add(dgvMarcas);
            Name = "frmMarcas";
            Text = "Marcas";
            Load += frmMarcas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMarcas).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnEliminar;
        private Button btnCerrar;
        private Button btnEditar;
        private Button btnAgregar;
        private DataGridView dgvMarcas;
    }
}