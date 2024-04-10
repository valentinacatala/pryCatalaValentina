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
        public PictureBox imagEnemigo1;
        public PictureBox imagEnemigo2;
        public PictureBox imagEnemigo3;


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
            nombre = "Enemigo1";
            puntosdaño = 2;
            imagEnemigo1= new PictureBox();
            imagEnemigo1.SizeMode = PictureBoxSizeMode.StretchImage;
            imagEnemigo1.ImageLocation = "https://steamuserimages-a.akamaihd.net/ugc/510378163431176780/C5FF698338D98764BD4A44185C169A7F3B8FE7AD/?imw=637&imh=358&ima=fit&impolicy=Letterbox&imcolor=%23000000&letterbox=true";


            vida = 25;
            nombre = "Enemigo2";
            puntosdaño = 2;
            imagEnemigo2 = new PictureBox();
            imagEnemigo2.SizeMode = PictureBoxSizeMode.StretchImage;
            imagEnemigo2.ImageLocation = "https://static.wikia.nocookie.net/villains/images/b/b1/Cover256x256-99b1c09b43754854941695731f08bee7.jpg/revision/latest/scale-to-width-down/250?cb=20170622072933";

            vida = 25;
            nombre = "Enemigo3";
            puntosdaño = 2;
            imagEnemigo3 = new PictureBox();
            imagEnemigo3.SizeMode = PictureBoxSizeMode.StretchImage;
            imagEnemigo3.ImageLocation = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcT72ejL_hd9gjTFSAXRltuO0FoLKlubQw7Cxd-T5fZUioR3BJ8cbBdhJEl1dFNToTlGdOU&usqp=CAU";

        }
    }
}
