using Progra_AA_1.GeneticAlgorithm;
using Progra_AA_1.GeneticAlgorithm.Distance;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Progra_AA_1.Views.Image_Form
{
    public partial class ImageViewer : Form
    {
        string filename;

        public ImageViewer()
        {
            InitializeComponent();
        }


        public void SetDesireImage(string filename)
        {
            Bitmap bitmap = new Bitmap(filename);
            originalPictureBox.Image = bitmap;
            SetRandomImage(bitmap);
        }

        private void SetRandomImage(Bitmap b)
        {
            Imagen img = new Imagen(new Manhattan(),b.Height, b.Width);
            randomPicBox.Image = img.bitmap;
        }
        

    }
}
