using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using HairSalon.Models;
using System.Collections.Generic;
using System.Linq;

namespace  HairSalon.Controllers
{
    public class StylistsController : Controller
    {
        public readonly HairSalonContext _db;
        public StylistsController(HairSalonContext db)
        {
            _db =db;
        }

        public ActionResult Index()
        {
            List<Stylist> model = _db.Stylists.Include(Stylist => Stylist.Clients).ToList();
            return View(model);
        }
        public ActionResult Create()
        {
            ViewBag.ClientId = new SelectList(_db.Clients, "ClientId", "Name");
            return View();
        }
        [HttpPost]
        public ActionResult Create( Stylist stylist)
        {
            if (stylist.ClientId == 0)
            {
                return RedirectToAction("Create");
            }
            _db.Stylists.Add(stylists);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult Details(int id)
        {
            Stylist thisStylist = _db.Stylists.Include(Stylist => Stylist.Client).FirstOrDefault(Stylist => Stylist.StylistId == id);
            return View(thisStylist);
        }
        public ActionResult Edit(int id)
        {
            Stylist thisStylist = _db.Stylists.FirstOrDefault(stylist => stylist.StylistId);
            ViewBag.ClientsId = new SlectList(_db.Clients, "ClientId", "Name");
            return View (thisStylist);
        }
        [HttpPost]
        public ActionResult Edit(Stylist stylist)
        {
            _db.Stylists.Update(stylist);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
        public Action Delete(int id)
        {
            Stylist thisStylist = _db.StylistsFirstOrDefault(stylist => stylist.StylistId == id );
            return View(thisStylist);
        }
        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Stylist thisStylist = db.Stylists.FirstOfDefault(Stylist => Stylist.StylistId == id);
            _db.Stylists.Remove(thisStylist);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }


    }
}
    