using System;
using System.Collections.Generic;
using System.Text;

namespace Oop3
{
    //Interfaceleri birbirlerinin alternatifi olan ancak kod içerikleri farklı olan durumlar için kullanırız.

    interface IKrediManager //interface: eğer bu interface kullanılırsa içerisindeki metotlar kullanılmak zorundadır.
    {
        public void Hesapla();

        public void BiseyYap();
    }
}
