using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;
using System.Web.Http.Description;

namespace CineWebApi.Controllers
{
	public class EntradaController : ApiController
	{
		public EntradaController() { }

		// POST : api/Entrada - Create new Entrada
		[ResponseType(typeof(Entrada))]
		public IHttpActionResult Post(Entrada entrada)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			return Ok(entrada);
		}

		// GET : api/Entrada/5 - Read one Entrada by ID
		[ResponseType(typeof(Entrada))]
		public IHttpActionResult Get(long id)
		{
			return Ok(new Entrada());
		}

		// GET : api/Entrada - Read all Entrada in DB
		public IQueryable<Entrada> Get()
		{
			return null;
		}

		// PUT : api/Entrada/5 - Update one Entrada by given ID
		[ResponseType(typeof(Entrada))]
		public IHttpActionResult Put(long id, Entrada entrada)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			if (id != entrada.Id)
			{
				return BadRequest();
			}

			return Ok(entrada);
		}

		// DELETE : api/Entrada/5 - Delete one Entrada by given ID
		[ResponseType(typeof(Entrada))]
		public IHttpActionResult Delete(long id)
		{
			return Ok(new Entrada());
		}
	}
}