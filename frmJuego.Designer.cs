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
            progressBar1 = new System.Windows.Forms.ProgressBar();
            label1 = new System.Windows.Forms.Label();
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
            // progressBar1
            // 
            progressBar1.Location = new System.Drawing.Point(57, 14);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new System.Drawing.Size(114, 23);
            progressBar1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            label1.Location = new System.Drawing.Point(9, 18);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(46, 15);
            label1.TabIndex = 1;
            label1.Text = "SCORE:";
            // 
            // frmJuego
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            ClientSize = new System.Drawing.Size(700, 591);
            Controls.Add(label1);
            Controls.Add(progressBar1);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
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
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label1;
    }
}