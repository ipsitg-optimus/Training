using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailwayReservationSystem
{
    class TicketInformation
    {
        #region private members
        private string _passengerName;
        private int _age;
        private string _to;
        private string _from;
        private string _date;
        private int _trainNumber;
        private string _status;
        #endregion

        /// <summary>
        /// Constructor for initializing a new TicketInformation's instance.
        /// </summary>
        /// <param name="passengerName">name of passenger</param>
        /// <param name="age">age of passenger</param>
        /// <param name="to">destination station</param>
        /// <param name="from">initial station</param>
        /// <param name="date">date of journey</param>
        /// <param name="trainNumber">train number</param>
        public TicketInformation(string passengerName, int age, string to, string from, string date, int trainNumber)
        {
            this._passengerName = passengerName;
            this._age = age;
            this._to = to;
            this._from = from;
            this._date = date;
            this._trainNumber = trainNumber;
            _status = "Booked";
        }

        /// <summary>
        /// Displays information of the ticket.
        /// </summary>
        public void DisplayInformation()
        {
            Console.WriteLine("\n------Ticket Details----");
            Console.WriteLine("Name of Passenger: {0}", _passengerName);
            Console.WriteLine("Age of Passenger: {0}", _age);
            Console.WriteLine("Boarding station: {0}", _to);
            Console.WriteLine("Destination station: {0}", _from);
            Console.WriteLine("Date of journey: {0}", _date);
            Console.WriteLine("Train number: {0}", _trainNumber);
            Console.WriteLine("Status of ticket: {0}", _status);
        }

        /// <summary>
        /// Cancels the current ticket.
        /// </summary>
        public void CancelTicket()
        {
            _status = "Canceled";
            Console.WriteLine("Ticket has been canceled.");
        }
    }
}
