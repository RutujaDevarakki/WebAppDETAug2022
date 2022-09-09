using Microsoft.AspNetCore.Mvc;
using MVCDemo.Models;



namespace MVCDemo.Controllers
{
    public class EventController : Controller
    {
        private List<Booking> events;



        public IActionResult Index()
        {
            events = new List<Booking>();
            events.Add(new Booking { EventTitle = "ask CEO", EventsDate = DateTime.Today, Qty = 10 });
            return View(events);
        }
    }
}