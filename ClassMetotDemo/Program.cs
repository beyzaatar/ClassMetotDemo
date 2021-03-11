using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.MusteriAd = "Beyza";
            musteri1.MusteriSoyad = "ATAR";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.MusteriAd = "Aziz";
            musteri2.MusteriSoyad = "AVCI";

            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.MusteriAd = "Nurdan";
            musteri3.MusteriSoyad = "ATAR";

            Musteri[] musteriler = new Musteri[] {musteri1,musteri2,musteri3 };
            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Ekle(musteri1);

            Console.WriteLine("Müşteri Listesi");

            foreach (var musteri in musteriler)
            {
                musteriManager.Listeleme(musteri);
            }

            musteriManager.Silme(musteri3);
        }
    }

}
