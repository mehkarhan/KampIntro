﻿using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2; // Mobilya
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product2 = new Product { Id = 2, CategoryId = 5, UnitsInStock = 5, 
                ProductName="Kalem", UnitPrice=35};

            //PascalCase    //camelCase
            ProductManager productManager = new ProductManager();
            // ProductManager veri türündeki  productManager isimli değişken 
            //İntelshinel programing
            productManager.Add(product1);
            




            //int, double, bool .... değer tip
            // diziler, class, abstract class, interface .... referans tip
            // referans tiplerde atamalar bellekteki adresine göre atanır.
        }
    }
}
