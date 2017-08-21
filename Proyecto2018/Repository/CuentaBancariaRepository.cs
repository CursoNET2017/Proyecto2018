using Proyecto2018.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Proyecto2018.Repository
{
    public class CuentaBancariaRepository : ICuentaBancariaRepository
    {
        public CuentaBancaria Create(CuentaBancaria cuentaBancaria)
        {
            return ApplicationDbContext.applicationDbContext.CuentasBancarias.Add(cuentaBancaria);
        }
        
        public CuentaBancaria Get(long Id)
        {
            return ApplicationDbContext.applicationDbContext.CuentasBancarias.Find(Id);
        }

        public IQueryable<CuentaBancaria> Get()
        {
            IList<CuentaBancaria> lista = new List<CuentaBancaria>(ApplicationDbContext.applicationDbContext.CuentasBancarias);
            return lista.AsQueryable();
        }

        public void Put(CuentaBancaria cuentaBancaria)
        {
            if (ApplicationDbContext.applicationDbContext.CuentasBancarias.Count(e => e.Id == cuentaBancaria.Id) == 0)
            {
                throw new NoEncontradoException("No he encontrado la entidad");
            }
            ApplicationDbContext.applicationDbContext.Entry(cuentaBancaria).State = EntityState.Modified;
        }

        public CuentaBancaria Delete(long id)
        {
            CuentaBancaria cuentaBancaria = ApplicationDbContext.applicationDbContext.CuentasBancarias.Find(id);
            if (cuentaBancaria == null)
            {
                throw new NoEncontradoException("No he encontrado la entidad");
            }

            ApplicationDbContext.applicationDbContext.CuentasBancarias.Remove(cuentaBancaria);
            return cuentaBancaria;
        }
    }
}