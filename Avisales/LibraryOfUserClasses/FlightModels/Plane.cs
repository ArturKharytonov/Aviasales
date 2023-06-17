using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LibraryOfUserClasses.FlightModels
{
    public class Plane
    {
        [JsonProperty("ID: ")]
        public int Id { get; set; }

        [JsonProperty("Name: ")]
        public string Name { get; set; }

        [JsonProperty("Flights: ")]
        public List<Flight> Flights { get; set; }

        public Plane(int id, string name)
        {
            Id = id;
            Name = name;
            Flights = new List<Flight>();
        }

        public bool DoesFlightExist(int id)
            => Flights.Any(flight => flight.ID == id);

        public bool DoesPlainHasEndedFlights()
            => Flights.Any(flight => flight.DepartureTime < DateTime.Now);

    }
}
