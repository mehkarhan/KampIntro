using System;

namespace ternary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Not Ortalamanızı Giriniz:");
            int ort = int.Parse(Console.ReadLine());

            string sonuc = ort >= 0 && ort < 25 ? "Başarısız" : (ort >= 25 && ort < 50 ? "Kaldı" :
                (ort >= 50 && ort < 60 ? "Geçer" : (ort >= 60 && ort < 70 ? "Orta" : (ort >= 70 && ort < 85 ? 
                "İyi" : (ort >= 85 && ort <= 100 ? "Pekiyi" : "Hatalı Not Girişi")))));
            Console.WriteLine("Sonuç:"+sonuc);
        }   
    }
}