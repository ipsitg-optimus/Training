using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayReservationSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            TicketInformation[] tickets = new TicketInformation[5];
            tickets[0] = new TicketInformation("Ipsit", 21, "Delhi", "Bareilly", "21/7/2014", 4233);
            tickets[1] = new TicketInformation("Arun", 22, "Lucknow", "Bareilly", "22/7/2014", 1233);
            tickets[2] = new TicketInformation("Shyam", 23, "Bhopal", "Delhi", "21/7/2014", 1111);
            tickets[3] = new TicketInformation("Mohan", 24, "Chennai", "Mumbai", "22/7/2014", 2121);
            tickets[4] = new TicketInformation("Gopal", 25, "Delhi", "Barabanki", "25/7/2014", 32323);


            tickets[2].CancelTicket();
            tickets[4].CancelTicket();
            for (int counter = 0; counter < 5; counter++)
            {
                tickets[counter].DisplayInformation();
            }
            Console.ReadKey();
        }
    }
}
