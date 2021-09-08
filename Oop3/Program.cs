
using System;
using System.Collections.Generic;

namespace Oop3
{
    class Program
    {
        //intarface = birbirinin alternatifi olan ama kod içerikleri farklı olan durumlar için kullanırız.
        //hepsinde hesaplama var krediler farklı
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService> { new SmsLoggerService(), new FileLoggerService() };


            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(new EsnafKrediManager(), loggers);

            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager, tasitKrediManager};
            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);

        }
    }
}
