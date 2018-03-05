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
        public override int GetDistance(Color[] img, Color[] selfImg)
        {
            uint output = 0;
            for (int i = 0; i <img.Length ; i++)
            {
                uint r = (uint) img[i].R - selfImg[i].R;
                uint g = (uint) img[i].G - selfImg[i].G;
                uint b = (uint) img[i].B - selfImg[i].B;
                output +=  (r + g + b);
            }
            return (int) output;
        }
    }
}
