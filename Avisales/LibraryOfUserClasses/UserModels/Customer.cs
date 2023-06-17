using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryOfUserClasses.FlightModels;
using  Newtonsoft.Json;

namespace LibraryOfUserClasses
{
    public class Customer : User
    {
        [JsonProperty("Balance: ")]
        public double Balance { get; set; }

        [JsonProperty("All tickets: ")]
        public List<Ticket> CustomerTickets { get; set; }

        public Customer()
        {
            
        }
        public Customer(string name, string surname, int age, string login, string password) : base(name, surname, age, login, password)
        {
            Balance = 0;
            CustomerTickets = new List<Ticket>();
        }
    }
}
