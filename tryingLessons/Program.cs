using System;

namespace tryingLessons
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.name = "Xiaomi Redmi Note 9 Pro 128 GB (Xiaomi Türkiye Garantili)";
            product1.oldPrice = 3799.99;
            product1.newPrice = 3189.91;

            Product product2 = new Product();
            product2.name = "Domestos Pratik Yüzey Spreyi 400 ml";
            product2.oldPrice = 29.89;
            product2.newPrice = 26.90;

            Product product3 = new Product();
            product3.name = "Dynamic Spin Bike V2 Kondisyon Bisikleti";
            product3.oldPrice = 1999.00;
            product3.newPrice = 1379.00;

            Product product4 = new Product();
            product4.name = "Lenovo IdeaPad 3 AMD 3020e 4GB 128GB SSD Freedos 15.6";
            product4.oldPrice = 4999.00;
            product4.newPrice = 3999.00;

            Product[] products = new Product[]
            {
                product1, product2, product3, product4
            };

            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine(products[i].name + " " + products[i].oldPrice + " yerine sadece " + products[i].newPrice );
            }

            foreach (var product in products)
            {
                Console.WriteLine(product.name + " " + product.oldPrice + " yerine sadece " + product.newPrice);
            }

            int m = products.Length;
            int x = 0;
            while ( x < m)
            {
                Console.WriteLine(products[x].name + " " + products[x].oldPrice + " yerine sadece " + products[x].newPrice );
                x = x + 1;
            }
        }
    }
    class Product
        {
        public string name { get; set; }
        public double oldPrice { get; set; }
        public double newPrice { get; set; }
    }
}
