
using NextGen.Domain.Abstract;
using NextGen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NextGen.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private IEntityRepository<ch_submission> _chSubmissions;

        public HomeController(IEntityRepository<ch_submission> chSubmissions)
        {
            _chSubmissions = chSubmissions;
        }

        public ActionResult Index()
        {
            var listOfSubmissions = _chSubmissions.GetAll().Take(5).ToList();
            return View(listOfSubmissions);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}