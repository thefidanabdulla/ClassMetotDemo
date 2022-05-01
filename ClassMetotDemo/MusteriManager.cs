using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void MusteriListele(Musteri[] musteriParams)
        {
            foreach (var musteri in musteriParams)
            {
                Console.WriteLine(musteri.Id + ". " +musteri.Ad + " " + musteri.Soyad);
            }
        }
    }
}
