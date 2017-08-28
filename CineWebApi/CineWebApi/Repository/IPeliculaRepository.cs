using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineWebApi.Repository
{
	interface IPeliculaRepository
	{
		Pelicula Create(Pelicula pelicula);

		IQueryable<Pelicula> Read();

		Pelicula Read(long Id);

		void Update(Pelicula cuentaBancaria);

		Pelicula Delete(long Id);
		
	}
}
