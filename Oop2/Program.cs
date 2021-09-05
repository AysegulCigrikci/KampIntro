using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id =1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "aysegul";
            musteri1.Soyadi = "cig";
            musteri1.TcNo = "14785296374";

            TuzelMusteri tuzelMusteri = new TuzelMusteri();
            tuzelMusteri.Id = 2;
            tuzelMusteri.MusteriNo = "14785";
            tuzelMusteri.SirketAdi = "dumansirket";


            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(tuzelMusteri);


            //gerçek - tüzel
            //SOLID

        }
    }
}
