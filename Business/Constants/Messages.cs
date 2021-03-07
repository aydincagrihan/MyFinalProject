using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
	//class static'e çekilince newlenmez
	//mesajlarımız sabit olacağı için newlenmeye gerek yoktur

	public static class Messages
	{
		//Public'ler PascalCase ile yazılır
		public static string ProductAdded = "Ürün Eklendi";
		public static string ProductNameInvalid = "Ürün adı geçersiz";
		public static string MaintenanceTime="Sistem Bakımda";
		public static string ProductsListed="Ürünler Listelendi";
	}
}
