﻿using Progra_AA_1.GeneticAlgorithm.Histograms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Progra_AA_1.GeneticAlgorithm.Distance
{
    class Darwin : AbsDistance
    {
        public override long GetDistance(Bitmap img, Bitmap selfImg, int type)
        {
            long result;
            byte[] pixels1;
            byte[] pixels2;
            var watch = System.Diagnostics.Stopwatch.StartNew();
            if (type == 0)
            {
                pixels1 = ColorHistogram.Histogram(img);
                watch.Stop();
                pixels2 = ColorHistogram.Histogram(selfImg);
                Console.WriteLine("Hpropio: " + watch.ElapsedMilliseconds);
                watch = System.Diagnostics.Stopwatch.StartNew();
                result = DarwinDistance(pixels1, pixels2);
                watch.Stop();
                Console.WriteLine("Casas" + watch.ElapsedMilliseconds);
            } else
            { 
                pixels1 = Contrast.ContrastHistogram(img);
                watch.Stop();
                pixels2 = Contrast.ContrastHistogram(selfImg);
                Console.WriteLine("Hpropio: " + watch.ElapsedMilliseconds);
                watch = System.Diagnostics.Stopwatch.StartNew();
                result = DarwinDistance(pixels1, pixels2);
                Console.WriteLine("Darwin: " + watch.ElapsedMilliseconds);
                
            }
            return result;
        }

        public static byte[] ToArray(Bitmap bitmp)
        {
            var bitmapData = bitmp.LockBits(new Rectangle(0, 0, bitmp.Width, bitmp.Height), ImageLockMode.ReadWrite, PixelFormat.Format24bppRgb);
            int bytes = Math.Abs(bitmapData.Stride) * bitmp.Height;
            byte[] b1bytes = new byte[bytes];

            Marshal.Copy(bitmapData.Scan0, b1bytes, 0, bytes);
            bitmp.UnlockBits(bitmapData);

            return b1bytes;
        }

        public int DarwinAux(byte[] byte1, byte[] byte2)
        {
            int max = 0;
            int maxAux = 0;

            for (int i = 0; i <= byte1.Length - 1; i++)
            {
                maxAux = Math.Abs(byte1[i] - byte2[i]);
                if (maxAux > max)
                {
                    max = maxAux;
                }
            }
            return max;
        }

        public int DarwinDistance(byte[] byte1, byte[] byte2)
        {
            byte[][] array1 = Divide(byte1);
            byte[][] array2 = Divide(byte2);

            int[] finalArray = new int[array1.Length];

            for (int i = 0; i < array1.Length; i++)
            {
                finalArray[i] = DarwinAux(array1[i], array2[i]);
            }

            int e = finalArray.Sum();

            return e;
        }

        public byte[][] Divide(byte[] matrix)
        {
            int auxLength = matrix.Length / 9;
            byte[][] auxMatrix = new byte[9][];

            int indice = 0;

            for (int i = 0; i < 9; i++)
            {
                auxMatrix[i] = (new byte[auxLength]);

                Array.Copy(matrix, indice, (Array)auxMatrix.GetValue(i), 0, auxLength);
                indice = indice + auxLength;
                if (i + 1 == 8)
                {
                    indice = (matrix.Length - auxLength);
                }
            }

            return auxMatrix;
        }

        public override int BestPixel(Color x, Color y)
        {
            int r = Math.Abs(x.R - y.R);
            int g = Math.Abs(x.G - y.G);
            int b = Math.Abs(x.B - y.B);
            return r + g + b;
        }
    }
}
