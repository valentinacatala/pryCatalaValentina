﻿using Microsoft.VisualBasic.ApplicationServices;
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
            this.Width = 900;
            this.Height = 1000;


            objNaveJugador = new claseNave();
            objNaveJugador.CrearJuego();
            objNaveJugador.imagNave.Location = new Point(350, 700);
            Controls.Add(objNaveJugador.imagNave);

            GenerarEnemigos();
            TimerNuevoEnemigo();
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
            if (imagBala != null)
            {
                imagBala.Top -= 10;
                imagBala.BringToFront();

                if (imagBala.Location.Y <= 0)
                {

                    imagBala.Dispose();
                    imagBala = null;
                    timerDisparos.Stop();
                }
                else
                {
                    // Comprueba si la bala colisiona con algún enemigo
                    foreach (Control imagen in Controls)
                    {
                        if (imagen.Tag == "Enemigo" && imagBala.Bounds.IntersectsWith(imagen.Bounds))
                        {
                            imagBala.Dispose();
                            imagen.Dispose();
                            imagBala = null;
                            timerDisparos.Stop();
                            break;
                        }
                    }
                }
            }


        }

        private void frmJuego_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Space)
            {
                imagBala = new PictureBox();
                imagBala.SizeMode = PictureBoxSizeMode.StretchImage;
                imagBala.ImageLocation = "https://toppng.com/uploads/thumbnail/alaga-galaga-missile-11562887504dfmxt6dqa0.png";
                imagBala.Size = new Size(20, 30);
                imagBala.Location = new Point(objNaveJugador.imagNave.Location.X + objNaveJugador.imagNave.Width / 2 - imagBala.Width / 2, objNaveJugador.imagNave.Location.Y);
                Controls.Add(imagBala);

                timerDisparos.Start();

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
                posY = PosicionY.Next(0, 400);

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

            // Si no hay enemigos, generar nuevos enemigos
            if (!EnemigosExistentes)
            {
                
                GenerarEnemigos();
            }
        }
    }
}


