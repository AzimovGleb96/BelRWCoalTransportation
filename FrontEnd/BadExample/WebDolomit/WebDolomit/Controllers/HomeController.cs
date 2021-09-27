using System;
using System.Collections.Generic;
using System.Web.Mvc;
using WebDolomit.Models;
using WebDolomit.Repositories;
using WebDolomit.ViewModels;

namespace WebDolomit.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly DataManager _dataManager;
        public HomeController(DataManager dataManager)
        {
            _dataManager = dataManager;
        }
        [AllowAnonymous]
        [HttpGet]
        public ActionResult Index(DateTime? date)
        {
            if (!date.HasValue)
                date = DateTime.Now.Date;
            List<DataViewModel> data = _dataManager.ILogic.GetData(date.Value);
            if (date.Value.Date < DateTime.Now.Date)
            {
                ViewBag.Date = date.Value.ToString("MMMM yyyy");
            }
            else { ViewBag.Date = date.Value.ToShortDateString(); }

            ViewBag.FullDate = date.Value.Date;
            return View(data);
        }

        [HttpGet]
        public ActionResult AddData()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddData(Data model)
        {
            if (ModelState.IsValid)
            {
                bool fl = _dataManager.ILogic.SaveData(model);

                return RedirectToAction("Index");
            }
            else ModelState.AddModelError("", "Проверьте данные");
            return View(model);
        }

        [HttpPost]
        public ActionResult EditDataById(int id)
        {
            if (id != 0)
            {
                Data model = _dataManager.ILogic.FindDataByID(id);
                return View("EditData", model);
            }
            else return RedirectToAction("Index");

        }

        [HttpPost]
        public ActionResult EditData(Data model)
        {
            if (ModelState.IsValid)
            {
                bool fl = _dataManager.ILogic.SaveData(model);

                return RedirectToAction("Index");
            }
            else ModelState.AddModelError("", "Проверьте данные");
            return View(model);
        }

    }
}