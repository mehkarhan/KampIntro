using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //string kategoriEtiketi = "Kategori";
            //int ogrenciSayisi = 32000;
            //double faizOrani = 1.75;
            bool sistemeGirisYapmismi = true;
            double dolarDun = 7.45;
            double dolarBugun = 7.35;
            if (dolarBugun>dolarDun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else if (dolarBugun<dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else
            {
                Console.WriteLine("Değişmeyen Butonu");
            }


            if (sistemeGirisYapmismi==true)
            {
                Console.WriteLine("Kullanıcı Ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }
            
        }
    }
}
