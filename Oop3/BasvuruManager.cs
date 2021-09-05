using System;
using System.Collections.Generic;
using System.Text;

namespace Oop3
{
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager)
        {
            //basvuran bilgiler

            krediManager.Hesapla();

        }
    }
}
