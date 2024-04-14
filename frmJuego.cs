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
            
        }

        private void frmJuego_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void frmJuego_Load_1(object sender, EventArgs e)
        {
            objNaveJugador = new claseNave();

            objNaveJugador.CrearJuego();
            objNaveJugador.imagNave.Location = new Point(300, 600);
            Controls.Add(objNaveJugador.imagNave);

            objNaveJugador.CrearEnemigo();
            objNaveJugador.imagEnemigo1.Location = new Point(350, 200);
            Controls.Add(objNaveJugador.imagEnemigo1);

            objNaveJugador.CrearEnemigo();
            objNaveJugador.imagEnemigo2.Location = new Point(70, 200);
            Controls.Add(objNaveJugador.imagEnemigo2);

            objNaveJugador.CrearEnemigo();
            objNaveJugador.imagEnemigo3.Location = new Point(650, 200);
            Controls.Add(objNaveJugador.imagEnemigo3);

            objNaveJugador.CrearEnemigo();
            objNaveJugador.imagEnemigo4.Location = new Point(230, 70);
            Controls.Add(objNaveJugador.imagEnemigo4);

            objNaveJugador.CrearEnemigo();
            objNaveJugador.imagEnemigo5.Location = new Point(500, 70);
            Controls.Add(objNaveJugador.imagEnemigo5);

            

        }

        private void frmJuego_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                objNaveJugador.imagNave.Location = new Point(
                    objNaveJugador.imagNave.Location.X + 5, objNaveJugador.imagNave.Location.Y);
            }
            if (e.KeyCode == Keys.Left)
            {
                objNaveJugador.imagNave.Location = new Point(
                    objNaveJugador.imagNave.Location.X - 5, objNaveJugador.imagNave.Location.Y);
            }
            if (e.KeyCode == Keys.Space)
            {
                objNaveJugador.DispararBala();
            }

        }
    }
}

