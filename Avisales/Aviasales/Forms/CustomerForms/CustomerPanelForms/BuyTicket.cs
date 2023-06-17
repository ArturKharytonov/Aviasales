using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aviasales.Forms.CustomerForms.FiltrationForms;
using LibraryOfUserClasses;
using LibraryOfUserClasses.FlightModels;

namespace Aviasales.Forms.CustomerForms.CustomerPanelForms
{
    public partial class BuyTicket : Form
    {
        private Airport _airport;
        private Customer _customer;
        private List<Flight> _filteredFlights;

        private bool _wasDatesAndTimesLocked = true;
        private bool _wasDestinationLocked = true;

        private string _from;
        private string _to;
        private double _minPrice;
        private double _maxPrice;

        private DateTime _dateFrom = DateTime.Now;
        private DateTime _dateTo = DateTime.Now;

        public BuyTicket(Airport airport, Customer customer)
        {
            InitializeComponent();
            _airport = airport;
            _customer = customer;

            UpdateData();
        }

        public bool DoesInFlightEnoughTicketsAndActualDate(Flight flight)
        {
            return flight.CountOfEachTicket[0] + flight.CountOfEachTicket[1] + flight.CountOfEachTicket[2] > 0 && flight.DepartureTime >= DateTime.Now;
        }
        public void UpdateData()
        {
            listBox1.Items.Clear();
            _filteredFlights = new List<Flight>();

            for (int i = 0; i < _airport.Planes.Count; i++)
            {
                for (int j = 0; j < _airport.Planes[i].Flights.Count; j++)
                {
                    if (!_wasDatesAndTimesLocked && DoesInFlightEnoughTicketsAndActualDate(_airport.Planes[i].Flights[j]))
                    {
                        if (_airport.Planes[i].Flights[j].DepartureTime >= _dateFrom &&
                            _airport.Planes[i].Flights[j].DepartureTime <= _dateTo)
                        {
                            if (!_wasDestinationLocked)
                            {
                                if (!string.IsNullOrEmpty(_from) &&
                                    _airport.Planes[i].Flights[j].From.Contains(_from) &&
                                    !string.IsNullOrEmpty(_to) && _airport.Planes[i].Flights[j].To.Contains(_to) &&
                                    _airport.Planes[i].Flights[j].GetMinPriceOfTicket() >= _minPrice &&
                                    _airport.Planes[i].Flights[j].GetMinPriceOfTicket() <= _maxPrice)
                                {
                                    listBox1.Items.Add($"ID of plane - {_airport.Planes[i].Id}. " +
                                                       $"Id of flight = {_airport.Planes[i].Flights[j].ID}. " +
                                                       $"From - {_airport.Planes[i].Flights[j].From} : To - {_airport.Planes[i].Flights[j].To}. " +
                                                       $"Departure time: {_airport.Planes[i].Flights[j].DepartureTime}.End time: {_airport.Planes[i].Flights[j].ArrivingTime}");
                                    _filteredFlights.Add(_airport.Planes[i].Flights[j]);
                                }
                            }
                            else
                            { 
                                listBox1.Items.Add($"ID of plane - {_airport.Planes[i].Id}. " +
                                                    $"Id of flight = {_airport.Planes[i].Flights[j].ID}. " +
                                                    $"From - {_airport.Planes[i].Flights[j].From} : To - {_airport.Planes[i].Flights[j].To}. " +
                                                    $"Departure time: {_airport.Planes[i].Flights[j].DepartureTime}.End time: {_airport.Planes[i].Flights[j].ArrivingTime}");
                                _filteredFlights.Add(_airport.Planes[i].Flights[j]);
                            }
                        }
                    }
                    else if(DoesInFlightEnoughTicketsAndActualDate(_airport.Planes[i].Flights[j]))
                    {
                        listBox1.Items.Add($"ID of plane - {_airport.Planes[i].Id}. " +
                                            $"Id of flight = {_airport.Planes[i].Flights[j].ID}. " +
                                            $"From - {_airport.Planes[i].Flights[j].From} : To - {_airport.Planes[i].Flights[j].To}. " +
                                            $"Departure time: {_airport.Planes[i].Flights[j].DepartureTime}.End time: {_airport.Planes[i].Flights[j].ArrivingTime}");
                        _filteredFlights.Add(_airport.Planes[i].Flights[j]);
                    }
                }
            }
        }

        private void menuItem_Click(object sender, EventArgs e)
        {
            switch (((ToolStripMenuItem)sender).Text)
            {
                case "Date and time":
                {
                    DateAndHourFiltration dateAndHour = new DateAndHourFiltration();
                    var res = dateAndHour.ShowDateAndHourFiltration();
                    _dateFrom = res.Item1;
                    _dateTo = res.Item2;
                    _wasDatesAndTimesLocked = res.Item3;
                    UpdateData();
                }
                    break;
                case "Destinations":
                {
                    DestinationsAndPricesForm destinationsForm = new DestinationsAndPricesForm();
                    var res = destinationsForm.ShowDestinationsAndPrices(); // write bool variable else
                    _from = res.from;
                    _to = res.to;
                    _minPrice = res.minPrice;
                    _maxPrice = res.maxPrice;
                    _wasDestinationLocked = res.wasLocked;
                    UpdateData();
                } 
                    break;
            }
        }

        private void btnChoose_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                Flight chosenFlight = _filteredFlights[listBox1.SelectedIndex];
                TicketsFiltrationForm ticketsFiltration = new TicketsFiltrationForm(chosenFlight, _customer, _airport);
                ticketsFiltration.ShowDialog();

                UpdateData();
            }
            else MessageBox.Show("Choose flight", "Notification",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
