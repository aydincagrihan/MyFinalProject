using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Core.Utilities.Results;
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
		public IDataResult<List<Category>> GetAll()
		{
			
			return new SuccessDataResult<List<Category>>( _categoryDal.GetAll());

		}

		public IDataResult<Category> GetById(int categoryId)
		{
			return new SuccessDataResult<Category>(_categoryDal.Get(c => c.CategoryId == categoryId));
		}
	}
}
