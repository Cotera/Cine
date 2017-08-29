using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CineWebApi
{
	public class Entrada
	{
		public long Id { get; set; }

		public int Fila { get; set; }
		public int Butaca { get; set; }
		public string Titular { get; set; }

	}
}