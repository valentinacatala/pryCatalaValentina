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
            // frmJuego
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            ClientSize = new System.Drawing.Size(800, 788);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Name = "frmJuego";
            Text = "frmJuego";
            Load += frmJuego_Load_1;
            KeyDown += frmJuego_KeyDown_1;
            KeyPress += frmJuego_KeyPress;
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Timer timerDisparos;
        private System.Windows.Forms.Timer timerEnemigos;
    }
}