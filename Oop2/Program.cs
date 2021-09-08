using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            GercekMusteri gercekMusteri = new GercekMusteri();
            gercekMusteri.Id = 1;
            gercekMusteri.MusteriNo = "12345";
            gercekMusteri.Adi = "aysegul";
            gercekMusteri.Soyadi = "cig";
            gercekMusteri.TcNo = "14785296374";

            TuzelMusteri tuzelMusteri = new TuzelMusteri();
            tuzelMusteri.Id = 2;
            tuzelMusteri.MusteriNo = "14785";
            tuzelMusteri.SirketAdi = "dumansirket";
            tuzelMusteri.VergiNo = "1234845654";

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(gercekMusteri);
            musteriManager.Ekle(tuzelMusteri);

            //gerçek - tüzel
            //SOLID

        }
    }
}
