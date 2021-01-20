using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        //encapsulation
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " eklendi.");
        }

        //void ? = işlemini yapar ve bitirir.(emir kipi) 
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }

        
    }
}
