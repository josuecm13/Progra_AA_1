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
            return Darwin.ToArray(bitmap);
        }

    }
}
