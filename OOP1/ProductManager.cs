using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        //Encapsulation
        // Product Class'ı içinde yer alan bütün verileri çağırmış oluyoruz.
        public void Add(Product product) // Parametreli Metot - Product türünde product isimli değişken
        {                                // Entity den çağırma yapılıyor   
            Console.WriteLine(product.ProductName + " eklendi.");
        }
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }
        


    }
}
