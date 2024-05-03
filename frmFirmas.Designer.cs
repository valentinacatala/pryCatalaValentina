namespace pryCatalaValentina
{
    partial class frmFirmas
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
            pictureBox1 = new System.Windows.Forms.PictureBox();
            btnGrabar = new System.Windows.Forms.Button();
            btnLimpiar = new System.Windows.Forms.Button();
            btnSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            pictureBox1.Location = new System.Drawing.Point(34, 27);
            pictureBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(539, 481);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.MouseMove += pictureBox1_MouseMove;
            // 
            // btnGrabar
            // 
            btnGrabar.Location = new System.Drawing.Point(115, 532);
            btnGrabar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnGrabar.Name = "btnGrabar";
            btnGrabar.Size = new System.Drawing.Size(112, 31);
            btnGrabar.TabIndex = 2;
            btnGrabar.Text = "Grabar";
            btnGrabar.UseVisualStyleBackColor = true;
            btnGrabar.Click += btnGrabar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new System.Drawing.Point(260, 532);
            btnLimpiar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new System.Drawing.Size(111, 31);
            btnLimpiar.TabIndex = 3;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnSalir
            // 
            btnSalir.BackColor = System.Drawing.SystemColors.ButtonShadow;
            btnSalir.Location = new System.Drawing.Point(395, 532);
            btnSalir.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new System.Drawing.Size(111, 31);
            btnSalir.TabIndex = 4;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // frmFirmas
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(607, 602);
            Controls.Add(btnSalir);
            Controls.Add(btnLimpiar);
            Controls.Add(btnGrabar);
            Controls.Add(pictureBox1);
            Name = "frmFirmas";
            Text = "Dibujar Firma";
            Load += frmFirmas_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnGrabar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnSalir;
    }
}