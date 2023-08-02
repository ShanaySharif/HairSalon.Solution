using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using HairSalon.Models;
using System.Linq;
namespace HairSalon.Controllers
{



    public class HomeController : Controller
    {

        private readonly HairSalonContext _db;

        public HomeController(HairSalonContext db)
        {
            _db = db;
        }
        [HttpGet("/")]
        public ActionResult Index()
        {

            List<Stylist> model = _db.Stylists.ToList();
            return View(model);

        }



    }

}