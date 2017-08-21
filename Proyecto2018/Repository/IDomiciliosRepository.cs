using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto2018.Repository
{
    public interface IDomiciliosRepository
    {
        Domicilio Create(Domicilio domicilio);
        Domicilio Get(long id);
        IQueryable<Domicilio> Get();
        void Put(Domicilio domicilio);
        Domicilio Delete(long id);
    }
}
