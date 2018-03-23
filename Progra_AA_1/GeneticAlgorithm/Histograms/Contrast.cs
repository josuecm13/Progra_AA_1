using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra_AA_1.GeneticAlgorithm.Histograms
{
    static class Contrast
    {
        public static byte[] ContrastHistogram(Bitmap bitmap)
        {
            byte[] histogram = new byte[bitmap.Width * bitmap.Height];

            Color color;
            byte max = 0;

            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    color = bitmap.GetPixel(i, j);
                    max = Math.Max(Math.Max(color.R, color.G), color.B);
                    histogram[(i + 1) * j] = (byte)Math.Abs(max - ((color.R + color.B + color.G) - max));
                }
            }
            return histogram;  
        }

    }
}
