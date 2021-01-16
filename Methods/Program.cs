using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Name = "Apple";
            product1.Price = 15;
            product1.Detail = "Best Apple";
            product1.stokAdedi = 20;

            Product product2 = new Product();
            product2.Name = "Watermelon";
            product2.Price = 80;
            product2.Detail = "Diyarbakir Watermelon";

            Product[] products = new Product[] { product1, product2 };
            
            //type-safe -- Tip güvenli
            foreach (var product in products)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.Detail);
                Console.WriteLine(product.stokAdedi);
                Console.WriteLine("--------");
            }

            Console.WriteLine("----------------------Methods--------------");

            //instance - örnek
            //reusability - tekrar kullanabilirlik
            //encapsulation
            BasketManager basketManager = new BasketManager();
            basketManager.Add(product1);
            basketManager.Add(product2);

            basketManager.Add2("Armut", "Yeşil armut", 12, 10);
            basketManager.Add2("Elma", "Yeşil elma", 12, 9);
            basketManager.Add2("Karpuz", "Diyarbakır Karpuzu", 12, 8);
        }
    }
}
