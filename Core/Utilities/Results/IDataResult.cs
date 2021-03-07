using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
	//Generic olduğundan dolayı <T> verdik çünkü farklı tipler dönecek
	//IResult'tan implemente edilecek,mesaj ve kontrol harici
	//data'da tutacak bu interface
	public interface IDataResult<T>:IResult
	{
		T Data { get; }
	}
}
