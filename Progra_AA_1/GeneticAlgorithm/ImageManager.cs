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
        int histOption;
        int pMutIndiv, pSelection;
        Bitmap bitmap;
        public Imagen[] population;
        public Imagen[] ten;
        private int index = 0;
        private Imagen[] selection;

        public ImageManager(int n, Bitmap b, int DistanceType, int probCrossOver, int probMutation, int pMutIndiv)
        {
            this.probCrossOver = probCrossOver;
            this.probMutation = probMutation;
            this.pMutIndiv = pMutIndiv;
            this.bitmap = b;
            distanceType = DistanceType;
            ten = new Imagen[10];
            selection = new Imagen[(int)(n * 0.3 * 0.2)];
            GeneratePopulation(n);

        }

        public ImageManager(int n, Bitmap b, int DistanceType, int probCrossOver, int probMutation, int pMutIndiv, int pSelection, int histOption)
        {
            this.probCrossOver = probCrossOver;
            this.probMutation = probMutation;
            this.pMutIndiv = pMutIndiv;
            this.pSelection = pSelection;
            this.bitmap = b;
            this.histOption = histOption;
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
                population[i] = new Imagen(DistanceFactory.GetInstance(distanceType),bitmap.Height,bitmap.Width,probMutation,YES, histOption);
            }
        }


        public void Evaluate()
        {
            foreach (Imagen i in population)
            {
                i.ProcessDistance(bitmap);
            }
            Array.Sort(population);
            int distance = (int) population[0].distance;
            Console.WriteLine("distance: " + distance);//Console.WriteLine("fitness:" + (100-(population[0].distance/(population[0].Length *255)) * 100) +"%");
        }


        public void Mutate()
        {
            Random rand = new Random();
            for (int i = 0; i < probMutation/100 * population.Length; i ++)
            {
                int index = rand.Next(population.Length);
                while(population[index].Selected)
                    index = rand.Next(population.Length);
                population[index].Mutate(pMutIndiv);
            }
        }

        public void Selection()
        {
            Random rand = new Random();
            int times = (population.Length * (pSelection / 100));
            Imagen[] selected = new Imagen[times];
            for(int i = 0; i < times; i++)
            {
                int index = rand.Next(times * 2 );
                population[index].Selected = true;
            }
        }

        

        public void CrossOver()
        {
            Random rand = new Random();
            int proi = 0;
            for(int i = 0; i < probCrossOver; i++)
            {
                int father = rand.Next((int)(population.Length));
                int mother = rand.Next((int)(population.Length));
                int victim = population.Length - 1;//(int)(rand.Next(population.Length/10) + population.Length*0.8);
                Bitmap son;
                son = population[father].Crossing(population[mother].bitmap);
                Imagen newImg = new Imagen(DistanceFactory.GetInstance(distanceType), bitmap.Height, bitmap.Width, probMutation, NO, histOption);
                newImg.bitmap = son;
                newImg.ProcessDistance(bitmap);
                population[victim] = newImg;
                Array.Sort(population);
            }
        }

        public void CrossO()
        {
            Random rand = new Random();
            for (int i = 0; i < probCrossOver; i++)
            {
                int father = rand.Next((int)(population.Length));
                int mother = rand.Next((int)(population.Length));
                int victim = population.Length - 1;//(int)(rand.Next(population.Length/10) + population.Length*0.8);
                Bitmap son;
                son = population[father].Crossin(population[mother].bitmap, bitmap);
                Imagen newImg = new Imagen(DistanceFactory.GetInstance(distanceType), bitmap.Height, bitmap.Width, probMutation, NO, histOption);
                newImg.bitmap = son;
                newImg.ProcessDistance(bitmap);
                population[victim] = newImg;
                Array.Sort(population);
            }
        }

        public void NewGeneration()
        {
            int bye = (int) (population.Length - 2 - (population.Length * 0.05));
            for (int i = population.Length - 1; i > bye; i--)
            {
                population[i] = new Imagen(DistanceFactory.GetInstance(distanceType), bitmap.Height, bitmap.Width, probMutation, YES, histOption);
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
