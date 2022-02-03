using Microsoft.EntityFrameworkCore;
using Projekt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt.Data.Services
{
    public class MandateService : IMandateService
    {
        private readonly AppDataBase _context;
        public MandateService(AppDataBase context)
        {
            _context = context;
        }
        public void Add(Mandate mandate)
        {
            _context.Mandaty.Add(mandate);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Mandate>> GetAll()
        {
            var result = await _context.Mandaty.ToListAsync();
            return result;
        }

        public Mandate GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Mandate Update(int id, Mandate newMandate)
        {
            throw new NotImplementedException();
        }
    }
}
