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

        private string nombreJugador;
        public frmJuego(string nombre)
        {
            InitializeComponent();
            nombreJugador = nombre;
        }


        private void frmJuego_Load(object sender, EventArgs e)
        {

        }

        private void frmJuego_KeyDown(object sender, KeyEventArgs e)
        {

        }

        claseNave objNaveJugador;
        claseNave objDisparos;
        PictureBox imagBala;
        List<PictureBox> balas = new List<PictureBox>();
        Random Aleatorio = new Random();
        Random PosicionX = new Random();
        Random PosicionY = new Random();
        private int nivelActual = 1;

        private void frmJuego_Load_1(object sender, EventArgs e)
        {
            
            //tamaño del formulario
            this.Width = 900;
            this.Height = 1000;

            

            objNaveJugador = new claseNave();
            objNaveJugador.CrearJuego();
            objNaveJugador.imagNave.Location = new Point(350, 800);
            Controls.Add(objNaveJugador.imagNave);

            lblNombreJugador.Text = nombreJugador;
            lblNombreJugador.Location = new Point(objNaveJugador.imagNave.Location.X + objNaveJugador.imagNave.Width / 2 - lblNombreJugador.Width / 2,
                                                   objNaveJugador.imagNave.Location.Y + objNaveJugador.imagNave.Height);

            GenerarEnemigos();
            TimerNuevoEnemigo();
        }


        private void frmJuego_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                objNaveJugador.imagNave.Location = new Point(
                    objNaveJugador.imagNave.Location.X + 15, objNaveJugador.imagNave.Location.Y);

                lblNombreJugador.Location = new Point(objNaveJugador.imagNave.Location.X + objNaveJugador.imagNave.Width / 2 - lblNombreJugador.Width / 2,
                                               objNaveJugador.imagNave.Location.Y + objNaveJugador.imagNave.Height);
            }
     
            if (e.KeyCode == Keys.Left)
            {
                objNaveJugador.imagNave.Location = new Point(
                    objNaveJugador.imagNave.Location.X - 15, objNaveJugador.imagNave.Location.Y);

                lblNombreJugador.Location = new Point(objNaveJugador.imagNave.Location.X + objNaveJugador.imagNave.Width / 2 - lblNombreJugador.Width / 2,
                                               objNaveJugador.imagNave.Location.Y + objNaveJugador.imagNave.Height);
            }
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }

        }
        private void frmJuego_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                PictureBox nuevaBala = new PictureBox();
                nuevaBala.SizeMode = PictureBoxSizeMode.StretchImage;
                nuevaBala.ImageLocation = "https://toppng.com/uploads/thumbnail/alaga-galaga-missile-11562887504dfmxt6dqa0.png";
                nuevaBala.Size = new Size(20, 30);
                nuevaBala.Location = new Point(objNaveJugador.imagNave.Location.X + objNaveJugador.imagNave.Width / 2 - nuevaBala.Width / 2, objNaveJugador.imagNave.Location.Y);
                Controls.Add(nuevaBala);

                balas.Add(nuevaBala);
                timerDisparos.Start();
            }
        }

        private void timerDisparos_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < balas.Count; i++)
            {
                PictureBox bala = balas[i];
                bala.Top -= 30;
                bala.BringToFront();

                if (bala.Location.Y <= 0)
                {
                    balas.Remove(bala);
                    bala.Dispose();
                }
                else
                {
                    // Comprueba si la bala colisiona con algún enemigo
                    foreach (Control imagen in Controls)
                    {
                        if (imagen.Tag == "Enemigo" && bala.Bounds.IntersectsWith(imagen.Bounds))
                        {
                            MostrarExplosion(imagen.Location);
                            balas.Remove(bala);
                            bala.Dispose();
                            imagen.Dispose();
                            EliminarEnemigo((PictureBox)imagen);
                            break;
                        }
                    }
                }
            }

            if (balas.Count == 0)
            {
                timerDisparos.Stop();
            }
        }


        private void GenerarEnemigos()
        {
            int posX = 0;
            int posY = 0;
            int contador = 0;

            while (contador < 10)
            {
                int codigoEnemigo = Aleatorio.Next(1000, 3000);

                posX = PosicionX.Next(0, 700);
                posY = PosicionY.Next(100, 500);

                bool posicion = true;
                foreach (Control control in Controls)
                {
                    if (control is PictureBox && control.Tag != null && control.Tag.ToString() == "Enemigo")
                    {
                        PictureBox enemigoExistente = (PictureBox)control;
                        if (Math.Abs(enemigoExistente.Location.X - posX) < enemigoExistente.Width &&
                            Math.Abs(enemigoExistente.Location.Y - posY) < enemigoExistente.Height)
                        {
                            // La posición generada se superpone con un enemigo existente
                            posicion = false;
                            break;
                        }
                    }
                }

                if (posicion)
                {
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
                        case > 1500:
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

        private void TimerNuevoEnemigo()
        {
            timerEnemigos.Interval = 100;
            timerEnemigos.Tick += timerEnemigos_Tick;
            timerEnemigos.Start();
        }
        private void timerEnemigos_Tick(object sender, EventArgs e)
        {
            bool EnemigosExistentes = false;

            foreach (Control control in Controls)
            {
                if (control.Tag != null && control.Tag.ToString() == "Enemigo")
                {
                    EnemigosExistentes = true;
                    break;
                }
            }
            // Si no hay enemigos, generar nuevos 
            if (EnemigosExistentes == false)
            {

                GenerarEnemigos();
            }
        }

        private void MostrarExplosion(Point explosionPoint)
        {
            PictureBox explosion = new PictureBox();
            explosion.SizeMode = PictureBoxSizeMode.StretchImage;
            explosion.ImageLocation = "https://i.gifer.com/origin/62/623cdcca882db2d7efa8d32424a61d29_w200.gif";
            explosion.Size = new Size(130, 90);
            explosion.Location = explosionPoint;
            Controls.Add(explosion);

            timerExplosion.Interval = 1000; // Duración de la explosión en milisegundos
            timerExplosion.Tick += (sender, e) =>
            {
                timerExplosion.Stop();
                Controls.Remove(explosion);
                explosion.Dispose();
            };
            timerExplosion.Start();
        }


        int puntaje = 0;
        private void EliminarEnemigo(PictureBox enemigoEliminado)
        {
            // Incrementa el puntaje cuando se elimina un enemigo
            puntaje += 10;

            // Actualiza el valor de la ProgressBar con el nuevo puntaje
            progressBarScore.Value = puntaje;

            Controls.Remove(enemigoEliminado);
            enemigoEliminado.Dispose();

            if (TodosEnemigosEliminados())
            {
                nivelActual++;
                puntaje = 0;
                progressBarScore.Value = puntaje;
                GenerarEnemigos();

                lblNiveles.Text = "Nivel " + nivelActual.ToString();
            }
        }
        private bool TodosEnemigosEliminados()
        {
            foreach (Control control in Controls)
            {
                if (control is PictureBox && control.Tag != null && control.Tag.ToString() == "Enemigo")
                {
                    return false; // Todavía hay enemigos en pantalla
                }
            }
            return true; // No hay enemigos en pantalla
        }

    }
}


