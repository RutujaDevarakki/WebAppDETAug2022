using System.ComponentModel.DataAnnotations;
namespace WebAppDETAug2022.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public string? Caterory { get; set; }
        public int Price { get; set; }
        public int MaxTicket { get; set; }

    }
}
