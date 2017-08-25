using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Description;

namespace CineWebApi.Controllers
{
	public class PeliculaController : ApiController
	{
		public PeliculaController() { }

		// POST : api/Pelicula - Create new Pelicula
		[ResponseType(typeof(Pelicula))]
		public IHttpActionResult Post(Pelicula pelicula)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			return Ok(pelicula);
		}

		// GET : api/Pelicula/5 - Read one Pelicula by ID
		[ResponseType(typeof(Pelicula))]
		public IHttpActionResult Get(long id)
		{
			return Ok(new Pelicula());
		}

		// GET : api/Pelicula - Read all Pelicula in DB
		public IQueryable<Pelicula> Get()
		{
			return null;
		}

		// PUT : api/Pelicula/5 - Update one Pelicula by given ID
		[ResponseType(typeof(Pelicula))]
		public IHttpActionResult Put(long id, Pelicula pelicula)
		{
			if (!ModelState.IsValid)
			{
				return BadRequest(ModelState);
			}

			if (id != pelicula.Id)
			{
				return BadRequest();
			}

			return Ok(pelicula);
		}

		// DELETE : api/Pelicula/5 - Delete one Pelicula by given ID
		[ResponseType(typeof(Pelicula))]
		public IHttpActionResult Delete(long id)
		{
			return Ok(new Pelicula());
		}
	}
}