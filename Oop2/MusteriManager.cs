using System;
using System.Collections.Generic;
using System.Text;

namespace Oop2
{
    //İş Sınıfları--Business Classes

    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("{0} nolu müşteri eklendi.",musteri.MusteriNo);
        }
    }
}
