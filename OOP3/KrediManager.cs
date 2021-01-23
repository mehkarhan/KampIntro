using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //interface Şablon görevi görmüş oluyor. Eğer birisi bu interface i kullanırsa içindeki metotları kullanmak
    //zorunludur. 
    interface IKrediManager // Okunurluğu artırmak için I harfi ile başlar.
    {
        void Hesapla();
        void BirSeyYap();
    }
}
