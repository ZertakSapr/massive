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
            Console.WriteLine("Выберите перезаполнять самостоятельно или рандомно одномерные массивы(True или False)");
            bool fl1 = bool.Parse(Console.ReadLine());
            Console.WriteLine("Введите новое кол-во элементов");
            int kol1 = int.Parse(Console.ReadLine());
            odnom.recreate(fl1, kol1);
            odnom.cecond();
            odnom.trird();

            Console.WriteLine("Выберите заполнять самостоятельно или рандомно двумерные массивы(True или False)");
            bool fld = bool.Parse(Console.ReadLine());
            Console.WriteLine("Введите кол-во строк для двумерных");
            int kolstr = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите кол-во столбцов для двумерных");
            int kolstlb = int.Parse(Console.ReadLine());
            Dvumer clas = new Dvumer(fld, kolstr, kolstlb);
            Console.WriteLine("Выберите перезаполнять самостоятельно или рандомно двумерные массивы(True или False)");
            bool fld1 = bool.Parse(Console.ReadLine());
            Console.WriteLine("Введите новое кол-во строк для двумерных");
            int kolstr1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите новое кол-во столбцов для двумерных");
            int kolstlb1 = int.Parse(Console.ReadLine());
            clas.recreate(fld1, kolstr1, kolstlb1);
            clas.first();

            Console.WriteLine("Выберите заполнять самостоятельно или рандомно трехмерные массивы(True или False)");
            bool fls = bool.Parse(Console.ReadLine());
            Console.WriteLine("Введите кол-во строк для трехмерных");
            int kolstrs = int.Parse(Console.ReadLine());
            Stupen st = new Stupen(fls, kolstrs);
            Console.WriteLine("Выберите перезаполнять самостоятельно или рандомно трехмерные массивы(True или False)");
            bool fls1 = bool.Parse(Console.ReadLine());
            Console.WriteLine("Введите новое кол-во строк для трехмерных");
            int kolstrs1 = int.Parse(Console.ReadLine());
            st.recreate(fls1, kolstrs1);
            st.first();
            st.second();
        }
    }


}    

