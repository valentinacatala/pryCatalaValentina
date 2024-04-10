using System;
using System.Collections.Generic;
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
        

        public void CrearJuego()
        {
            vida = 100;
            nombre = "jugador1";
            puntosdaño = 1;

            imagNave= new PictureBox();
            imagNave.SizeMode=PictureBoxSizeMode.StretchImage;
            imagNave.ImageLocation = "https://preview.redd.it/made-the-galaga-ship-in-ksp-v0-v9hgbb8e3hra1.jpg?width=894&format=pjpg&auto=webp&s=3bfb03efb8726c6efa1655e26bdf2bd7c281ac2b";


        }

        public void CrearEnemigo()
        {
            vida = 25;
            nombre = "maligno1";
            puntosdaño = 2;

            imagNave= new PictureBox();
            imagNave.SizeMode = PictureBoxSizeMode.StretchImage;
            imagNave.ImageLocation = "https://steamuserimages-a.akamaihd.net/ugc/510378163431176780/C5FF698338D98764BD4A44185C169A7F3B8FE7AD/?imw=637&imh=358&ima=fit&impolicy=Letterbox&imcolor=%23000000&letterbox=true";

            




        }
    }
}
