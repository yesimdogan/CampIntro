using System;

namespace CampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstDay = 7.35;
            double today = 7.50;

            if (firstDay > today)
            {
                Console.Write("Dolar Kuru:" + firstDay);
            }
            else if (today > firstDay)
            {
                Console.Write("Dolar Kuru:" + today);
            }
            else
            {
                Console.Write("Kurlar Eşit");
            }
            Console.ReadKey();
        }
    }
}
