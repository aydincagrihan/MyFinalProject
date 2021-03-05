using Entities.Concrete;
using Core.DataAccess;
using System;
using System.Collections.Generic;
using System.Text;
using Entities.DTOs;

namespace DataAccess.Abstract
{/// <summary>
/// 1
/// </summary>
	public interface IProductDal:IEntityRepository<Product>
	{
	List<ProductDetailDto> GetProductDetails();

	}
}
