using CineWebApi.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CineWebApi.Repository
{
	public class EntradaRepository : IEntradaRepository
	{
		public Entrada Create(Entrada entrada)
		{
			return ApplicationDbContext.applicationDbContext.Entrada.Add(entrada);
		}

		public IQueryable<Entrada> Read()
		{
			IList<Entrada> lista = new List<Entrada>(ApplicationDbContext.applicationDbContext.Entrada);
			return lista.AsQueryable();
		}

		public Entrada Read(long Id)
		{
			return ApplicationDbContext.applicationDbContext.Entrada.Find(Id);
		}

		public void Update(Entrada entrada)
		{
			ApplicationDbContext.applicationDbContext.Entry(entrada).State = EntityState.Modified;
		}

		public Entrada Delete(long Id)
		{
			Entrada entrada = this.Read(Id);
			if (entrada == null)
			{
				throw new NoEncontradoException("No se ha encontrado la persona  a eliminar");
			}
			return ApplicationDbContext.applicationDbContext.Entrada.Remove(entrada);
		}
	}
}