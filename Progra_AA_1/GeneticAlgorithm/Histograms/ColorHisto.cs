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
            
            byte[] colorArray = Darwin.ToArray(bitmap);
            /*
            byte[,] histogram = new byte[3, 256];
            byte red = 0;
            byte green = 0;
            byte blue = 0;

            for (int e = 0; e < colorArray.Length; e += 3)
            {
                histogram[0, colorArray[e]] += 1;
                histogram[1, colorArray[e + 1]] += 1;
                histogram[2, colorArray[e + 2]] += 1;
            }
            */
            return colorArray;
        }


    }
}
