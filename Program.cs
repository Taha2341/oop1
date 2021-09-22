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
            product1.ProductName = "masa";
            product1.UnıtPrıve = 500;
            product1.UnıtsInStock = 3;

            ProductManager productManager = new ProductManager();
            productManager.add(product1);
            Console.WriteLine(product1.ProductName);
        }
    }
}
