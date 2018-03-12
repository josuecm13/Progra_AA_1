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
        GenAlgorithm ga { get; set; }
        int population, generations, pMutation, pCross, distype;

        public ImageViewer()
        {
            InitializeComponent();
        }

        
        public void SetComponents(int population,int generations,int pMutation,int pCross, int distype,int pMutIndiv,int pSelection,Bitmap b)
        {
            ga = new GenAlgorithm(population,b,distype,pCross,pMutation,generations,pMutIndiv,pSelection,this);
        }


        public void SetDesireImage(string filename)
        {
            Bitmap bitmap = new Bitmap(filename);
            originalPictureBox.Image = bitmap;
        }

        private void SetRandomImage(Bitmap b)
        {
            Imagen img = new Imagen(new Manhattan(),b.Height, b.Width,0,0);
            randomPicBox.Image = img.bitmap;
        }

        public void UpdatePicture(int i)
        {
            randomPicBox.Image = ga.manager.population[0].bitmap;
        }

        private void txtbox_console_TextChanged(object sender, EventArgs e)
        {

        }

        public void Run()
        {
            ga.Run();
        }
    }
}
