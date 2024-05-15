namespace pryCatalaValentina
{
    partial class frmPrincipal
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
            label1 = new System.Windows.Forms.Label();
            txtNombre = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.ErrorImage = Properties.Resources.s_l1200;
            pictureBox1.Image = Properties.Resources.s_l1200;
            pictureBox1.Location = new System.Drawing.Point(37, 128);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new System.Drawing.Size(777, 393);
            pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Impact", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            label1.Location = new System.Drawing.Point(125, 615);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(588, 42);
            label1.TabIndex = 3;
            label1.Text = "PRESIONA ESPACIO PARA EMPEZAR A JUGAR!";
            // 
            // txtNombre
            // 
            txtNombre.Location = new System.Drawing.Point(397, 729);
            txtNombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new System.Drawing.Size(202, 27);
            txtNombre.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label2.Location = new System.Drawing.Point(217, 729);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(170, 25);
            label2.TabIndex = 5;
            label2.Text = "Ingresar el nombre:";
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            BackgroundImage = Properties.Resources.c54fa1235e6a5abee8c4e8e04aeba201;
            BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            ClientSize = new System.Drawing.Size(917, 1055);
            Controls.Add(label2);
            Controls.Add(txtNombre);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            DoubleBuffered = true;
            ForeColor = System.Drawing.SystemColors.ControlLightLight;
            Name = "frmPrincipal";
            Text = "Bienvenido";
            Load += frmPrincipal_Load;
            KeyDown += frmPrincipal_KeyDown;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label2;
    }
}