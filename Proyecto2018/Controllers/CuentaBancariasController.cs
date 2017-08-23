using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using Proyecto2018;
using Proyecto2018.Models;
using Proyecto2018.Service;
using System.Web.Http.Cors;

namespace Proyecto2018.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]

    public class CuentaBancariasController : ApiController
        {
            private ICuentaBancariaService cuentaBancariaService;

            public CuentaBancariasController(ICuentaBancariaService _cuentaBancariaService)
            {
                this.cuentaBancariaService = _cuentaBancariaService;
            }

            // GET: api/Entradas
            public IQueryable<CuentaBancaria> GetCuentaBancaria()
            {
                return cuentaBancariaService.Get();
            }

            // GET: api/Entradas/5
            [ResponseType(typeof(CuentaBancaria))]
            public IHttpActionResult GetEntrada(long id)
            {
                CuentaBancaria cuentaBancaria = cuentaBancariaService.Get(id);
                if (cuentaBancaria == null)
                {
                    return NotFound();
                }

                return Ok(cuentaBancaria);
            }

            // PUT: api/Entradas/5
            [ResponseType(typeof(void))]
            public IHttpActionResult PutEntrada(long id, CuentaBancaria cuentaBancaria)
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                if (id != cuentaBancaria.Id)
                {
                    return BadRequest();
                }

                try
                {
                    cuentaBancariaService.Put(cuentaBancaria);
                }
                catch (NoEncontradoException)
                {
                    return NotFound();
                }

                return StatusCode(HttpStatusCode.NoContent);
            }

            // POST: api/Entradas
            [ResponseType(typeof(CuentaBancaria))]
            public IHttpActionResult PostEntrada(CuentaBancaria cuentaBancaria)
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }

                cuentaBancaria = cuentaBancariaService.Create(cuentaBancaria);

                return CreatedAtRoute("DefaultApi", new { id = cuentaBancaria.Id }, cuentaBancaria);
            }

            // DELETE: api/Entradas/5
            [ResponseType(typeof(CuentaBancaria))]
            public IHttpActionResult DeleteEntrada(long id)
            {
                CuentaBancaria cuentaBancaria;
                try
                {
                    cuentaBancaria = cuentaBancariaService.Delete(id);
                }
                catch (NoEncontradoException)
                {
                    return NotFound();
                }

                return Ok(cuentaBancaria);
            }
        }
    }