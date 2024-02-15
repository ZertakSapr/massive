using System;
using System.Collections.Generic;
using System.Text;

namespace massive
{
    class StepDimensional
    {
        private static Random rnd = new Random();

        private int[][] array;

        public StepDimensional(bool flag, int len)
        {

            InitializationalType(flag, len);
        }

        public void Recreate(bool flag, int len)
        {
            InitializationalType(flag, len);
        }

        private void RndFill()
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Напишите кол во элементов  строке трехмерных");
                int lengthstroki = int.Parse(Console.ReadLine());
                array[i] = new int[lengthstroki];
                for (int j = 0; j < array[i].Length; j++)
                {
                    int y = rnd.Next(-1000, 1000);
                    array[i][j] = y;

                }
            }
        }


        private void UserFill()
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Напишите кол во элементов  строке трехмерных");
                int innerArrayLength = int.Parse(Console.ReadLine());
                array[i] = new int[innerArrayLength];
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.WriteLine("Введите элемент");
                    int l = int.Parse(Console.ReadLine());
                    array[i][j] = l;

                }
            }
        }

        public void Avarage()
        {
            for (int i = 0; i < array.Length; i++)
            {
                int sum = 0;
                for (int j = 0; j < array[i].Length; j++)
                {
                    sum += array[i][j];
                }
                Console.WriteLine("Среднее значение " + i + " вложенного массива = " + sum / array[i].Length);
            }
        }

        public void Matrice()
        {
            Console.WriteLine("Измененная матрица для третьего задания");
            for (int i = 0; i < array.Length; i++)
            {
                string final = "";
                for (int j = 0; j < array[i].Length; j++)
                {
                    if (array[i][j] % 2 == 0)
                    {
                        array[i][j] = i * j;
                    }
                    final += array[i][j] + " ";
                }
                Console.WriteLine(final);
            }
        }

        private void InitializationalType(bool choice, int rowCount)
        {
            array = new int[rowCount][];
            if (choice)
            {
                UserFill();
            }
            else
            {
                RndFill();
            }
        }

        public void PrintStep()
        {
            Console.WriteLine("Вывод массива");
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.WriteLine(array[i][j]);
                }
                    
            }
        }

        public void AvarageStep()
        {
            int sum = 0;
            int count = 0;
            Console.WriteLine("Вывод массива");
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    sum+=array[i][j];
                    count += 1;
                }
                Console.WriteLine(sum / count);
            }
        }
    }
}
