using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Ayşegül";
            kurs1.IzlenmeOrani = 100;

            Kurs kurs2 = new Kurs();
            kurs1.KursAdi = "Java";
            kurs1.Egitmen = "Busra";
            kurs1.IzlenmeOrani = 100;

            //Console.WriteLine("Hello World!" + kurs1.KursAdi);

            Kurs[] kurslar = new Kurs[] { kurs1, kurs2};

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi);
            }
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }

    }
}
