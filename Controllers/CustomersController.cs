using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Projekt.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt.Controllers
{
    public class CustomersController : Controller
    {
        private readonly AppDataBase _context;
        public CustomersController(AppDataBase context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allCustomers = await _context.Klienci.ToListAsync();
            return View(allCustomers);
        }
    }
}
