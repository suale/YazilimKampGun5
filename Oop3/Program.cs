using System;
using System.Collections.Generic;

namespace Oop3
{
    class Program
    {
        static void Main(string[] args)
        {
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();

            IKrediManager tasitKrediManager = new TasitKrediManager();

            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService fileLoggerService = new FileLoggerService();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();


            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(konutKrediManager, new List<ILoggerService> {databaseLoggerService, fileLoggerService });
            basvuruManager.BasvuruYap(tasitKrediManager, new List<ILoggerService> {new SmsLoggerService(), fileLoggerService });


            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager, konutKrediManager, tasitKrediManager };

            //basvuruManager.KrediOnBilgilendirmesiYap(krediler);


            //interface kendisini implement eden classın referansını tutabilir.



            //ihtiyacKrediManager.Hesapla();
            //tasitKrediManager.Hesapla();
            //konutKrediManager.Hesapla();

        }
    }
}
