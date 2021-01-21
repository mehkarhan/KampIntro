using System;

namespace eticaret
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.UrunAdi = "INTEL Core i3 10100F 3.60GHz 6MB Önbellek 4 Çekirdek 1200 14nm İşlemci";
            urun1.Marka = "INTEL";
            urun1.IslemciNesli = "10.Nesil";
            urun1.IslemciBellekMiktari = "6Mb";
            urun1.IslemciFrekansı = "3.60 Ghz";

            Urun urun2 = new Urun();
            urun2.UrunAdi = "AMD RYZEN 5 56s00X 3.7GHz 32MB Önbellek 6 Çekirdek AM4 7nm İşlemci";
            urun2.Marka = "AMD";
            urun2.IslemciNesli = "Yok";
            urun2.IslemciBellekMiktari = "32Mb";
            urun2.IslemciFrekansı = "3.7 Ghz";

            Urun urun3 = new Urun();
            urun3.UrunAdi = "INTEL Core i7 10700K 3.8GHz 16MB Önbellek 8 Çekirdek 1200 İşlemci";
            urun3.Marka = "INTEL";
            urun3.IslemciNesli = "10";
            urun3.IslemciBellekMiktari = "16Mb";
            urun3.IslemciFrekansı = "3.8 Ghz";

            Urun[] urunler = new Urun[] {urun1,urun2,urun3 };
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("For Döngüsü Kullanılarak Yapılan Çözüm:");
            Console.WriteLine("-----------------------------------------------------------");
            for (int i=0;i<urunler.Length;i++)
            {
                Console.WriteLine("Ürün Adı:{0}",urunler[i].UrunAdi);
                Console.WriteLine("Ürün Markası:{0}", urunler[i].Marka);
                Console.WriteLine("Ürün Nesli:{0}", urunler[i].IslemciNesli);
                Console.WriteLine("Ürün Önbellek Miktarı:{0}", urunler[i].IslemciBellekMiktari);
                Console.WriteLine("Ürün Çalışma Frekansı:{0}", urunler[i].IslemciFrekansı);
                Console.WriteLine("\n***************************\n");
            }

            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("foreach Kullanılarak Yapılan Çözüm:");
            Console.WriteLine("-----------------------------------------------------------");
            foreach (var urun in urunler)
            {
                Console.WriteLine("Ürün Adı:{0}", urun.UrunAdi);
                Console.WriteLine("Ürün Markası:{0}", urun.Marka);
                Console.WriteLine("Ürün Nesli:{0}", urun.IslemciNesli);
                Console.WriteLine("Ürün Önbellek Miktarı:{0}", urun.IslemciBellekMiktari);
                Console.WriteLine("Ürün Çalışma Frekansı:{0}", urun.IslemciFrekansı);
                Console.WriteLine("\n***************************\n");
            }
            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine("While Kullanılarak Yapılan Çözüm:");
            Console.WriteLine("-----------------------------------------------------------");
            int x = 0;
            while (x<urunler.Length)
            {
                Console.WriteLine("Ürün Adı:{0}", urunler[x].UrunAdi);
                Console.WriteLine("Ürün Markası:{0}", urunler[x].Marka);
                Console.WriteLine("Ürün Nesli:{0}", urunler[x].IslemciNesli);
                Console.WriteLine("Ürün Önbellek Miktarı:{0}", urunler[x].IslemciBellekMiktari);
                Console.WriteLine("Ürün Çalışma Frekansı:{0}", urunler[x].IslemciFrekansı);
                Console.WriteLine("\n***************************\n");
                x++;
            }
        }
    }
    class Urun
    {
        public string UrunAdi { get; set; }
        public string Marka { get; set; }
        public string IslemciNesli { get; set; }
        public string IslemciBellekMiktari { get; set; }
        public string IslemciFrekansı { get; set; }
    }
}
