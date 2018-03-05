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
        public override int GetDistance(Bitmap img, Bitmap selfImg)
        {
            uint output = 0;
            for (int i = 0; i <img.Height ; i++)
            {
                for(int j = 0; j < img.Width; j++)
                {
                    Color opxl = img.GetPixel(i, j);
                    Color spxl = selfImg.GetPixel(i, j);
                    uint r = (uint) opxl.R - spxl.R;
                    uint g = (uint) opxl.G - spxl.G;
                    uint b = (uint) opxl.B - spxl.B;
                    output +=  (r + g + b);
                }
            }
            return (int) output;
        }
    }
}
