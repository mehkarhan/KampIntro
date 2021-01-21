using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>  // T bana uygun type ver anlamında ve blogun içini biçimlendireceğiz.
    {
        T[] items;
        
        public MyList()  // ctor  --> Constructor   başlangıçta new dediğimizde 0 elemanlı array oluşuyor
        {
            items = new T[0];
        }
        public void Add(T item)   // yukarıda T şeklinde hangisi tanımlanırsa o veri tipini alacak
        {                         // item sadece isimlendirme
            T[] tempArray = items;
            items = new T[items.Length+1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Length - 1] = item;

        }

    }
}
