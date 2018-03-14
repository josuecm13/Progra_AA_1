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
                    colorArray = InsertionSort(colorArray);
                    histogram[(i + 1) * j] = (byte)Math.Abs(colorArray[2] - (colorArray[1] + colorArray[0]));
                    result[Math.Abs(colorArray[2] - (colorArray[1] + colorArray[0]))] += 1;
                }
            }
            return result;
        }

        public static byte[] InsertionSort(byte[] arr)
        {
            int i, key, j;
            for (i = 1; i < arr.Length; i++)
            {
                key = arr[i];
                j = i - 1;

                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = (byte)key;
            }
            return arr;
        }

    }
}
