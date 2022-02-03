using Microsoft.AspNetCore.Mvc;
using Projekt.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt.Controllers
{
    public class SubscriptionController : Controller
    {
        private readonly AppDataBase _context;
        public SubscriptionController(AppDataBase context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var allSubscription = _context.Abonamenty.ToList();
            return View(allSubscription);
        }
    }
}
