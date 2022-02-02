using Microsoft.EntityFrameworkCore;
using Projekt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt.Data
{
    public class AppDataBase:DbContext
    {
        public AppDataBase(DbContextOptions<AppDataBase> options) : base(options)
        { }
        public DbSet<Mandate> Mandaty { get; set; }
        public DbSet<Subscription> Abonamenty { get; set; }
        
    }
}
