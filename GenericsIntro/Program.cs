using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            MyList<string> fruits = new MyList<string>();
            fruits.Add("çilek");
            fruits.Add("elma");
            fruits.Add("portakal");

            
        }
    }
}
