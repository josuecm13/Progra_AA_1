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
        private Object acctlock = new Object();
        public long distance;
        private AbsDistance disType;
        public int h, w, Length;
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
            Length = h * w;
            
        }

        private void GenerateImage(int h, int w)
        {
            Random rand = new Random();
            bitmap = new Bitmap(w, h);
            for (int i = 0; i < w; i++)
            {
                for (int j = 0; j < h; j++)
                {
                    int r = rand.Next(256);
                    int g = rand.Next(256);
                    int b = rand.Next(256);
                    bitmap.SetPixel(i, j, Color.FromArgb(255, r, g, b));
                }
            }
        }

        public long ProcessDistance(Bitmap original)
        {
            Bitmap copy = new Bitmap(bitmap);
            if((Mutated) || distance == Int32.MaxValue)
                distance = disType.GetDistance(original, copy);
            Mutated = false;
            return distance;
        }

        public Bitmap Crossin(Bitmap couple, Bitmap original)
        {
            Random rand = new Random();
            Bitmap newBitmap = new Bitmap(h, w);
            for (int i = 0; i < h; i++)
            {
                for (int j = 0; j < w; j++)
                {
                    Color fath = this.bitmap.GetPixel(i, j);
                    Color moth = couple.GetPixel(i, j);
                    int distself = disType.BestPixel(fath,original.GetPixel(i,j));
                    int distcoup = disType.BestPixel(moth, original.GetPixel(i, j));
                    if (distself < distcoup)
                        newBitmap.SetPixel(i, j, fath);
                    else
                        newBitmap.SetPixel(i, j, moth);
                }
            }
            return newBitmap;
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

        public void Mutate(int Changepcnt)
        {
            Random rand = new Random();
            for(int x = 0; x < Changepcnt/100 * h * w; x++)
            {
                int i = rand.Next(h);
                int j = rand.Next(w);
                int r = rand.Next(255);
                int g = rand.Next(255);
                int b = rand.Next(255);
                bitmap.SetPixel(i, j, Color.FromArgb(255,r,g,b));
            }
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
