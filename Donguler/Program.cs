using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım geliştirici kursu";
            string kurs2 = "Programlamaya başlangıç";
            string kurs3 = "Java";

            //array-dizi
            string[] kurslar = new string[] { "Yazılım geliştirici kursu", "Programlamaya başlangıç", "Java" };
            

            for (int i = 0; i<kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For bitti");

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("sayfa sonu");
        }
    }
}
