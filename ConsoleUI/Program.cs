using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        //Data Transformation Object
        //SOLID
        //Open Closed Principle =>Yaptığın yazılıma yeni bir özellike ekliyorsan ,mevcuttaki hiçbir koduna dokunamazsın kuralıdır .
        static void Main(string[] args)
        {
            ProductTest();

            //CategoryTest();
        }

        private static void CategoryTest()
        {
            CategoryManeger categoryManeger = new CategoryManeger(new EfCategoryDal());
            foreach (var category in categoryManeger.GetAll())
            {
                Console.WriteLine(category.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());

            var result = productManager.GetProductDetails();
            if (result.Success)
            {
                foreach (var prooduct in result.Data)
                {
                    Console.WriteLine(prooduct.ProductName + "/" + prooduct.CategoryName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }

           
        }
    }
}
