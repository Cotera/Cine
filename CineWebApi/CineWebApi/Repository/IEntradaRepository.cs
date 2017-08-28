using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CineWebApi.Repository
{
	public interface IEntradaRepository
	{
		Entrada Create(Entrada entrada);

		IQueryable<Entrada> Read();

		Entrada Read(long Id);

		void Update(Entrada entrada);

		Entrada Delete(long Id);
		
	}
}
