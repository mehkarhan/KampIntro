using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin BRO";
            kurs1.IzlenmeOrani = 86;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "C++";
            kurs2.Egitmen = "Mehmet BRO";
            kurs2.IzlenmeOrani = 25;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Java";
            kurs3.Egitmen = "Uğur BRO";
            kurs3.IzlenmeOrani = 70;

            Kurs kurs4 = new Kurs();
            kurs4.KursAdi = "Emlak Sitesi";
            kurs4.Egitmen = "Pınar BRO";
            kurs4.IzlenmeOrani = 90;

            //Console.WriteLine("Kurs Adı:"+kurs1.KursAdi+" - Eğitmen:"+kurs1.Egitmen+" - Tamamlama Oranı:%"+kurs1.IzlenmeOrani);
            // Dizi olarak tanımlanırsa
            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3,kurs4};

            foreach (var kurs in kurslar)
            {
                Console.WriteLine("Kurs Adı:"+kurs.KursAdi);
                Console.WriteLine("Eğitmeni:"+kurs.Egitmen);
                Console.WriteLine("İzlenme Oranı:"+kurs.IzlenmeOrani);
                Console.WriteLine("*************************");
            }
            
        }
    }
    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int  IzlenmeOrani{ get; set; }
    }
}
