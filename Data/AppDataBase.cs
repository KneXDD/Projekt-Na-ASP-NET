using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt.Data
{
    public class AppDataBase:DbContext
    {
        public AppDataBase(DbContextOptions<AppDataBase> options) : base(options)
        {

        }
    }
}
