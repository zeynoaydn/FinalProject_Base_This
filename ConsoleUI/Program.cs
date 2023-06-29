using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

namespace ConsoleUI
{
    internal class Program
    {
        //SOLID
        //open closed principle
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //ProductTest();

            //CategoryTest();

            ProductTestDto();
        }

        private static void ProductTestDto()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var item in productManager.GetProductDetails())
            {
                Console.WriteLine(item.ProductName+" "+item.ProductId);
            }
        }
        private static void CategoryTest()
        {
            CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
            foreach (var item in categoryManager.GetAll())
            {
                Console.WriteLine(item.CategoryName);
            }
        }

        private static void ProductTest()
        {
            ProductManager productManager = new ProductManager(new EfProductDal());
            foreach (var item in productManager.GetByUnitPrice(20, 100))
            {
                Console.WriteLine(item.ProductName);
            }
        }


    }
}