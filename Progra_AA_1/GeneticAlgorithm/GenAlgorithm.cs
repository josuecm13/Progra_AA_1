using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra_AA_1.GeneticAlgorithm
{
    class GenAlgorithm
    {
        public Bitmap destino;
        int probCrossOver, probMutation, generations, prob;

        public GenAlgorithm(int n, Bitmap bitmap, int distanceType, int probCrossOver, int probMutation, int generations)
        {
            ImageManager manager = new ImageManager(n,destino,distanceType);
        }

    }
}
