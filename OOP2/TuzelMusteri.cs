using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //Co-orporate - Tüzel(Şirket) Müşteri
    class TuzelMusteri: Musteri         //Inheritance - Miras
    {
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }
    }
}
