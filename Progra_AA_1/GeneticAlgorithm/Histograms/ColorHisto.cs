using Progra_AA_1.GeneticAlgorithm.Distance;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra_AA_1.GeneticAlgorithm.Histograms
{
    static class ColorHistogram
    {

        public static byte[] Histogram(Bitmap bitmap)
        {  
            
            byte[] histogram = new byte[bitmap.Width * bitmap.Height];

            Color color;

            int e = 0;

            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    color = bitmap.GetPixel(i, j);
                    histogram[e] = color.R;
                    histogram[e+1] = color.B;
                    histogram[e+2] = color.G;
                    e += 3;
                }
            }

            return Darwin.ToArray(bitmap);
        }

    }
}
