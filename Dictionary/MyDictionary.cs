using System;
using System.Collections.Generic;
using System.Text;

namespace Dictionary
{
    class MyDictionary<MyD>
    {
        MyD[] kelimeler;
        
        public MyDictionary()
        {
            kelimeler = new MyD[0];
        }
        public void Add(MyD kelime )
        {
            MyD[] tempDict = kelimeler;
            kelimeler = new MyD[kelimeler.Length + 1];
            for (int i = 0; i < tempDict.Length; i++)
            {
                kelimeler[i] = tempDict[i];
            }
            kelimeler[kelimeler.Length - 1] = kelime;
        }
        public void Listele()
        {
            foreach (var kelime in kelimeler)
            {
                Console.WriteLine(kelime);
            }
        }
    }
}
