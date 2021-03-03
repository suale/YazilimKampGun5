using System;
using System.Collections.Generic;
using System.Text;

namespace Oop3
{
    //Dependency Injection

    class BasvuruManager
    {

        // Method Injection
        public void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggerServices)
        {
            //Başvuru yapan bilgileri değerlendirilir vs.

            krediManager.Hesapla();
            foreach (ILoggerService loggerService in loggerServices)
            {
                loggerService.log();
            }

        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (IKrediManager kredi in krediler)
            {
                kredi.Hesapla();
            }
        }

    }
}
