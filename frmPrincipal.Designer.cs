
namespace pryCatalaValentina
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
            menuStrip1 = new System.Windows.Forms.MenuStrip();
            programasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            firmasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            juegoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { programasToolStripMenuItem, salirToolStripMenuItem });
            menuStrip1.Location = new System.Drawing.Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new System.Drawing.Size(565, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // programasToolStripMenuItem
            // 
            programasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { firmasToolStripMenuItem, juegoToolStripMenuItem });
            programasToolStripMenuItem.Name = "programasToolStripMenuItem";
            programasToolStripMenuItem.Size = new System.Drawing.Size(94, 24);
            programasToolStripMenuItem.Text = "Programas";
            // 
            // salirToolStripMenuItem
            // 
            salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            salirToolStripMenuItem.Size = new System.Drawing.Size(52, 24);
            salirToolStripMenuItem.Text = "Salir";
            // 
            // firmasToolStripMenuItem
            // 
            firmasToolStripMenuItem.Name = "firmasToolStripMenuItem";
            firmasToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            firmasToolStripMenuItem.Text = "Firmas";
            firmasToolStripMenuItem.Click += firmasToolStripMenuItem_Click;
            // 
            // juegoToolStripMenuItem
            // 
            juegoToolStripMenuItem.Name = "juegoToolStripMenuItem";
            juegoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            juegoToolStripMenuItem.Text = "Juego";
            juegoToolStripMenuItem.Click += juegoToolStripMenuItem_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(565, 252);
            Controls.Add(menuStrip1);
            Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            Name = "frmPrincipal";
            Text = "Bienvenido";
            Load += frmPrincipal_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem programasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firmasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem juegoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}

