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
        public static byte YES = 0;
        public static byte NO = 1;
        int probCrossOver;
        int probMutation;
        int distanceType;
        Bitmap bitmap;
        Imagen[] population;
        public Imagen[] ten;
        private int index = 0;
        private Imagen[] selection;

        public ImageManager(int n, Bitmap b, int DistanceType, int probCrossOver, int probMutation)
        {
            this.probCrossOver = probCrossOver;
            this.probMutation = probMutation;
            this.bitmap = b;
            distanceType = DistanceType;
            ten = new Imagen[10];
            selection = new Imagen[(int)(n * 0.3 * 0.2)];
            GeneratePopulation(n);
        }

        private void GeneratePopulation(int n)
        {
            population = new Imagen[n];
            for (int i = 0; i < n; i++)
            {
                population[i] = new Imagen(DistanceFactory.GetInstance(distanceType),bitmap.Height,bitmap.Width,probMutation,YES);
            }
        }


        public void Evaluate()
        {
            foreach (Imagen i in population)
            {
                i.ProcessDistance(bitmap);
            }
            Array.Sort(population);
            Console.WriteLine("0:" + population[0].distance + " last index:" + population[population.Length -1].distance);
        }

        public void Reproduction()
        {

        }

        public void Mutate()
        {
            Random rand = new Random();
            for (int i = 0; i < probMutation/100 * population.Length; i ++)
            {
                int index = rand.Next(population.Length);
                population[index].Mutate();
            }
        }

        public void CrossOver()
        {
            Random rand = new Random();
            int proi = 0;
            for(int i = 0; i < probCrossOver; i++)
            {
                int father = rand.Next((int)(population.Length*0.3));
                int mother = rand.Next((population.Length));
                int victim = population.Length - 1;//(int)(rand.Next(population.Length/10) + population.Length*0.8);
                Bitmap son = population[father].Crossing(population[mother].bitmap);
                Imagen newImg = new Imagen(DistanceFactory.GetInstance(distanceType), bitmap.Height, bitmap.Width, probMutation, NO);
                newImg.bitmap = son;
                newImg.ProcessDistance(bitmap);
                population[victim] = newImg;
                if(proi < probMutation)
                {
                    population[victim].Mutate();
                }
                Array.Sort(population);
            }

        }

        public void NewGeneration()
        {
            int bye = (int) (population.Length - 2 - (population.Length * 0.05));
            for (int i = population.Length - 1; i > bye; i--)
            {
                population[i] = new Imagen(DistanceFactory.GetInstance(distanceType), bitmap.Height, bitmap.Width, probMutation, YES);
            }
        }

        public int updateTopTen()
        {
            if (index < 10)
            {
                ten[index] = population[0];
                return index++;
            }
            return index;
        }

    }
}
