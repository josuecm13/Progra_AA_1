using Progra_AA_1.GeneticAlgorithm;
using Progra_AA_1.GeneticAlgorithm.Distance;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
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

        
        public void SetComponents(int population,int generations,int pMutation,int pCross, int distype,int pMutIndiv,int pSelection,Bitmap b, int histOption)
        {
            ga = new GenAlgorithm(population,b,distype,pCross,pMutation,generations,pMutIndiv,pSelection,this, histOption);
        }


        public void SetDesireImage(string filename)
        {
            Bitmap bitmap = new Bitmap(filename);
            originalPictureBox.Image = Imagen.ResizeImage(bitmap, 300, 300);
        }

        private void originalPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void randomPicBox_Click(object sender, EventArgs e)
        {

        }

        private void originalPictureBox_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Top10 form = new Top10();
            ga.manager.updateTopTen();
            form.SetTop10(ga.manager.ten);
            form.Show();
        }

        public void UpdatePicture()
        {
            randomPicBox.Image = Imagen.ResizeImage(ga.manager.population[0].bitmap, 300, 300);
        }

        public void UpdatePicture(int i)
        {
            randomPicBox.Image = Imagen.ResizeImage(ga.manager.ten[i].bitmap, 300, 300);
        }

        private void txtbox_console_TextChanged(object sender, EventArgs e)
        {

        }

        public void SwitchTopTen()
        {
            top10btn.Enabled = !top10btn.Enabled;
        }

        public void Run()
        {
            ga.Run();
        }
    }
}
