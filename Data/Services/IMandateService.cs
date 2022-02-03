using Projekt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt.Data.Services
{
    public interface IMandateService
    {
        Task<IEnumerable<Mandate>> GetAll();

        Mandate GetById(int id);

        void Add(Mandate mandate);

        Mandate Update(int id, Mandate newMandate);

        void Delete(int id);
    }
}
