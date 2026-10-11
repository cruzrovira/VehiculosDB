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
            SuspendLayout();
            // 
            // btnOPen
            // 
            btnOPen.Location = new Point(337, 75);
            btnOPen.Name = "btnOPen";
            btnOPen.Size = new Size(112, 34);
            btnOPen.TabIndex = 0;
            btnOPen.Text = "Open";
            btnOPen.UseVisualStyleBackColor = true;
            btnOPen.Click += btnOPen_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(488, 75);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(112, 34);
            btnClose.TabIndex = 0;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnPropietario
            // 
            btnPropietario.Location = new Point(457, 175);
            btnPropietario.Name = "btnPropietario";
            btnPropietario.Size = new Size(112, 34);
            btnPropietario.TabIndex = 1;
            btnPropietario.Text = "Propietario";
            btnPropietario.UseVisualStyleBackColor = true;
            btnPropietario.Click += btnPropietario_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPropietario);
            Controls.Add(btnClose);
            Controls.Add(btnOPen);
            Name = "frmPrincipal";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnOPen;
        private Button btnClose;
        private Button btnPropietario;
    }
}
