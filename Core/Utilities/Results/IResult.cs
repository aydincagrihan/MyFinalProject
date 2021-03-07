using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
	//Temel void için başlangıç

	public interface IResult
	{
		bool Success { get; }//Sadece get kullandık(okumak),set(yazmak)

		string Message { get; }
	}
}
