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
            button1 = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.SystemColors.ControlLight;
            button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            button1.Font = new System.Drawing.Font("Impact", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button1.Location = new System.Drawing.Point(12, 12);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(330, 192);
            button1.TabIndex = 0;
            button1.Text = "DIBUJAR FIRMA";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(364, 225);
            Controls.Add(button1);
            Name = "frmPrincipal";
            Text = "Bienvenido";
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Button button1;
    }
}