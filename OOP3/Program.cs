using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            // interface ile kullanımı
            //interface onu tutan class implementi yerine kullanılabilir.
            //IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            //ihtiyacKrediManager.Hesapla();
            //// Class ile kullanımı
            //TasitKrediManager tasitKrediManager = new TasitKrediManager();
            //tasitKrediManager.Hesapla();

            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            //basvuruManager.BasvuruYap(tasitKrediManager);  // () içine kredilerden birini gönderbilirsin.
            //basvuruManager.BasvuruYap(konutKrediManager, new DatabaseLoggerService());
                                                        // new ile tanımlamayı burada da yapabiliriz.
            basvuruManager.BasvuruYap(konutKrediManager, fileLoggerService);

            List<IKrediManager> krediler = new List<IKrediManager> {ihtiyacKrediManager, tasitKrediManager };
            // { } içine eklenecek kredileri hesaplama yapmasını sağlarız.
            basvuruManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
