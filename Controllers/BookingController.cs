using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EventPlanner.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace EventPlanner.Controllers
{
    public class BookingController : Controller
    {
        private readonly ApplicationDbContext _db;

        public BookingController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult BookingRecord()
        {
            var displaydata = _db.BookingTable.ToList();
            return View(displaydata);
        }

        
        public IActionResult Booking()
        {
            //var eventtypes = _db.EventTypeTable.Select(e => e.EventType);
            //var eventtypeviewModel = new EventTypeModel
            //{
            //    EventTypeList = new SelectList(eventtypes)
            //}; 
            List<EventTypeModel> EventTypeList = new List<EventTypeModel>();
            EventTypeList = (from eventtype in _db.EventTypeTable select eventtype).ToList();
            EventTypeList.Insert(0, new EventTypeModel { EventType_id = 0, EventType = "Choose Event" });
            ViewBag.listofevent = EventTypeList;

            List<Venue> VenueList = new List<Venue>();
            VenueList = (from venue in _db.VenueTable select venue).ToList();
            VenueList.Insert(0, new Venue { Venue_id = 0, Venue_name = "Choose Venue" });
            ViewBag.listofvenue = VenueList;

            List<Design> designlist = new List<Design>();
            designlist = (from design in _db.DesignTable select design).ToList();
            designlist.Insert(0, new Design { Design_id = 0, Design_theme = "Choose Design Theme" });
            ViewBag.listofdesign = designlist;

            List<Menu> menulist = new List<Menu>();
            menulist = (from menu in _db.MenuTable select menu).ToList();
            menulist.Insert(0, new Menu { Menu_id = 0, Menu_name = "Choose Menu" });
            ViewBag.listofmenu = menulist;

            return View();
        }



        [HttpPost]
        public async Task<IActionResult> Booking(Booking booking)
        {

            if (ModelState.IsValid)
            {
                //var eventtypes = _db.EventTypeTable.Select(r => r.EventType);
                //EventTypeModel.
                _db.Add(booking);
                await _db.SaveChangesAsync();
                return RedirectToAction("Index","Home");
            }

            return View();
        }


        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("BookingRecords");
            }
            var getbookingdetails = await _db.BookingTable.FindAsync(id);
            return View(getbookingdetails);

        }

        [HttpPost]
        public async Task<IActionResult> Edit(Booking booking)
        {
            if (ModelState.IsValid)
            {
                _db.Update(booking);
                await _db.SaveChangesAsync();
                return RedirectToAction("BookingRecords");
            }
            return View(booking);
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("BookingRecords");
            }
            var getbookingdetails = await _db.BookingTable.FindAsync(id);
            return View(getbookingdetails);

        }

        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("BookingRecords");
            }
            var getbookingdetails = await _db.BookingTable.FindAsync(id);
            return View(getbookingdetails);

        }

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {
            var getbookingdetails = await _db.BookingTable.FindAsync(id);
            _db.BookingTable.Remove(getbookingdetails);
            await _db.SaveChangesAsync();

            return RedirectToAction("BookingRecords");

        }


        //public JsonResult GetVenue(int Venue_id)
        //{
        //    List<Venue> venuelist = new List<Venue>();
        //    venuelist = (from venue in _db.VenueTable select venue).ToList();
        //    venuelist.Insert(0, new Venue { Venue_id = 0, Venue_name = "Choose Venue" });
        //    return Json(new SelectList(venuelist, "Venue_id", "Venue_name"));
        //}
        //public JsonResult GetDesign(int Design_id)
        //{
        //    List<Design> designlist = new List<Design>();
        //    designlist = (from design in _db.DesignTable select design).ToList();
        //    designlist.Insert(0, new Design { Design_id = 0, Design_theme = "Choose Design Theme" });
        //    return Json(new SelectList(designlist, "Design_id", "Design_theme"));
        //}
        //public JsonResult GetMenu(int Menu_id)
        //{
        //    List<Menu> menulist = new List<Menu>();
        //    menulist = (from menu in _db.MenuTable select menu).ToList();
        //    menulist.Insert(0, new Menu { Menu_id = 0, Menu_name = "Choose Menu" });
        //    return Json(new SelectList(menulist, "Venue_id", "Venue_name"));
        //}
    }
}
