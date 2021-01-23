using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    // TasitKrediHesapla KrediManager a Inherit edildiği için KrediManager da ki Hesaplaya sahip oluyor.
    class TasitKrediManager : IKrediManager        //IKrediManager Kırmızı olursa lambadan implement tıklanmalı.
    {
        public void BirSeyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            Console.WriteLine("Taşıt Kredisi Ödeme Planı Hesaplandı.");
        }
    }
}
