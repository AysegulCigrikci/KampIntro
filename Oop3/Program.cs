
using System;

namespace Oop3
{
    class Program
    {
        static void Main(string[] args)
        {
            IhtıyacKrediManager ihtıyacKrediManager = new IhtıyacKrediManager();
            TasitKrediManager tasitKrediManager = new TasitKrediManager();
            KonutKrediManager konutKrediManager = new KonutKrediManager();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(ihtıyacKrediManager);

        }
    }
}
