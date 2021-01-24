using OOP2;
using System;

namespace OOB2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Dorukhan Cosgun

            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Dorukhan";
            musteri1.Soyadi = "Cosgun";
            musteri1.TcNo = "1234567890";

            //Kodlama.io
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "5432";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "76556765";


            //Gercek Musteri - Tüzel Musteri (Inheritance yapicaz)
            //SOLID

            Musteri musteri3 = new GercekMusteri(); //'new' varsa referans no'sudur. UNUTMA.
            Musteri musteri4 = new TuzelMusteri();
            //Musteri classi burda iki tarz musteriyi de tutabiliyor.

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);


        }
    }
}
