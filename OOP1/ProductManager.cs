using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManager
    {
        public void Add(Products product)
        {
            Console.WriteLine( product.ProductName + "eklendi.");
        }      
        public void Update(Products product)
        {
            Console.WriteLine(product.ProductName + "güncellendi.");
        }
    }
}
