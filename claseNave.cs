using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace pryCatalaValentina
{
    internal class claseNave
    {
        public int vida;
        public string nombre;
        int puntosdaño;
        public PictureBox imagNave;
        public PictureBox imagEnemigo1;
        public PictureBox imagEnemigo2;
        public PictureBox imagEnemigo3;
        public PictureBox imagEnemigo4;
        public PictureBox imagEnemigo5;
        public PictureBox imagBala;

        public void CrearJuego()
        {
            vida = 100;
            nombre = "jugador1";
            puntosdaño = 50;

            imagNave= new PictureBox();
            imagNave.SizeMode=PictureBoxSizeMode.StretchImage;
            imagNave.ImageLocation = "https://preview.redd.it/made-the-galaga-ship-in-ksp-v0-v9hgbb8e3hra1.jpg?width=894&format=pjpg&auto=webp&s=3bfb03efb8726c6efa1655e26bdf2bd7c281ac2b";
            imagNave.Size = new Size(120, 70);

        }

        public void CrearEnemigo()
        {
            vida = 30;
            nombre = "Enemigo1";
            puntosdaño = 50;
            imagEnemigo1 = new PictureBox();
            imagEnemigo1.SizeMode = PictureBoxSizeMode.StretchImage;
            imagEnemigo1.ImageLocation = "https://38.media.tumblr.com/f9d63a3eab931934425d7d8d98e48416/tumblr_inline_mlmyhgzoKU1qz4rgp.gif";
            imagEnemigo1.Size = new Size(150, 100);
            

            vida = 25;
            nombre = "Enemigo2";
            puntosdaño = 50;
            imagEnemigo2 = new PictureBox();
            imagEnemigo2.SizeMode = PictureBoxSizeMode.StretchImage;
            imagEnemigo2.ImageLocation = "https://art.pixilart.com/46897995ff44.gif";
            imagEnemigo2.Size = new Size(150, 100);


            vida = 20;
            nombre = "Enemigo3";
            puntosdaño = 50;
            imagEnemigo3 = new PictureBox();
            imagEnemigo3.SizeMode = PictureBoxSizeMode.StretchImage;
            imagEnemigo3.ImageLocation = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRYcfCkWlJRkelAI68_ugZzeULa7_yYF7_ujXMI5Ujz7Hi27Z12dBrbZL_L3XDi9J6fN2c&usqp=CAU";
            imagEnemigo3.Size = new Size(130, 100);

        }

       
        
    }
}
