namespace pryCatalaValentina
{
    partial class frmJuego
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
            timerDisparos = new System.Windows.Forms.Timer(components);
            timerEnemigos = new System.Windows.Forms.Timer(components);
            progressBarScore = new System.Windows.Forms.ProgressBar();
            label1 = new System.Windows.Forms.Label();
            timerExplosion = new System.Windows.Forms.Timer(components);
            lblNombreJugador = new System.Windows.Forms.Label();
            lblNiveles = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // timerDisparos
            // 
            timerDisparos.Tick += timerDisparos_Tick;
            // 
            // timerEnemigos
            // 
            timerEnemigos.Tick += timerEnemigos_Tick;
            // 
            // progressBarScore
            // 
            progressBarScore.Location = new System.Drawing.Point(77, 20);
            progressBarScore.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            progressBarScore.Name = "progressBarScore";
            progressBarScore.Size = new System.Drawing.Size(237, 31);
            progressBarScore.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Impact", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            label1.Location = new System.Drawing.Point(15, 27);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(56, 21);
            label1.TabIndex = 1;
            label1.Text = "SCORE:";
            // 
            // lblNombreJugador
            // 
            lblNombreJugador.AutoSize = true;
            lblNombreJugador.Font = new System.Drawing.Font("Impact", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblNombreJugador.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            lblNombreJugador.Location = new System.Drawing.Point(268, 674);
            lblNombreJugador.Name = "lblNombreJugador";
            lblNombreJugador.Size = new System.Drawing.Size(0, 25);
            lblNombreJugador.TabIndex = 2;
            // 
            // lblNiveles
            // 
            lblNiveles.AutoSize = true;
            lblNiveles.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 0);
            lblNiveles.ForeColor = System.Drawing.Color.White;
            lblNiveles.Location = new System.Drawing.Point(561, 20);
            lblNiveles.Name = "lblNiveles";
            lblNiveles.Size = new System.Drawing.Size(87, 35);
            lblNiveles.TabIndex = 3;
            lblNiveles.Text = "Nivel 1";
            // 
            // frmJuego
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            ClientSize = new System.Drawing.Size(800, 788);
            Controls.Add(lblNiveles);
            Controls.Add(lblNombreJugador);
            Controls.Add(label1);
            Controls.Add(progressBarScore);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "frmJuego";
            Text = "frmJuego";
            Load += frmJuego_Load_1;
            KeyDown += frmJuego_KeyDown_1;
            KeyPress += frmJuego_KeyPress;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Timer timerDisparos;
        private System.Windows.Forms.Timer timerEnemigos;
        private System.Windows.Forms.ProgressBar progressBarScore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timerExplosion;
        private System.Windows.Forms.Label lblNombreJugador;
        private System.Windows.Forms.Label lblNiveles;
    }
}