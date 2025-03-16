// See https://aka.ms/new-console-template for more information
using ödev;
class Program
{
    static void Main(string[] args)
    {
        // BMW X5 modelini Composition kullanarak oluşturma
        Marka bmw = new Marka("BMW");
        Kapi kapı = new Kapi(4);
        Pencere pencere = new Pencere(4);
        Kasa kasa = new Kasa("sedan");
        decimal fiyat = 2000000m;

        Araba bmwX5 = new Araba(bmw, "X5", kapı, pencere, kasa, fiyat);

        // Araba bilgilerini yazdırma
        bmwX5.ArabaBilgileriniYazdir();
    }
}