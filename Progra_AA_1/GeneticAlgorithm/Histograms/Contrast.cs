using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra_AA_1.GeneticAlgorithm.Histograms
{
    class Contrast
    {
        public byte[] ContrastHistogram(Bitmap bitmap)
        {
            byte[] histogram = new byte[bitmap.Width * bitmap.Height];
            byte[] result = new byte[256];

            Color color;

            byte[] colorArray = new byte[3];

            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    color = bitmap.GetPixel(i, j);
                    colorArray[0] = color.R;
                    colorArray[1] = color.G;
                    colorArray[2] = color.B;
                    Array.Sort(colorArray);
                    histogram[(i + 1) * j] = (byte)Math.Abs(colorArray[2] - (colorArray[1] + colorArray[0]));
                    result[Math.Abs(colorArray[2] - (colorArray[1] + colorArray[0]))] += 1;
                }
            }
            return result;
        }
    }
}
