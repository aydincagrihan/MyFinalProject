using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
	//SOLID
	//Open Closed Principle-Yani sistemimize yeni bir özellik ekleyince diğer katmanlarımız
	//iş süreçleri etkilenmedi bu örnekte localden-EF ye geçtik
	class Program
	{
		static void Main(string[] args)
		{
			//ProductTest();
			//Ioc,refactoring yapılacak yerler
			CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
			foreach (var category in categoryManager.GetAll())
			{
				Console.WriteLine(category.CategoryName);
				
			}
		}

		private static void ProductTest()
		{
			ProductManager productManager = new ProductManager(new EfProductDal());
			foreach (var product in productManager.GetAllByCategoryId(3)) //3.categorydeki ürünleri getir
			{
				Console.WriteLine(product.ProductName);
			}
		}
	}
}
