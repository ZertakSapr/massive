using System;

namespace massive
{
    class Program
    {
        static void Main(string[] args)
        {
            OneDim();
            TwoDim();
            StepDim();
        }
        private static void OneDim()
        {
            Console.WriteLine("Выберите заполнять самостоятельно или рандомно одномерные массивы(True или False)");
            bool fl = bool.Parse(Console.ReadLine());
            Console.WriteLine("Введите кол-во элементов");
            int kol = int.Parse(Console.ReadLine());
            OneDimensions one = new OneDimensions(fl, kol);
            //Переосоздание
            Console.WriteLine("Выберите перезаполнять самостоятельно или рандомно одномерные массивы(True или False)");
            bool fl1 = bool.Parse(Console.ReadLine());
            Console.WriteLine("Введите новое кол-во элементов");
            int kol1 = int.Parse(Console.ReadLine());
            one.PrintOne();
            one.AvarageOne();
            one.Recreate(fl1, kol1);
            one.Massiveunder100();
            one.NotRepeatMassive();
        }

        private static void TwoDim()
        {
            Console.WriteLine("Выберите заполнять самостоятельно или рандомно двумерные массивы(True или False)");
            bool fld = bool.Parse(Console.ReadLine());
            Console.WriteLine("Введите кол-во строк для двумерных");
            int rowCount = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите кол-во столбцов для двумерных");
            int columnCount = int.Parse(Console.ReadLine());
            TwoDimensions twodim = new TwoDimensions(fld, rowCount, columnCount);
            //Пересоздание
            Console.WriteLine("Выберите перезаполнять самостоятельно или рандомно двумерные массивы(True или False)");
            bool fld1 = bool.Parse(Console.ReadLine());
            Console.WriteLine("Введите новое кол-во строк для двумерных");
            int rowCount1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите новое кол-во столбцов для двумерных");
            int columnCount1 = int.Parse(Console.ReadLine());
            twodim.AvarageTwo();
            twodim.PrintTwo();
            twodim.Recreate(fld1, rowCount1, columnCount1);
            twodim.Matrices();
        }
        static private void StepDim()
        {
            Console.WriteLine("Выберите заполнять самостоятельно или рандомно трехмерные массивы(True или False)");
            bool fls = bool.Parse(Console.ReadLine());
            Console.WriteLine("Введите кол-во строк для трехмерных");
            int rowCounts = int.Parse(Console.ReadLine());
            StepDimensional st = new StepDimensional(fls, rowCounts);
            //Пересоздание
            Console.WriteLine("Выберите перезаполнять самостоятельно или рандомно трехмерные массивы(True или False)");
            bool fls1 = bool.Parse(Console.ReadLine());
            Console.WriteLine("Введите новое кол-во строк для трехмерных");
            int rowCounts1 = int.Parse(Console.ReadLine());

            st.AvarageStep();
            st.PrintStep();
            st.Recreate(fls1, rowCounts1);
            st.Avarage();
            st.Matrice();
        }

    }
     

}   

