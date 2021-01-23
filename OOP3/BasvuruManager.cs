using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {
        // () içine IKrediManager eklersek oraya butun kredilerinin hesaplamasını yaptırmış oluruz.
        // o yuzden () içindeki krediManager ile hesapla çağrılır.
        public void BasvuruYap(IKrediManager krediManager, ILoggerService loggerService)
        {
            //Başvuru bilgilerini değerlendirme kısmı
            //KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();
            // KonutKrediManager dersek eğer bütün kredi basvurularını konut kredisi olarak hesaplarız.
            //Kullanımı doğru olmaz.
            // Method injection yaptık.
            krediManager.Hesapla();
            loggerService.Log();  
        }
        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {// birden fazla kredi hesabını yapmak istiyorum dediğimizde () içine List ile ve butun kredileri içeren
            // IKrediManager interfaceni kullanırız.
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}       // birbirinin alternatifleri olan kod içerik farklı olanlar 
