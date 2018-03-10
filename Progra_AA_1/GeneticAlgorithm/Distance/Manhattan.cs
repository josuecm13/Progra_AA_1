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

        public override long GetDistance(Bitmap img, Bitmap selfImg)
        {
            long output = 0;
            for (int i = 0; i <img.Height ; i++)
            {
                for(int j = 0; j < img.Width; j++)
                {
                    Color opxl = img.GetPixel(i, j);
                    Color spxl = selfImg.GetPixel(i, j);
                    int r = Math.Abs(opxl.R - spxl.R);
                    int g = Math.Abs(opxl.G - spxl.G);
                    int b = Math.Abs(opxl.B - spxl.B);
                    output +=  (r + g + b)/3;
                }
            }
            return output;
        }
    }
}
