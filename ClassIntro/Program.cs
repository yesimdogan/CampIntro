using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.Egitmen = "Engin Demiroğ";
            kurs1.KursAdi = "C#";
            kurs1.IzlenmeOrani = 80;


            Kurs kurs2 = new Kurs();
            kurs2.Egitmen = "Berkay Bilgin";
            kurs2.KursAdi = "Python";
            kurs2.IzlenmeOrani = 70;

            Kurs kurs3 = new Kurs();
            kurs3.Egitmen = "Kerem Varış";
            kurs3.KursAdi = "Java";
            kurs3.IzlenmeOrani = 70;

            Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen + ":" + kurs1.IzlenmeOrani);
            Console.WriteLine("*********");
            Console.WriteLine(kurs2.KursAdi + ":" + kurs2.Egitmen + ":" + kurs2.IzlenmeOrani);
            Console.WriteLine("*********");
            Console.WriteLine(kurs3.KursAdi + ":" + kurs3.Egitmen + ":" + kurs3.IzlenmeOrani);

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi);
            }

            //Ürünlerinizi for, foreach ve while döngüleri ile ayrı ayrı listeleyiniz. 

            Products urun1 = new Products();
            urun1.productName = "Pants";
            urun1.productPrice = 80;

            Products urun2 = new Products();
            urun2.productName = "Dress";
            urun2.productPrice = 65;

            Products urun3 = new Products();
            urun3.productName = "Jacket";
            urun3.productPrice = 125;

            Products[] uruns = new Products[] { urun1, urun2, urun3 };

            for (int i = 0; i < uruns.Length; i++)
            {
                Console.WriteLine(uruns[i].productName + ":" + uruns[i].productPrice + "$");
            }

            Console.WriteLine("********");

            foreach (var products in uruns)
            {
                Console.WriteLine(products.productName + ":" + products.productPrice + "$");
            }

            Console.WriteLine("********");

            int x = 0;
            while (x < uruns.Length)
            {
                Console.WriteLine(uruns[x].productName + ":" + uruns[x].productPrice + "$");
                x++;
            }

            Console.WriteLine("********");



            Console.ReadKey();

        }

        class Products
        {
            public string productName { get; set; }
            public int productPrice { get; set; }
        }

        class Kurs
        {
            public string KursAdi { get; set; }
            public string Egitmen { get; set; }
            public int IzlenmeOrani { get; set; }
        }
    }
}