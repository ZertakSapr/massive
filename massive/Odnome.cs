using System;
using System.Collections.Generic;
using System.Text;

namespace massive
{
    public class Odnome
    {
        Random rnd = new Random();
        int[] array;
        public Odnome(bool flag, int len)
        {
            array = new int[len];
            if (flag)
            {
                UserFill(len);
            }
            else
            {
                RndFill(len);
            }
        }

        
        public void recreate(bool flag, int len)
        {
            array = new int[len];
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
            
            int sum = 0;

            for (int i = 0; i < len; i++)
            {
                int y = rnd.Next(-1000, 1000);
                array[i] = y;
                sum += y;

            }

            Console.WriteLine("Ответ на задачу первую одномерных");
            Console.WriteLine(sum / len);
            

        }


        private void UserFill(int len)
        {

            
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
            
        }


        public void cecond()
        {
            int kol = 0;
            int y = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 100 & array[i] > -100)
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
                for (int j = 0; j < kol; j++)
                {
                    if (array[j] < 100 & array[j] > -100)
                    {

                        final[y] = array[j];
                        y++;
                    }

                }
                Console.WriteLine("Ответ на вторую задачу одномерных");
                for (int g = 0; g < kol; g++)
                {
                    Console.WriteLine(final[g]);
                }
            }
        }




        public void trird()
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

