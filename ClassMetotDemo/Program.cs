using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Ad = "John";
            musteri1.Soyad = "Doe";

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Ad = "Jane";
            musteri2.Soyad = "Doe";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };
            MusteriManager musteriManager = new MusteriManager();

            musteriManager.MusteriListele(musteriler);
        }
    }
}
