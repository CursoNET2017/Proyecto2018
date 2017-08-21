﻿using System.Linq;

namespace Proyecto2018.Repository
{
    public interface IPersonaRepository
    {
        Persona Create(Persona persona);
        Persona Delete(long id);
        Persona Get(long id);
        IQueryable<Persona> GetPersonas();
        void Put(Persona persona);
    }
}