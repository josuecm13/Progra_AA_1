using Progra_AA_1.GeneticAlgorithm.Distance;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra_AA_1.GeneticAlgorithm
{
    class Imagen
    {
        public Bitmap bitmap { get; set; }
        int distance;
        private AbsDistance disType;

        public Imagen(AbsDistance distance, int height, int width)
        {
            this.disType = distance;
            GenerateImage(height, width);
        }

        private void GenerateImage(int h, int w)
        {
            Random rand = new Random();
            bitmap = new Bitmap(h, w);
            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    int r = rand.Next(255);
                    int g = rand.Next(255);
                    int b = rand.Next(255);
                    bitmap.SetPixel(i, j, Color.FromArgb(255, r, g, b));
                }
            }
        }

    }
}
