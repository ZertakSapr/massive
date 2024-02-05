using System;
using System.Collections.Generic;
using System.Text;

namespace massive
{
    class TwoDimensions
    {
        private Random _rnd;

        private int[,] array;

        public TwoDimensions(bool flag, int rowCount, int columnCount, Random rnd)
        {
            _rnd = rnd;
            InitializationType(flag, rowCount, columnCount);
        }


        private void RndFill()
        {
            int sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    int y = _rnd.Next(-1000, 1000);
                    array[i, j] = y;
                    sum += y;
                }
            }

            Console.WriteLine("Ответ на задачу первую  двумерных");

            Console.WriteLine(sum / (array.GetLength(0) * array.GetLength(1)));
        }


        private void UserFill()
        {
            int sum = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.WriteLine("Введите элемент");

                    int l = int.Parse(Console.ReadLine());

                    array[i, j] = l;

                    sum += l;

                }
            }
            Console.WriteLine("Ответ на первую задачу двумерных");

            Console.WriteLine(sum / (array.GetLength(0) * array.GetLength(1)));
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

    }
}
