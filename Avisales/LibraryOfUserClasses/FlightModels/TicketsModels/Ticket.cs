using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LibraryOfUserClasses.FlightModels
{
    public class Ticket
    {
        [JsonProperty("Plane ID:")]
        public int PlaneID { get; set; }
        [JsonProperty("Flight ID:")]
        public int FlightID { get; set; }
        [JsonProperty("Price: ")]
        public double Price { get; set; }

        [JsonProperty("Class of ticket: ")]
        public TypeOfTicket TypeOfTicket { get; set; }

        [JsonProperty("From: ")]
        public string From { get; set; }

        [JsonProperty("To: ")]
        public string To { get; set; }

        [JsonProperty("Departure time: ")]
        public DateTime DepartureTime { get; set; }

        [JsonProperty("Arriving time: ")]
        public DateTime ArrivingTime { get; set; }

        public Ticket(int planeId, int flightId, double price, TypeOfTicket typeOfTicket, string from, string to, DateTime departure, DateTime arrivingTime)
        {
            PlaneID = planeId;
            FlightID = flightId;
            Price = price;
            TypeOfTicket = typeOfTicket;
            From = from;
            To = to;
            DepartureTime = departure;
            ArrivingTime = arrivingTime;
        }

        public static bool operator ==(Ticket firstTicket, Ticket secondTicket)
        {
            if (ReferenceEquals(firstTicket, null) && ReferenceEquals(secondTicket, null))
                return true;
            

            // Check if either ticket is null
            if (ReferenceEquals(firstTicket, null) || ReferenceEquals(secondTicket, null))
            
                return false;
            

            return firstTicket.PlaneID == secondTicket.PlaneID &&
                   firstTicket.FlightID == secondTicket.FlightID &&
                   firstTicket.Price == secondTicket.Price &&
                   firstTicket.TypeOfTicket == secondTicket.TypeOfTicket &&
                   firstTicket.From == secondTicket.From &&
                   firstTicket.To == secondTicket.To &&
                   firstTicket.DepartureTime == secondTicket.DepartureTime &&
                   firstTicket.ArrivingTime == secondTicket.ArrivingTime;
        }

        public static bool operator !=(Ticket ticket1, Ticket ticket2)
        {
            return !(ticket1 == ticket2);
        }
    }
}
