using System;
using System.Collections.Generic;
using System.Text;

namespace Oop3
{
    class BasvuruManager
    {
        //tek kredi için çalışır
        //Method Injection - Dependency Inejection
        public void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggerServices)
        {
            //basvuran bilgiler

            krediManager.Hesapla();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }

        }

        //birden fazla kredi için çalışır
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        
        }
    }
}
