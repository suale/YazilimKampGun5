using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Samed MUSABAŞOĞLU
            GercekMusteri musteri1 = new GercekMusteri();

            musteri1.MusteriNo = "83454";
            musteri1.Adi = "Samed";
            musteri1.SoyAdi = "MUSABAŞOĞLU";
            musteri1.TcNo = "34758932834";
            musteri1.Id = 1;

            TuzelMusteri musteri2 = new TuzelMusteri();

            musteri2.Id = 2;
            musteri2.MusteriNo = "32435";
            musteri2.SirketAdi = "SamedCo";
            musteri2.VergiNo = "32748393423";

            Musteri musteri3 = new GercekMusteri();
            //Ata sınıf her iki tipi de tutabiliyor.
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri3);
            musteriManager.Ekle(musteri4);


        }
    }
}
