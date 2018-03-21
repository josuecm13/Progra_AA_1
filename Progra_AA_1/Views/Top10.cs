
using Progra_AA_1.GeneticAlgorithm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Progra_AA_1.Views
{
    public partial class Top10 : Form
    {

        Imagen[] top10;

        public Top10()
        {
            InitializeComponent();
        }

        public void SetTop10 (object[] top10)
        {
            this.top10 = (Imagen[])top10;

            Imagen img1 = (Imagen)top10[0];
            Imagen img2 = (Imagen)top10[1];
            Imagen img3 = (Imagen)top10[2];
            Imagen img4 = (Imagen)top10[3];
            Imagen img5 = (Imagen)top10[4];
            Imagen img6 = (Imagen)top10[5];
            Imagen img7 = (Imagen)top10[6];
            Imagen img8 = (Imagen)top10[7];
            Imagen img9 = (Imagen)top10[8];
            Imagen img10 = (Imagen)top10[9];

            pictureBox1.Image = img1.bitmap;
            pictureBox2.Image = img2.bitmap;
            pictureBox3.Image = img3.bitmap;
            pictureBox4.Image = img4.bitmap;
            pictureBox5.Image = img5.bitmap;
            pictureBox6.Image = img6.bitmap;
            pictureBox7.Image = img7.bitmap;
            pictureBox8.Image = img8.bitmap;
            pictureBox9.Image = img9.bitmap;
            pictureBox10.Image = img10.bitmap;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Top10_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                Bitmap bitmap = new Bitmap(top10[0].w * 10, top10[0].h);
                using (Graphics g = Graphics.FromImage(bitmap))
                {
                    for (int i = 0; i < 10; i++)
                    {
                        g.DrawImage(top10[i].bitmap, top10[0].w * i, 0);
                    }
                }
                bitmap.Save(dialog.FileName, ImageFormat.Jpeg);
            }
        }
    }
}
