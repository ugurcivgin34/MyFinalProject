using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        //SOLID
        //Open Closed Principle =>Yaptığın yazılıma yeni bir özellike ekliyorsan ,mevcuttaki hiçbir koduna dokunamazsın kuralıdır .
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            foreach (var prooduct in productManager.GetByUnitPrice(40,100))
            {
                Console.WriteLine(prooduct.ProductName);
            }

            
        }
    }
}
