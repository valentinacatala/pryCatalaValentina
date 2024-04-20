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
            puntosdaño = 1;

            imagNave= new PictureBox();
            imagNave.SizeMode=PictureBoxSizeMode.StretchImage;
            imagNave.ImageLocation = "https://preview.redd.it/made-the-galaga-ship-in-ksp-v0-v9hgbb8e3hra1.jpg?width=894&format=pjpg&auto=webp&s=3bfb03efb8726c6efa1655e26bdf2bd7c281ac2b";
            imagNave.Size = new Size(150, 100);

        }

        public void CrearEnemigo()
        {
            vida = 25;
            nombre = "Enemigo1";
            puntosdaño = 2;
            imagEnemigo1= new PictureBox();
            imagEnemigo1.SizeMode = PictureBoxSizeMode.StretchImage;
            imagEnemigo1.ImageLocation = "https://steamuserimages-a.akamaihd.net/ugc/510378163431176780/C5FF698338D98764BD4A44185C169A7F3B8FE7AD/?imw=637&imh=358&ima=fit&impolicy=Letterbox&imcolor=%23000000&letterbox=true";
            imagEnemigo1.Size = new Size(150, 100);

            vida = 25;
            nombre = "Enemigo2";
            puntosdaño = 2;
            imagEnemigo2 = new PictureBox();
            imagEnemigo2.SizeMode = PictureBoxSizeMode.StretchImage;
            imagEnemigo2.ImageLocation = "https://static.wikia.nocookie.net/villains/images/b/b1/Cover256x256-99b1c09b43754854941695731f08bee7.jpg/revision/latest/scale-to-width-down/250?cb=20170622072933";
            imagEnemigo2.Size = new Size(90, 100);

            vida = 25;
            nombre = "Enemigo3";
            puntosdaño = 2;
            imagEnemigo3 = new PictureBox();
            imagEnemigo3.SizeMode = PictureBoxSizeMode.StretchImage;
            imagEnemigo3.ImageLocation = "https://art.pixilart.com/thumb/5ce2059e8521.png";
            imagEnemigo3.Size = new Size(90, 100);

        }

        
        public void DispararBala()
        {
           

            imagBala = new PictureBox();
            imagBala.SizeMode = PictureBoxSizeMode.StretchImage;
            imagBala.ImageLocation = "https://toppng.com/uploads/thumbnail/alaga-galaga-missile-11562887504dfmxt6dqa0.png";
            imagBala.Size = new Size(30, 40);
            imagBala.Location = new Point(imagNave.Location.X + (imagNave.Width / 2) - (imagBala.Width / 2), imagNave.Location.Y);

            Form.ActiveForm.Controls.Add(imagBala);

            Timer timerBala = new Timer();
            timerBala.Interval = 20;
            timerBala.Tick += (sender, e) =>
            {
                imagBala.Top -= 10;
                imagBala.BringToFront();

                foreach (Control control in Form.ActiveForm.Controls)
                {
                    if (control is PictureBox && control.Tag != null && control.Tag.ToString() == "Enemigo")
                    {
                        PictureBox enemigo = (PictureBox)control;
                        if (imagBala.Bounds.IntersectsWith(enemigo.Bounds))
                        {
                            timerBala.Stop();
                            Form.ActiveForm.Controls.Remove(imagBala);
                            Form.ActiveForm.Controls.Remove(enemigo);
                            imagBala.Dispose();
                            enemigo.Dispose();
                            return;
                        }
                    }
                };

                if (imagBala.Top + imagBala.Height < 0)
                {
                    timerBala.Stop();
                    Form.ActiveForm.Controls.Remove(imagBala);
                    imagBala.Dispose();
                }
            };
            timerBala.Start();

        }

             
        
    }
}
