using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel;
using WebAppDETAug2022.Models;
namespace WebAppDETAug2022.Pages
{
    public class IPLEventModel : PageModel
    {
        public List<Ticket> Tickets { get; set; }
        public void OnGet()
        {
            Tickets = new List<Ticket>
            {
                new Ticket{Id=1,Caterory="Platinum Plus",Price=5000,MaxTicket=200000},
                new Ticket{Id=2,Caterory="Platinum ",Price=4000,MaxTicket=300000},
                new Ticket{Id=3,Caterory="Gold",Price=3000,MaxTicket=500000},
                new Ticket{Id=4,Caterory="Silver",Price=2000,MaxTicket=500000},
                new Ticket{Id=5,Caterory="General",Price=5000,MaxTicket=1000000}
            };
        }
    }
}
