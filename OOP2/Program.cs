using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Mehmet KARAHAN - Gerçek Müşteri
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Mehmet";
            musteri1.Soyadi = "KARAHAN";
            musteri1.TcNo = "1225544556";

            // Karahan.io - Tüzel Müşteri
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "54321";
            musteri2.SirketAdi = "Karahan.io";
            musteri2.VergiNo = "1234567890";

            //SOLID
            // bir yerde new görüyorsak bellekte referans no tutar. Aşağıda
            Musteri musteri3 = new GercekMusteri();     //
            Musteri musteri4 = new TuzelMusteri();      //

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
            musteriManager.Ekle(musteri4);


        }
    }
}
