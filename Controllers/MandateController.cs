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
            var allMandate = await _service.GetAllAsync();
            return View(allMandate);
        }

        // Create
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
            await _service.AddAsync(mandate);
            return RedirectToAction(nameof(Index));
        }


        //Edit
        public async Task<IActionResult> Edit(int id)
        {
            var mandateEdit = await _service.GetByIdAsync(id);
            if (mandateEdit == null) return View("NotFound");

            
            return View(mandateEdit);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("MandateId,RegistrationNumber,Price,Street,Date,paid,PictureUrl")] Mandate mandate)
        {
            if (!ModelState.IsValid)
            {
                return View(mandate);
            }
            await _service.UpdateAsync(id, mandate);
            return RedirectToAction(nameof(Index));
        }


        //Delete
        public async Task<IActionResult> Delete(int id)
        {
            var mandateDelete = await _service.GetByIdAsync(id);
            if (mandateDelete == null) return View("NotFound");


            return View(mandateDelete);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var mandateDelete = await _service.GetByIdAsync(id);
            if (mandateDelete == null) return View("NotFound");

            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }

    }
}
