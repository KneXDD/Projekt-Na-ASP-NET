using Microsoft.AspNetCore.Mvc;
using Projekt.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt.Controllers
{
    public class MandateController : Controller
    {
        private readonly AppDataBase _context;
        public MandateController(AppDataBase context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var allMandate = _context.Mandaty.ToList();
            return View(allMandate);
        }
    }
}
