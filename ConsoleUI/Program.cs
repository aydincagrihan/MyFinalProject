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
			ProductTest();
			//Ioc,refactoring yapılacak yerler
			//CategoryTest();
		}

		private static void CategoryTest()
		{
			CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
			foreach (var category in categoryManager.GetAll().Data)
			{
				Console.WriteLine(category.CategoryName);
			}
		}

		private static void ProductTest()
		{
			ProductManager productManager = new ProductManager(new EfProductDal(),new CategoryManager(new EfCategoryDal()));

			var result = productManager.GetProductDetails();
			if (result.Success == true)
			{
				foreach (var product in result.Data)
				{
					Console.WriteLine(product.ProductName + "/" + product.CategoryName);

				}
			}
			else
			{
				Console.WriteLine(result.Message);
			}
			//foreach (var product in productManager.GetProductDetails().Data) //Product Name ve Category Name joinledik
			//{
			//	Console.WriteLine(product.ProductName + "/" + product.CategoryName);
			//}

		}
	}
}
