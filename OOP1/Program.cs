using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitInStock = 3;

            Product product2 = new Product {
            Id = 2, 
            CategoryId = 5, 
            UnitInStock = 5, 
            ProductName="Kalem",
            UnitPrice = 35
            };

            ProductService productService = new ProductService();
            productService.Add(product2);
            Console.WriteLine(product2.ProductName + " adlı ürün sisteme eklenmiştir");

            productService.Topla2(3,4);

            int topla = productService.Topla(2, 4);
            Console.WriteLine(topla*2);


        }
    }
}
