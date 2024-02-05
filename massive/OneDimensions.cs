using System;
using System.Collections.Generic;
using System.Text;

namespace massive
{
    public class OneDimensions
    {
        private Random _rnd;

        private int[] array;

        public OneDimensions(bool flag, int len, Random rnd)
        {
            _rnd = rnd;
            InitializationType(flag, len);
        }


        public void Recreate(bool flag, int len)
        {
            InitializationType(flag, len);
        }

        private void RndFill()
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                int y = _rnd.Next(-1000, 1000);
                array[i] = y;
                sum += y;
            }
            Console.WriteLine("Ответ на задачу первую одномерных");

            Console.WriteLine(sum / array.Length);
        }


        private void UserFill()
        {
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Введите элемент");
                int l = int.Parse(Console.ReadLine());
                array[i] = l;
                sum += l;
            }

            Console.WriteLine("Ответ на первую задачу одномерных");

            Console.WriteLine(sum / array.Length);
        }


        public void Massiveunder100()
        {
            int count = 0;
            int y = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 100 & array[i] > -100)
                {
                    count++;
                }
            }
            int[] final = new int[count];
            if (count == 0)
            {
                Console.WriteLine("Ответ на вторую задачу одномерных");
                Console.WriteLine("Массив пустой");
            }
            else
            {
                for (int j = 0; j < final.Length; j++)
                {
                    if (array[j] < 100 & array[j] > -100)
                    {
                        final[y] = array[j];
                        y++;
                    }

                }
                Console.WriteLine("Ответ на вторую задачу одномерных");
                for (int g = 0; g < final.Length; g++)
                {
                    Console.WriteLine(final[g]);
                }
            }
        }

        public void NotRepeatMassive()
        {
            int fl = 0;
            int kol = 0;
            int[] arrayel = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[i] == arrayel[j])
                    {
                        fl++;
                    }
                }
                if (fl < 1)
                {
                    arrayel[kol] = array[i];
                    kol++;
                }
                fl = 0;
            }
            int[] final = new int[kol];
            for (int u = 0; u < final.Length; u++)
            {
                final[u] = arrayel[u];
            }
            Console.WriteLine("Ответ на третью задачу одномерных");
            for (int h = 0; h < final.Length; h++)
            {
                Console.WriteLine(final[h]);
            }
        }

        private void InitializationType(bool flag, int rowCount)
        {
            array = new int[rowCount];
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

