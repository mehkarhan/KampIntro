using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //individual - Gerçek Müşteri

    //Inheritance da Musteri de olan tüm özellikler GercekMusteri'de de var kabul ederiz.
    class GercekMusteri:Musteri     //Inheritance - Miras 
    {
        public string TcNo { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
    }
}
