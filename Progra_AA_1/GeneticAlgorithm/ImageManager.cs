using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progra_AA_1.GeneticAlgorithm
{
    class ImageManager
    {
        int quantity;
        int probCrossOver;
        int probMutation;
        int distanceType;
        Bitmap bitmap;
        Imagen[] population;
        Imagen[] ten;

        public ImageManager(int n, Bitmap b, int DistanceType)
        {
            this.bitmap = b;
            distanceType = DistanceType;
        }

        private void GeneratePopulation(int n)
        {
            population = new Imagen[n];
            for (int i = 0; i < n; i++)
            {
                population[i] = new Imagen(DistanceFactory.GetInstance(distanceType),bitmap.Height,bitmap.Width);
            }
        }

    }
}
