using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ödev
{
    class Araba
    {
        public Marka Marka { get; set; }
        public string Model { get; set; }
        public Kapi Kapı { get; set; }
        public Pencere Pencere { get; set; }
        public Kasa Kasa { get; set; }
        public decimal Fiyat { get; set; }

        public Araba(Marka marka, string model, Kapi kapı, Pencere pencere, Kasa kasa, decimal fiyat)
        {
            Marka = marka;
            Model = model;
            Kapı = kapı;
            Pencere = pencere;
            Kasa = kasa;
            Fiyat = fiyat;
        }

        public void ArabaBilgileriniYazdir()
        {
            Console.WriteLine($"Arabanın markası {Marka.MarkaAdı}, modeli {Model}, kapı sayısı {Kapı.KapıSayısı}, pencere sayısı {Pencere.PencereSayısı}, kasası {Kasa.KasaTipi}, fiyatı {Fiyat} TL’dir.");
        }
    }
}
