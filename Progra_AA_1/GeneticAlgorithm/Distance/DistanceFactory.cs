using Progra_AA_1.GeneticAlgorithm.Distance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra_AA_1.GeneticAlgorithm
{
    static class DistanceFactory
    {
        enum Type { MANHATTAN, DARWIN }

        public static AbsDistance GetInstance(int i)
        {
            switch ((Type)i)
            {
                case Type.MANHATTAN:
                    return new Manhattan();
                case Type.DARWIN:
                    return new Darwin();
                default:
                    return null;
            }
        }
    }
}
