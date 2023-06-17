using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryOfUserClasses.FlightModels;

namespace Aviasales.Forms.AdminForms.AdminPanelForms
{
    public partial class EndedFlightsForm : Form
    {
        private Airport _airport;
        public EndedFlightsForm(Airport airport)
        {
            InitializeComponent();
            _airport = airport;

            bool wasFound = false;

            foreach (var plane in _airport.Planes.Where(plane => plane.DoesPlainHasEndedFlights()))
            {
                wasFound = true;
                listBoxInfo.Items.Add($"Plane ID: {plane.Id}");
                foreach (var flight in plane.Flights.Where(flight => flight.DepartureTime < DateTime.Now))
                {
                    listBoxInfo.Items.Add($"\tFlight ID: {flight.ID}." +
                                          $" From - {flight.From} : Destination - {flight.To}." +
                                          $" Departure time: {flight.DepartureTime}");
                }
            }
            if(!wasFound)
                listBoxInfo.Items.Add("Ended flights were not found.");
        }
    }
}
