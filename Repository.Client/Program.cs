using Repository.Client.Context;
using System;
using System.Linq;

namespace Repository.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== REPOSITORY ===");

            // Data Access ...
            using (var ctxSimple = new TicketContext())
            {
                Console.WriteLine($"Number of Tickets: {ctxSimple.Tickets.Count()}");
                Console.WriteLine("--------");
                foreach (var ticket in ctxSimple.Tickets)
                    Console.WriteLine($"[{ticket.Id}] {ticket.Title}");
            }

            Console.WriteLine("=== END ===");
        }
    }
}
