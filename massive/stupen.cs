using System;
using System.Collections.Generic;
using System.Text;

namespace massive
{
    class Stupen
    {
        Random rnd = new Random();
        int[][] array;
        public Stupen(bool flag, int len)
        {
            array = new int[len][];
            choice(flag, len);
        }
        public void recreate(bool flag, int len)
        {
            array = new int[len][];
            choice(flag, len);
        }
        
        private void RndFill(int len)
        {
           
            int sum = 0;
            int kol = 0;
            for (int i = 0; i < len; i++)
            {
                Console.WriteLine("Напишите кол во элементов  строке трехмерных");
                int lengthstroki = int.Parse(Console.ReadLine());
                array[i] = new int[lengthstroki];
                for(int j=0; j<lengthstroki; j++)
                {
                    int y = rnd.Next(-1000, 1000);
                    array[i][j] = y;
                    sum += y;
                    kol += 1;
                }
                

            }

            Console.WriteLine("Ответ на задачу первую трехмерных");
            Console.WriteLine(sum / kol);
            
        }


        private void UserFill(int len)
        {

            
            int sum = 0;
            int kol = 0;
            for (int i = 0; i < len; i++)
            {
                Console.WriteLine("Напишите кол во элементов  строке трехмерных");
                int lengthstroki = int.Parse(Console.ReadLine());
                array[i] = new int[lengthstroki];
                for (int j = 0; j < lengthstroki; j++)
                {
                    Console.WriteLine("Введите элемент");
                    int l = int.Parse(Console.ReadLine());
                    array[i][j] = l;
                    sum += l;
                    kol += 1;
                }
            }

            Console.WriteLine("Ответ на первую задачу трехмерных");
            Console.WriteLine(sum / kol);

        }
        public void first()
        {
            for(int i=0; i<array.Length; i++)
            {
                int sum = 0;
                
                for(int j=0; j<array[i].Length; j++)
                {
                    sum += array[i][j];
                }
                Console.WriteLine("Среднее значение " + i + " вложеннлого массива = "+ sum/array[i].Length);
            }
        }
        public void second()
        {
            int pro = 1;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    if (array[i][j] % 2 == 0)
                    {
                        pro = pro * j;
                    }
                }
 
            }
            Console.WriteLine("Измененная матрица для третьего задания");
            for (int i = 0; i < array.Length; i++)
            {
                string final = "";
                for (int j = 0; j < array[i].Length; j++)
                {
                    if (array[i][j] % 2 == 0)
                    {
                        array[i][j]=pro;
                    }
                    final += array[i][j] + " ";
                }
                Console.WriteLine(final);

            }

        }
        private void choice(bool choice, int kolstr)
        {
            if (choice)
            {
                UserFill(kolstr);
            }
            else
            {
                RndFill(kolstr);
            }
        }
    }
}
