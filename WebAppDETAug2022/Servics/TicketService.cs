
using WebAppDETAug2022.Models;

namespace WebAppDETAug2022.Servics
{
    public class TicketService
    {
        static List<Ticket> Tickets { get; }
        static int nextId = 3;
        static TicketService()
        {
            Tickets = new List<Ticket>
                {
                    new Ticket { Id=1, Caterory="Platinum Plus",Price=5000,MaxTicket=200000 },
                    new Ticket { Id=2,Caterory="Platinum ",Price=4000,MaxTicket=300000 },
                    new Ticket{Id=3,Caterory="Gold",Price=3000,MaxTicket=500000},
                    new Ticket{Id = 4, Caterory="Silver",Price=2000,MaxTicket=500000},
                    new Ticket{Id = 5, Caterory="General",Price=5000,MaxTicket=1000000}
                };
        }

        public static List<Ticket> GetAll() => Tickets;

        public static Ticket? Get(int id) => Tickets.FirstOrDefault(p => p.Id == id);

        public static void Add(Ticket ticket)
        {
            ticket.Id= nextId++;
            Tickets.Add(ticket);
        }

        public static void Delete(int id)
        {
            var ticket = Get(id);
            if (ticket is null)
                return;

            Tickets.Remove(ticket);
        }

        public static void Update(Ticket ticket)
        {
            var index = Tickets.FindIndex(p => p.Id == ticket.Id);
            if (index == -1)
                return;

            Tickets[index] = ticket;
        }
    }
}
