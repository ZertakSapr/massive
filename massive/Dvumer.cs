﻿using System;
using System.Collections.Generic;
using System.Text;

namespace massive
{
    class Dvumer
    {
        Random rnd = new Random();
        int[,] array;

        public Dvumer(bool flag, int kolstr, int kolstlb)
        {
            array = new int[kolstr, kolstlb];
            choice(flag, kolstr, kolstlb);
        }
        

        private void RndFill(int kolstr, int kolstlb)
        {
            
            int sum = 0;

            for (int i = 0; i < kolstr; i++)
            {
                for(int j=0; j<kolstlb; j++)
                {
                    int y = rnd.Next(-1000, 1000);

                    array[i,j] = y;

                    sum += y;
                }

            }

            Console.WriteLine("Ответ на задачу первую  двумерных");

            Console.WriteLine(sum / (kolstlb*kolstr));
        }


        private void UserFill(int kolstr, int kolstlb)
        {

            

            int sum = 0;

            for (int i = 0; i < kolstr; i++)
            {
                for(int j=0; j< kolstlb; j++)
                {
                    Console.WriteLine("Введите элемент");

                    int l = int.Parse(Console.ReadLine());

                    array[i,j] = l;

                    sum += l;

                }
            }
            Console.WriteLine("Ответ на первую задачу двумерных");

            Console.WriteLine(sum / (kolstr*kolstlb));

            
        }
        public void recreate(bool flag, int kolstr, int kolstl)
        {
            
            array= new int[kolstr, kolstl];
            choice(flag, kolstr, kolstl);
        }
        public void first()
        {
            Console.WriteLine("Обычная матрица");

            for(int i =0; i<array.GetLength(0); i++)
            {
                string final = "";

                for(int j=0; j<array.GetLength(1); j++)
                {
                    final += array[i, j]+" ";
                }

                Console.WriteLine(final);
            }
            Console.WriteLine("Матрица c изменениями");

            for (int i = 0; i < array.GetLength(0); i++)
            {
                string final = "";
                if (i % 2 == 1)
                {
                    for (int j = array.GetLength(1)-1; j >=0; j--)
                    {
                        final += array[i, j] + " ";
                    }
                    
                }
                else
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        final += array[i, j] + " ";
                    }
                    
                }
                
                Console.WriteLine(final);
            }
        }
        private void choice(bool choice, int kolstr,int kolstl)
        {
            if (choice)
            {
                UserFill(kolstr, kolstl);
            }
            else
            {
                RndFill(kolstr, kolstl);
            }
        }

    }
}