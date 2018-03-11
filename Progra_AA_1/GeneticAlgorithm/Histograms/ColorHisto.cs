using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra_AA_1.GeneticAlgorithm.Histograms
{
    class ColorHistogram
    {

        public byte[,] Histogram(Bitmap bitmap)
        {
            byte[,] histogram = new byte[3, 256];

            byte red = 0;
            byte green = 0;
            byte blue = 0;

            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    red = bitmap.GetPixel(i, j).R;
                    green = bitmap.GetPixel(i, j).G;
                    blue = bitmap.GetPixel(i, j).B;

                    histogram[0, red] += 1;
                    histogram[1, green] += 1;
                    histogram[2, blue] += 1;
                }
            }
            return histogram;
        }

        public byte[] Normalize(byte[,] matrix)
        {
            byte[] array = new byte[matrix.Length / 3];

            for (int i = 0; i < matrix.Length / 3; i++)
            {
                array[i] = (byte)((matrix[0, i] + matrix[1, i] + matrix[2, i]) / 3);
            }
            return array;
        }

    }
}
