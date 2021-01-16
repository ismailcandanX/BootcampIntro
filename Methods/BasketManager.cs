using System;
using System.Collections.Generic;
using System.Text;

namespace Methods
{
    class BasketManager
    {
        //naming convention
        //syntax - yazım şekli
        public void Add(Product product)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + product.Name);
        }

        public void Add2(string productName, string detail, double price, int stokAdedi)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + productName);
        }
    }
}
