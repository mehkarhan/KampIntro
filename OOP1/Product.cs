using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product //Entity - Varlık
    {
        public int Id { get; set; }
        public int CategoryId { get; set; } //Foreign Key Alanı
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitsInStock { get; set; }
        //CRUD Create - Read - update - Delete 


    }
}
