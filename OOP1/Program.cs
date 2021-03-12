using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Products product1 = new Products();
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 4;

            Products product2 = new Products { Id = 2, CategoryId = 5, UnitsInStock = 5, ProductName = "Kalem", UnitPrice = 35 };

            ProductManager productManager = new ProductManager();
            productManager.Add(product1);
            productManager.Add(product2);

        }

    }
}
