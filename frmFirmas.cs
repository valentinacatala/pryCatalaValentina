using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryCatalaValentina
{
    public partial class frmFirmas : Form
    {
        private Bitmap ArchivoImagen;
        private string carpetaFirmas;
        public frmFirmas()
        {
            InitializeComponent();
            ArchivoImagen = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            carpetaFirmas = "firmas";
            if (!Directory.Exists(carpetaFirmas))
            {
                Directory.CreateDirectory(carpetaFirmas);
            }
        }

        private void frmFirmas_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                using (Graphics objetoLoco = Graphics.FromImage(ArchivoImagen))
                {
                    objetoLoco.FillEllipse(Brushes.White, e.X, e.Y, 5, 5);
                }
                pictureBox1.Image = ArchivoImagen;
            }
        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            string FechaActual = DateTime.Now.ToString("(yyyy.MM.dd) HH.mm");
            string nombreArchivo = $"{FechaActual}.png";
            string Guardar = Path.Combine(carpetaFirmas, nombreArchivo);

            ArchivoImagen.Save(Guardar, System.Drawing.Imaging.ImageFormat.Jpeg);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            ArchivoImagen = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = ArchivoImagen;
        }
    }
}
