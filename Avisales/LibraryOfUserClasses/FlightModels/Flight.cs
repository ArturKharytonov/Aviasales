using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace LibraryOfUserClasses.FlightModels
{
    public class Flight
    {
        [JsonProperty("Plane id: ")]
        public int PlaneID { get; set; }

        [JsonProperty("Flight id: ")]
        public int ID { get; set; }

        [JsonProperty("From: ")]
        public string From { get; set; }

        [JsonProperty("To: ")]
        public string To { get; set; }

        [JsonProperty("Departure time: ")]
        public DateTime DepartureTime { get; set; }

        [JsonProperty("Arriving time: ")] 
        public DateTime ArrivingTime { get; set; }

        [JsonProperty("Count: ")]
        public int[] CountOfEachTicket { get; set; }

        [JsonProperty("Price: ")]
        public double[] PriceOfEachTicket { get; set; }

        
        public Flight(int planeId,int id,string from, string to, DateTime departureTime,DateTime arrivingTime ,int[] countOfEachTicket, double[] priceOfEachTicket)
        {
            PlaneID = planeId;
            ID = id;
            From = from;
            To = to;
            DepartureTime = departureTime;
            ArrivingTime = arrivingTime;    
            CountOfEachTicket = countOfEachTicket;
            PriceOfEachTicket = priceOfEachTicket;
        }

        public double GetMinPriceOfTicket()
        {
            if(CountOfEachTicket[0] > 0)
                return PriceOfEachTicket[0];
            if (CountOfEachTicket[1] > 0)
                return PriceOfEachTicket[1];
            if (CountOfEachTicket[2] > 0)
                return PriceOfEachTicket[2];
            return -1;
        }
    }
}
