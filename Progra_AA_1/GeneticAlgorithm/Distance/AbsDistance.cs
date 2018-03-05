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
        public Byte[] histogram;
        public abstract int GetDistance(Color[] img, Color[] selfImg);
    }
}
