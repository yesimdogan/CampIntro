using System;

namespace Maths
{
    class Program
    {
        static void Main(string[] args)
        {
            DortIslem dortIslem = new DortIslem();
            dortIslem.Topla(6, 5);
            dortIslem.Topla(8, 5);
            dortIslem.Topla(3, 6);

            Console.WriteLine("******");

            DortIslem dortIslem1 = new DortIslem();
            dortIslem1.Carpma(8, 12);
            dortIslem1.Carpma(2, 7);
            dortIslem1.Carpma(15, 3);
            dortIslem1.Carpma(9, 7);

            Console.WriteLine("******");

            DortIslem dortIslem2 = new DortIslem();
            dortIslem1.Cıkarma(8, 12);
            dortIslem1.Cıkarma(2, 7);
            dortIslem1.Cıkarma(15, 3);
            dortIslem1.Cıkarma(9, 7);

            Console.WriteLine("******");

            DortIslem dortIslem3 = new DortIslem();
            dortIslem1.Bolme(8, 12);
            dortIslem1.Bolme(2, 7);
            dortIslem1.Bolme(15, 3);
            dortIslem1.Bolme(9, 7);


            Console.ReadKey();

        }
    }
}
