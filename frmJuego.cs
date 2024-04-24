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

        claseNave objNaveJugador;
        PictureBox imagBala;
        Random Aleatorio = new Random();
        Random PosicionX = new Random();
        Random PosicionY = new Random();
        private void frmJuego_Load_1(object sender, EventArgs e)
        {
            //tamaño del formulario
            this.Width = 700;
            this.Height = 800;


            objNaveJugador = new claseNave();
            objNaveJugador.CrearJuego();
            objNaveJugador.imagNave.Location = new Point(200, 450);
            Controls.Add(objNaveJugador.imagNave);


            int contador = 0;
            while (contador < 10)
            {
                int posX = PosicionX.Next(0, 800);
                int posY = PosicionY.Next(0, 400);

                // Verificar si la posición generada se superpone con alguna de las posiciones de los enemigos existentes
                bool posicion = true;
                foreach (Control control in Controls)
                {
                    if (control is PictureBox && control.Tag != null && control.Tag.ToString() == "Enemigo")
                    {
                        PictureBox enemigoExistente = (PictureBox)control;
                        if (Math.Abs(enemigoExistente.Location.X - posX) < enemigoExistente.Width &&
                            Math.Abs(enemigoExistente.Location.Y - posY) < enemigoExistente.Height)
                        {
                            // La posición generada se superpone con un enemigo existente, por lo que no es válida
                            posicion = false;
                            break;
                        }
                    }
                }

                if (posicion)
                {
                    int codigoEnemigo = Aleatorio.Next(1000, 3000);
                    switch (codigoEnemigo)
                    {
                        case < 2000:
                            objNaveJugador.CrearEnemigo();
                            objNaveJugador.imagEnemigo1.Location = new Point(posX, posY);
                            Controls.Add(objNaveJugador.imagEnemigo1);
                            objNaveJugador.imagEnemigo1.Tag = "Enemigo";
                            break;
                        case > 2500:
                            objNaveJugador.CrearEnemigo();
                            objNaveJugador.imagEnemigo2.Location = new Point(posX, posY);
                            Controls.Add(objNaveJugador.imagEnemigo2);
                            objNaveJugador.imagEnemigo2.Tag = "Enemigo";
                            break;
                        case > 1000:
                            objNaveJugador.CrearEnemigo();
                            objNaveJugador.imagEnemigo3.Location = new Point(posX, posY);
                            Controls.Add(objNaveJugador.imagEnemigo3);
                            objNaveJugador.imagEnemigo3.Tag = "Enemigo";
                            break;
                        default:
                            break;
                    }
                    contador++;
                }
            }
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
            
        }

        private void timerDisparos_Tick(object sender, EventArgs e)
        {
            imagBala.Top -= 10;
            imagBala.BringToFront();

            if (imagBala != null && imagBala.Location.Y > 0)
            {
                imagBala.Location = new Point(imagBala.Location.X, imagBala.Location.Y - 10);
                foreach (Control imagen in Controls)
                {
                    if (imagen.Tag == "Enemigo")
                    {
                        if (imagBala.Bounds.IntersectsWith(imagen.Bounds))
                        {
                            timerDisparos.Stop();
                            imagBala.Dispose();
                            imagen.Dispose();

                        }
                    }
                }
            }
            else
            {
                if (imagBala != null)
                {
                    timerDisparos.Stop();
                    imagBala.Dispose();
                    imagBala = null;
                }
            }
            timerDisparos.Start();

        }

        private void frmJuego_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar ==(char) Keys.Space)
            {
                imagBala = new PictureBox();
                imagBala.SizeMode = PictureBoxSizeMode.StretchImage;
                imagBala.ImageLocation = "https://toppng.com/uploads/thumbnail/alaga-galaga-missile-11562887504dfmxt6dqa0.png";
                imagBala.Size = new Size(30, 40);
                imagBala.Location = new Point(objNaveJugador.imagNave.Location.X + (objNaveJugador.imagNave.Width / 2) - (objNaveJugador.imagBala.Width / 2), objNaveJugador.imagNave.Location.Y);

                Controls.Add(imagBala);

            }
        }
    }


}

