using System;
using System.Collections.Generic;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //MyList<int> sayilar = new MyList<int>();
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Mehmet");

            List<string> sulela = new List<string> { "Mehmet", "Esra", "Zülal", "Melis", "Selim" };
            foreach (var su in sulela)
            {
                Console.WriteLine(su);
            }

        }
    }
}
