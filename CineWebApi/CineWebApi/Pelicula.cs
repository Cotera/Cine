using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CineWebApi
{
	public class Pelicula
	{
		public long Id { get; set; }

		public string Titulo { get; set; }
		public string Director { get; set; }
		public int Anio { get; set; }
		public int Sala { get; set; }
	}
}