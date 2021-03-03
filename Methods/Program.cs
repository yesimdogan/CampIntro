using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product urun1 = new Product();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";
            urun1.StokAdedi = 200;

            Product urun2 = new Product();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 30;
            urun2.Aciklama = "Diyarbakır Karpuzu";
            urun2.StokAdedi = 100;

            Product[] urunler = new Product[] { urun1, urun2 };

            foreach (Product urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine(urun.StokAdedi);

            }

            Console.WriteLine("--------METOTLAR------");

            SepetManager sepet = new SepetManager();
            sepet.Ekle(urun1);
            sepet.Ekle(urun2);

        }
    }
}
