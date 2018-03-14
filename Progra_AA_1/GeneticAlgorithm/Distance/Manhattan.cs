using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra_AA_1.GeneticAlgorithm.Distance
{
    class Manhattan : AbsDistance
    {
        public override int BestPixel(Color x, Color y)
        {
            int r = Math.Abs(x.R - y.R);
            int g = Math.Abs(x.G - y.G);
            int b = Math.Abs(x.B - y.B);
            return r + g + b;
        }

        public override long GetDistance(Bitmap img, Bitmap selfImg, int type)
        {
            if (type == 0)
            {
                return GetDistColor(img, selfImg);
            }
            else
            {
                return GetHistDist(img, selfImg);
            }
        }

        private long GetDistColor(Bitmap img, Bitmap selfImg)
        {
            long output = 0;
            byte[] histImg = Histograms.ColorHistogram.Histogram(img);
            byte[] histSelf = Histograms.ColorHistogram.Histogram(selfImg);
            for (int i = 0; i < histImg.Length; i++)
            {
                int R = Math.Abs(histImg[i] - histSelf[i]);
                i++;
                int G = Math.Abs(histImg[i] - histSelf[i]);
                i++;
                int B = Math.Abs(histImg[i] - histSelf[i]);
                output += (R + G + B)/3; 
            }
            return output;
        }

        private long GetHistDist(Bitmap img, Bitmap selfImg)
        {
            long output = 0;
            byte[] histImg = Histograms.Contrast.ContrastHistogram(img);
            byte[] histSelf = Histograms.Contrast.ContrastHistogram(selfImg);
            for (int i = 0; i < histImg.Length; i++)
            {
                output += Math.Abs(histImg[i] - histSelf[i]);
            }
            return output;
        }

    }
}
