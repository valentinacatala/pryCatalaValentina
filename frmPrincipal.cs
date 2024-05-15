using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;

namespace pryCatalaValentina
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private string nombreJugador;
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            this.Width = 900;
            this.Height = 1000;
            this.KeyPreview = true;
        }

        private void frmPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                nombreJugador = txtNombre.Text;
                this.Hide();

                frmJuego frmJuego = new frmJuego(nombreJugador);
                frmJuego.Show();
                
            }
        }
    }
}
