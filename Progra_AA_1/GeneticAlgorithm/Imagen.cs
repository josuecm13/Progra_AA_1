using Progra_AA_1.GeneticAlgorithm.Distance;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra_AA_1.GeneticAlgorithm
{
    class Imagen : IComparable
    {
        public Bitmap bitmap { get; set; }

        public long distance;
        private AbsDistance disType;
        int h, w;
        int porcMutation;
        private bool Mutated = false;

        public Imagen(AbsDistance distype, int height, int width, int porcMutation ,int yn)
        {
            distance = Int32.MaxValue;
            this.disType = distype;
            h = height;
            w = width;
            this.porcMutation = porcMutation;
            if(yn != 1)
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

        public long ProcessDistance(Bitmap original)
        { 
            if((Mutated) || distance == Int32.MaxValue)
                distance = disType.GetDistance(original, bitmap);
            Mutated = false;
            return distance;
        }

        public Bitmap Crossing(Bitmap couple)
        {
            Random rand = new Random();
            Bitmap newBitmap = new Bitmap(h, w);
            int MOTHER = 1;
            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    int chance = rand.Next(2);
                    if(chance != MOTHER)
                        newBitmap.SetPixel(i, j, this.bitmap.GetPixel(i,j));
                    else
                        newBitmap.SetPixel(i, j, couple.GetPixel(i, j));
                }
            }
            return newBitmap;
        }

        public void Mutate()
        {
            Random rand = new Random();
            int times = (int)(h * w * (porcMutation/100));
            for (int x = 0; x < times; x++)
            {
                int i = rand.Next(h);
                int j = rand.Next(w);
                bitmap.SetPixel(i, j, Color.FromArgb(255, rand.Next(255), rand.Next(255), rand.Next(255)));
            }
            Mutated = true;
        }

        public int CompareTo(object obj)
        {
            Imagen img = (Imagen)obj;
            if (this.distance > img.distance)
                return 1;
            if (this.distance < img.distance)
                return -1;
            return 0;
        }
    }
}
