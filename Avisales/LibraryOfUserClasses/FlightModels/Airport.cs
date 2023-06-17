using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LibraryOfUserClasses.FlightModels
{
    public class Airport
    {
        [JsonProperty("Name of airport: ")]
        public string Name { get; set; }

        [JsonProperty("Planes: ")]
        public List<Plane> Planes { get; set; }

        [JsonProperty("Users: ")]
        public List<User> Users { get; set; }
        

        public Airport()
        {
            Name = "Aviasales";
            Planes = new List<Plane>();
            Users = new List<User>();
        }

        public static void SaveAirport(Airport airport)
        {
            JsonSerializerSettings settings = new JsonSerializerSettings();
            settings.TypeNameHandling = TypeNameHandling.All;
            string json = JsonConvert.SerializeObject(airport, settings);
            using (Stream stream = new FileStream("aviasales.json", FileMode.Create))
            {
                using (StreamWriter writer = new StreamWriter(stream, Encoding.UTF8))
                {
                    writer.Write(json);
                }
            }
        }

        public static string LoadAirport()
        {
            if (File.Exists("aviasales.json"))
            {
                string txt = "";
                using (Stream stream = new FileStream("aviasales.json", FileMode.Open))
                {
                    using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
                    {
                        while (!reader.EndOfStream)
                        {
                            txt += reader.ReadLine() + "\n";
                        }
                    }
                }
                return txt;
            }
            return "";
        }

        public bool DoesUserWithLoginExist(string login)
            => Users.Count > 0 && Users.Any(user => user.Login == login);

        public bool DoesPlaneWithThatIdExist(int id) 
            => Planes.Count > 0 && Planes.Any(plane => plane.Id == id);

        public bool DoesFlightWithCurrentIndexExist(int idOfPlane, int id) 
            => Planes.Any(plane => plane.Id == idOfPlane && plane.DoesFlightExist(id));

        public Plane GetCurrentPlane(int idOfPlane) 
            => Planes.FirstOrDefault(plane => plane.Id == idOfPlane);

        public User GetUser(string login)
            => Users.FirstOrDefault(user => user.Login == login);

        public Flight GetFlight(int planeId, int flightId)
        {
            if (Planes.Count > 0)
            {
                foreach (var plane in Planes)
                {
                    if (plane.Id == planeId && plane.Flights.Count > 0)
                    {
                        foreach (var flight in plane.Flights)
                        {
                            if (flight.ID == flightId)
                                return flight;
                        }
                    }
                }
            }
            return null;
        }
        
        public void MinusMoneyForTicket(string login, string password, double sum)
        {
            foreach (var user in Users.Where(user => user.GetType() == typeof(Customer) && user.Login == login && user.Password == password))
                ((Customer)user).Balance -= sum;
        }

        public void PlusMoney(string login, string password, double sum)
        {
            foreach (var user in Users.Where(user => user.GetType() == typeof(Customer) && user.Login == login && user.Password == password))
                ((Customer)user).Balance += sum;
        }

        public void AddTicketForCurrentCustomer(string login, string password, Ticket ticket)
        {
            foreach (var user in Users.Where(user => user.GetType() == typeof(Customer) && user.Login == login && user.Password == password))
                ((Customer)user).CustomerTickets.Add(ticket);
        }

        public void RemoveTicketFromCustomer(string login, string password, Ticket ticket)
        {
            foreach (var user in Users.Where(user =>
                         user.GetType() == typeof(Customer) && user.Login == login && user.Password == password))
            {
                for (int i = 0; i < ((Customer)user).CustomerTickets.Count; i++)
                {
                    if(((Customer)user).CustomerTickets[i] == ticket)
                        ((Customer)user).CustomerTickets.RemoveAt(i);
                }
            }
        }

        public void SetValueForCurrentUser(User user)
        {
            for (int i = 0; i < Users.Count; i++)
            {
                if (Users[i].Login == user.Login)
                    Users[i] = user;
            }
        }
    }
}
