using System;

namespace Döngüler
{
    class Program
    {
        static void Main(string[] args)
        {
            //string kurs1 = "Yazılım Geliştirme Kampı";
            //string kurs2 = "Temel Kurs";
            //string kurs3 = "Java";

            // array - dizi

            string[] kurslar = new string[] {"Yazılım Geliştirme Kampı1", "Temel Kurs", "Java", "Pyhton"};

            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            foreach (var kurs in kurslar)
            {

            }

            Console.WriteLine("sayfa sonu");
        }
    }
}
