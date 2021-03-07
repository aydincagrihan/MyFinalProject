using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
	//IResult'ın somut(concrete) sınıfı

	public class Result : IResult
	{
		
		//this'le birlikte success de çalışacak don't repeat yourself mantığına uyduk
		public Result(bool success, string message):this(success)
		{
			Message = message;
			
		}
		
		public Result(bool success)//overloading process
		{
			
			Success = success;
		}
		//get'ler readonlydir constructorde set edilebilirler
		public bool Success { get; }
		
		public string Message { get; }
	}
}
