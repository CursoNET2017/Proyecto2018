using Proyecto2018.Models;
using Proyecto2018.Repository;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Web;

namespace Proyecto2018.Service
{
    public class DomiciliosService : IDomiciliosService
    {
        private IDomiciliosRepository domiciliosRepository;
        public DomiciliosService(IDomiciliosRepository _domiciliosRepository)
        {
            this.domiciliosRepository = _domiciliosRepository;
        }

        public Domicilio Get(long id)
        {
               return domiciliosRepository.Get(id);
        }

        public IQueryable<Domicilio> Get()
        {
            return domiciliosRepository.Get();
        }

        public Domicilio Create(Domicilio domicilio)
        {
              return domiciliosRepository.Create(domicilio);
        }

        public void Put(Domicilio domicilio)
        {
              domiciliosRepository.Put(domicilio);
        }

        public Domicilio Delete(long id)
        {
            return domiciliosRepository.Delete(id);
        }
    }
}