﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Progra_AA_1.Views.Image_Form;

namespace Progra_AA_1.GeneticAlgorithm
{
    class GenAlgorithm 
    {

        public Object locker = new Object();
        ImageViewer window;
        public Bitmap destino;
        int generations, tenpercent;
        public ImageManager manager { get; }

        public GenAlgorithm(int n, Bitmap bitmap, int distanceType, int probCrossOver, int probMutation, int generations,int pMutIndiv, ImageViewer w)
        {
            manager = new ImageManager(n,bitmap,distanceType, probCrossOver, probMutation,pMutIndiv);
            destino = bitmap;
            tenpercent = (int) (generations * 0.1);
            this.generations = generations;
            window = w;
        }

        public GenAlgorithm(int n, Bitmap bitmap, int distanceType, int probCrossOver, int probMutation, int generations, int pMutIndiv, int pSelection, ImageViewer w, int histOption)
        {
            manager = new ImageManager(n, bitmap, distanceType, probCrossOver, probMutation, pMutIndiv, pSelection, histOption);
            destino = bitmap;
            tenpercent = (int)(generations * 0.1);
            this.generations = generations;
            window = w;
        }

        public void Run()
        {
            int counter = 0;
            for(int i = 0; i < generations; i++)
            {
                Console.WriteLine("GEN:" + (i+1));
                manager.Evaluate();
                manager.CrossOver(); //implementar mutacion en el nacimiento.... 
                manager.Mutate();
                window.UpdatePicture();
                if ((generations == 0) || (counter == tenpercent) || (i == generations - 1))
                {
                    lock (locker)
                    {
                        int imgIndex = manager.updateTopTen();
                        counter = 0;
                    }
                }
                counter++;
            }
        }


    }
}
