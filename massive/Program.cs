using System;

namespace massive
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите заполнять самостоятельно или рандомно одномерные массивы(True или False)");
            bool fl = bool.Parse(Console.ReadLine());
            Console.WriteLine("Введите кол-во элементов");
            int kol = int.Parse(Console.ReadLine());
            Odnome odnom = new Odnome(fl, kol);
            Console.WriteLine("Выберите заполнять самостоятельно или рандомно двумерные массивы(True или False)");
            bool fld = bool.Parse(Console.ReadLine());
            Console.WriteLine("Введите кол-во строк для двумерных");
            int kolstr = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите кол-во столбцов для двумерных");
            int kolstlb = int.Parse(Console.ReadLine());
            Dvumer clas = new Dvumer(fld, kolstr, kolstlb);
            Console.WriteLine("Выберите заполнять самостоятельно или рандомно трехмерные массивы(True или False)");
            bool fls = bool.Parse(Console.ReadLine());
            Console.WriteLine("Введите кол-во строк для трехмерных");
            int kolstrs = int.Parse(Console.ReadLine());
            Stupen st = new Stupen(fls, kolstrs);
        }
    }


}    

