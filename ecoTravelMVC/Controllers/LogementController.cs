using BLL.Entities;
using COMMON.Repository;
using ecoTravelMVC.Handlers;
using ecoTravelMVC.Models.LogementModelView;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace ecoTravelMVC.Controllers
{
    public class LogementController : Controller
    {
        private readonly ILogementRepository<Logement, int> _service;
        // GET: LogementController

        public LogementController(ILogementRepository<Logement, int> service)
        {
            _service = service;
        }

        public ActionResult Index()
        {
            IEnumerable<LogementListItem> model = _service.Get().Select(e => e.ToListItem());
            return View(model);
        }

        // GET: LogementController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: LogementController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LogementController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(LogementCreateForm form)
        {
            if (!ModelState.IsValid) return View(form);
            int id = _service.Insert(form.ToBLL());
            return RedirectToAction("Details","Logement", new { id = id });
        }

        // GET: LogementController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: LogementController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: LogementController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: LogementController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
