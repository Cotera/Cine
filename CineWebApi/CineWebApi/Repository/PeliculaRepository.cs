using CineWebApi.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CineWebApi.Repository
{
	public class PeliculaRepository : IPeliculaRepository
	{
		public Pelicula Create(Pelicula pelicula)
		{
			return ApplicationDbContext.applicationDbContext.Pelicula.Add(pelicula);
		}

		public IQueryable<Pelicula> Read()
		{
			IList<Pelicula> lista = new List<Pelicula>(ApplicationDbContext.applicationDbContext.Pelicula);
			return lista.AsQueryable();
		}

		public Pelicula Read(long Id)
		{
			return ApplicationDbContext.applicationDbContext.Pelicula.Find(Id);
		}

		public void Update(Pelicula pelicula)
		{
			ApplicationDbContext.applicationDbContext.Entry(pelicula).State = EntityState.Modified;
		}

		public Pelicula Delete(long Id)
		{
			Pelicula pelicula = this.Read(Id);
			if (pelicula == null)
			{
				throw new NoEncontradoException("No se ha encontrado la persona  a eliminar");
			}
			return ApplicationDbContext.applicationDbContext.Pelicula.Remove(pelicula);
		}
	}
}