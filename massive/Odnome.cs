using System;
using System.Collections.Generic;
using System.Text;

namespace massive
{
    public class Odnome
    {
        Random rnd = new Random();

        public Odnome(bool flag, int len)
        {
            if (flag)
            {
                UserFill(len);
            }
            else
            {
                RndFill(len);
            }
        }


        private void RndFill(int len)
        {
            int[] array = new int[len];
            int sum = 0;

            for (int i = 0; i < len; i++)
            {
                int y = rnd.Next(-1000, 1000);
                array[i] = y;
                sum += y;

            }

            Console.WriteLine("Ответ на задачу первую одномерных");
            Console.WriteLine(sum / len);
            cecond(array);
            trird(array);

        }


        private void UserFill(int len)
        {

            int[] array = new int[len];
            int sum = 0;

            for (int i = 0; i < len; i++)
            {
                Console.WriteLine("Введите элемент");
                int l = int.Parse(Console.ReadLine());
                array[i] = l;
                sum += l;
            }

            Console.WriteLine("Ответ на первую задачу одномерных");
            Console.WriteLine(sum / len);
            cecond(array);
            trird(array);
        }


        static void cecond(int[] array1)
        {
            int kol = 0;
            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] < 100 && array1[i] > -100)
                {
                    kol++;
                }
            }
            int[] final = new int[kol];
            if (kol == 0)
            {
                Console.WriteLine("Ответ на вторую задачу одномерных");
                Console.WriteLine("Массив пустой");
            }
            else
            {
                for (int j = 0; j < array1.Length; j++)
                {
                    if (array1[j] < 100 || array1[j] > -100)
                    {
                        final[j] = array1[j];
                    }

                }
                Console.WriteLine("Ответ на вторую задачу одномерных");
                for (int g = 0; g < array1.Length; g++)
                {
                    Console.WriteLine(final[g]);
                }
            }
        }




        static void trird(int[] array2)
        {
            int fl = 0;
            int kol = 0;
            int[] arrayel = new int[array2.Length];
            for (int i = 0; i < array2.Length; i++)
            {
                for (int j = 0; j < array2.Length; j++)
                {
                    if (array2[i] == arrayel[j])
                    {
                        fl++;
                    }
                }
                if (fl < 1)
                {
                    arrayel[kol] = array2[i];
                    kol++;
                }
                fl = 0;
            }
            int[] final = new int[kol];
            for (int u = 0; u < kol; u++)
            {
                final[u] = arrayel[u];
            }
            Console.WriteLine("Ответ на третью задачу одномерных");
            for (int h = 0; h < kol; h++)
            {
                Console.WriteLine(final[h]);
            }
        }









    }
}

