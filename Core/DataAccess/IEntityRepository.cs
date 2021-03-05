using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
	//Generic constraint(kısıtlama)
	//class:referance tip tutabilir
	//IEntity:IEntity olabilir veya IEntity iplemente edebilen bir nesne olabilir.
	//new() ,new'lenebilir olmalı interfaceler newlenemez(IEntity newlenemez)	 
	public interface IEntityRepository<T> where T:class,IEntity,new()
	{
		List<T> GetAll(Expression<Func<T,bool>> filter=null);

		T Get(Expression<Func<T, bool>> filter);

		void Add(T entity);

		void Update(T entity);

		void Delete(T entity);

		
	}
}
