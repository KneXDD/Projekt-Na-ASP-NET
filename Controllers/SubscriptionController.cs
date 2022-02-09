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
    public class SubscriptionController : Controller
    {
        private readonly ISubscriptionService _service;
        public SubscriptionController(ISubscriptionService service)
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var allSubscription = await _service.GetAllAsync();
            return View(allSubscription);
        }

        //Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("RegistrationNumber,Name,Surname,Street,StartDate,EndDate,SubscriptionVariant,Active,Paid")]Subscription subscription)
        {
            if (!ModelState.IsValid)
            {
                return View(subscription);
            }
            await _service.AddAsync(subscription);
            return RedirectToAction(nameof(Index));
        }

        //Edit
        public async Task<IActionResult> Edit(int id)
        {
            var subscriptionEdit = await _service.GetByIdAsync(id);
            if (subscriptionEdit == null) return View("NotFound");


            return View(subscriptionEdit);
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, [Bind("SubscriptionId,RegistrationNumber,Name,Surname,Street,StartDate,EndDate,SubscriptionVariant,Active,Paid")] Subscription subscription)
        {
            if (!ModelState.IsValid)
            {
                return View(subscription);
            }
            await _service.UpdateAsync(id, subscription);
            return RedirectToAction(nameof(Index));
        }

        //Delete
        public async Task<IActionResult> Delete(int id)
        {
            var subscriptionDelete = await _service.GetByIdAsync(id);
            if (subscriptionDelete == null) return View("NotFound");


            return View(subscriptionDelete);
        }

        [HttpPost, ActionName("Delete")]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var subscriptionDelete = await _service.GetByIdAsync(id);
            if (subscriptionDelete == null) return View("NotFound");

            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
