using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class ProductManager
    { 
        public void add(Product product)
        {
           Console.WriteLine(product.ProductName + "eklendi! ");
        }

        public void update(Product product)
        {
            Console.WriteLine(product.ProductName + "güncellendi!");

        }


    }
}
