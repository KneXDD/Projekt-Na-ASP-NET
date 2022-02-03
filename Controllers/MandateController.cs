using Microsoft.AspNetCore.Mvc;
using Projekt.Data;
using Projekt.Data.Services;
using Projekt.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Projekt.Controllers
{
    public class MandateController : Controller
    {
        private readonly IMandateService _service;
        public MandateController(IMandateService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var allMandate = await _service.GetAll();
            return View(allMandate);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("RegistrationNumber,Price,Street,Date,paid,PictureUrl")]Mandate mandate)
        {
            if(!ModelState.IsValid)
            {
                return View(mandate);
            }
            _service.Add(mandate);
            return RedirectToAction(nameof(Index));
        }
    }
}
