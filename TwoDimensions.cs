using System;
using System.Collections.Generic;
using System.Text;

namespace massive
{
    class TwoDimensions
    {
        private static Random rnd = new Random();

        private int[,] array;

        public TwoDimensions(bool flag, int rowCount, int columnCount)
        {
            InitializationType(flag, rowCount, columnCount);
        }


        private void RndFill()
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    int y = rnd.Next(-1000, 1000);
                    array[i, j] = y;
                }
            }
        }


        private void UserFill()
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.WriteLine("Введите элемент");

                    int l = int.Parse(Console.ReadLine());

                    array[i, j] = l;


                }
            }
        }

        public void Recreate(bool flag, int rowCount, int columnCount)
        {
            InitializationType(flag, rowCount, columnCount);
        }

        public void Matrices()
        {
            Console.WriteLine("Обычная матрица");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                string final = "";

                for (int j = 0; j < array.GetLength(1); j++)
                {
                    final += array[i, j] + " ";
                }

                Console.WriteLine(final);
            }
            Console.WriteLine("Матрица c изменениями");

            for (int i = 0; i < array.GetLength(0); i++)
            {
                string final = "";
                if (i % 2 == 1)
                {
                    for (int j = array.GetLength(1) - 1; j >= 0; j--)
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

        private void InitializationType(bool flag, int rowCount, int columnCount)
        {
            array = new int[rowCount, columnCount];
            if (flag)
            {
                UserFill();
            }
            else
            {
                RndFill();
            }
        }

        public void PrintTwo()
        {
            Console.WriteLine("Вывод массива");
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for(int j=0; j<array.GetLength(1); j++)
                {
                    Console.WriteLine(array[i,j]);
                }
            }     
        }

        public void AvarageTwo()
        {
            int sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    sum += array[i, j];
                }
            }
            Console.WriteLine("Среднее значение двумерных");
            Console.WriteLine(sum / array.Length);
        }

    }
}
