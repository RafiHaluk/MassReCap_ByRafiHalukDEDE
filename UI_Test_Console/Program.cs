using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace UI_Test_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            //At the final stage we can choose the mehtod to pull and view the data from DB...
            foreach (var product in productManager.GetAllByCategory(5))
            {
                Console.WriteLine(product.ProductName);
            }
        }
    }
}
