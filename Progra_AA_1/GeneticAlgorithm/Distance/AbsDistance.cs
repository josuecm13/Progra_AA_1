using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra_AA_1.GeneticAlgorithm.Distance
{
    abstract class AbsDistance
    {
        public int Type;
        public Byte[] histogram;
        public abstract long GetDistance(Bitmap img, Bitmap selfImg);
        public abstract int BestPixel(Color a, Color b);
    }
}
