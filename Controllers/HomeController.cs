using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SPA.Models;

namespace SPA.Controllers
{
    public class HomeController : Controller
    {
        ReservationRepository repository = ReservationRepository.Current;
        // GET: Home
        public ActionResult Index()
        {
            return View(repository.GetAll());
        }
    }
}