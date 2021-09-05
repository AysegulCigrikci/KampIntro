using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "kategori";
            int sayi = 25000;
            double doubleSayi = 1.45;
            bool sistemeGirisYapildimiMi = false;
            double dolarDun = 7.55;
            double dolarBugun = 7.55;

            if (dolarDun> dolarBugun)
            {
                Console.WriteLine("azalmış");
            }
            else if(dolarDun<dolarBugun)
            {
                Console.WriteLine("artış");
            }
            else
            {
                Console.WriteLine("Değişmedi");
            }


            if (sistemeGirisYapildimiMi == true)
            {
                Console.WriteLine("başarılı");
            }
            else
            {
                Console.WriteLine("başarısız");
            }

            Console.WriteLine(kategoriEtiketi);

        }
    }
}
