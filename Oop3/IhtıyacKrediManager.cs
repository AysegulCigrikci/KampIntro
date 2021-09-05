using System;
using System.Collections.Generic;
using System.Text;

namespace Oop3
{
    class IhtıyacKrediManager : IKrediManager
    {
        public void BirseyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("Ihtiyac kredisi hesaplandı");

        }
    }
}
