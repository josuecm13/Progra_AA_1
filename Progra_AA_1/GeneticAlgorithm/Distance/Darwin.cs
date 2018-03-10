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
        public override long GetDistance(Bitmap img, Bitmap selfImg)
        {
            byte[] pixels1 = ToArray(img);
            byte[] pixels2 = ToArray(selfImg);

            long result = DarwinDistance(pixels1, pixels2);
            return result;
        }

        public byte[] ToArray(Bitmap bitmp)
        {
            var bitmapData = bitmp.LockBits(new Rectangle(0, 0, bitmp.Width, bitmp.Height), ImageLockMode.ReadWrite, PixelFormat.Format8bppIndexed);
            //int bytes = bitmp.Width * bitmp.Height * (Image.GetPixelFormatSize(PixelFormat.Canonical) / 8);
            int bytes = Math.Abs(bitmapData.Stride) * bitmp.Height;
            byte[] b1bytes = new byte[bytes];

            // Copy bitmap to byte[]
            Marshal.Copy(bitmapData.Scan0, b1bytes, 0, bytes);

            bitmp.UnlockBits(bitmapData);
            return b1bytes;
        }

        public int DarwinAux(byte[] byte1, byte[] byte2)
        {
            int max = 0;
            int maxAux = 0;

            int scale = byte1.Length / 9;
            int o = 0;
            for (int i = 0; i <= byte1.Length - 1; i++)
            {
                maxAux = Math.Abs(byte1[i] - byte2[i]);
                if (maxAux > max)
                {
                    max = maxAux;
                    o = i;
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

            int e = finalArray.Sum() / 9;

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

    }
}
