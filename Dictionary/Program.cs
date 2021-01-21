using System;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            MyDictionary<string> kelimeler = new MyDictionary<string>();
            //kelimeler.Add("Hoşgeldin");
            //kelimeler.Listele();
            while(i!=0)
            {
                Console.WriteLine("Hangi İşlemi yapacaksınız..");
                Console.WriteLine("Ekleme: 1 - Listeleme:2 - Çıkış:0");
                Console.Write("Yapacağınız işlem: ");
                i = int.Parse(Console.ReadLine());

                if(i==1)
                {
                    Console.Write("Eklemek istediğiniz kelimeyi yazınız:");
                    string kelime = Console.ReadLine();
                    kelimeler.Add(kelime);
                    Console.WriteLine("-------------------------------------");
                }
                else if (i==2)
                {
                    kelimeler.Listele(); Console.WriteLine("-------------------------------------");
                }
                else
                {
                    Console.WriteLine("Sistemden çıkıyorsunuz"); Console.WriteLine("-------------------------------------");
                }
            }
        }
    }
}
