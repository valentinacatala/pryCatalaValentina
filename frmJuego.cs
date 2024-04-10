using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryCatalaValentina
{
    public partial class frmJuego : Form
    {

        claseNave objNaveJugador;
        public frmJuego()
        {
            InitializeComponent();
        }


        private void frmJuego_Load(object sender, EventArgs e)
        {
            objNaveJugador = new claseNave();

            objNaveJugador.CrearJuego();
            objNaveJugador.imagNave.Location = new Point(550, 550);
            Controls.Add(objNaveJugador.imagNave);

            objNaveJugador.CrearEnemigo();
            objNaveJugador.imagNave.Location = new Point(200, 200);
            Controls.Add(objNaveJugador.imagNave);




        }

        private void frmJuego_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode==Keys.Right)
            {
                objNaveJugador.imagNave.Location = new Point(
                    objNaveJugador.imagNave.Location.X + 5, objNaveJugador.imagNave.Location.Y);
            }
            if (e.KeyCode == Keys.Left)
            {
                objNaveJugador.imagNave.Location = new Point(
                    objNaveJugador.imagNave.Location.X - 5, objNaveJugador.imagNave.Location.Y);
            }
        }
    }
}

