using System;
using System.Collections.Generic;


namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            
            List<string> fruits = new List<string>();
            fruits.Add("elma");
            fruits.Add("muz");
            fruits.Add("çilek");
            fruits.Add("portakal");
            Console.WriteLine(fruits[2]);
            Console.WriteLine(fruits[3]);

            Console.ReadLine();


        }
    }
}
