using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
	public class CategoryManager : ICategoryService
	{
		/*
		 * Business Layeri-DataAccesse bağımlı
		 * ama DataAccess'te sonradan Ef den farklı Teknolojiler kullanılmak
		 * istenirse,burda bağımlılığımızı minimaze ediyoruz
		 * constructor injection!!!
		 */
		 ICategoryDal _categoryDal;
		//interface(reference üzerinden bağımlılığı temsil ediyoruz burda)
		 public CategoryManager(ICategoryDal categoryDal)
		 {
			 _categoryDal = categoryDal;
		 }
		public List<Category> GetAll()
		{
			//İş kodları
			return _categoryDal.GetAll();

		}

		public Category GetById(int categoryId)
		{
			return _categoryDal.Get(c => c.CategoryId == categoryId);
		}
	}
}
