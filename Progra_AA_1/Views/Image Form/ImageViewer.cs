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
        }
        

    }
}
