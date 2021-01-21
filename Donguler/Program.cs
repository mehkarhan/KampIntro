using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            //string kurs1 = "Yazılım Geliştirici Yetiştirme Kursu";
            //string kurs2 = "Programlamaya Başlangıç için Temel Kurs";
            //string kurs3 = "Java";

            //Array - Diziler

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kursu", 
                "Programlamaya Başlangıç için Temel Kurs",
                "Java","Python","HTML5","CSS3","C#","C++"};
            
            for (int i = 0; i < kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("\n\n\n");
            foreach (string kurs in kurslar)  //(var kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }
            Console.WriteLine("\n\nSayfa Sonu - Footer");
        }
    }
}
