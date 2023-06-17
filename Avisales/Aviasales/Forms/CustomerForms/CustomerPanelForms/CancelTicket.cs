using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryOfUserClasses;
using LibraryOfUserClasses.FlightModels;

namespace Aviasales.Forms.CustomerForms.CustomerPanelForms
{
    public partial class CancelTicket : Form
    {
        private Airport _airport;
        private Customer _customer;
        private List<Ticket> activeTickets;
        public CancelTicket(Airport airport, Customer customer)
        {
            InitializeComponent();
            _airport = airport;
            _customer = customer;

            PrintTickets();
        }

        private void PrintTickets()
        {
            activeTickets = new List<Ticket>();
            listBox1.Items.Clear();
            if (_customer.CustomerTickets.Count > 0)
            {
                foreach (var ticket in _customer.CustomerTickets)
                {
                    if (ticket.DepartureTime > DateTime.Now)
                    {
                        activeTickets.Add(ticket);
                        listBox1.Items.Add($"Plane ID - {ticket.PlaneID}. " +
                                           $"Flight ID - {ticket.FlightID}. " +
                                           $"Price - {ticket.Price}. " +
                                           $"From - {ticket.From}. " +
                                           $"To - {ticket.To}. " +
                                           $"Departure time - {ticket.DepartureTime}." +
                                           $"End time - {ticket.ArrivingTime}");
                    }
                }
            }
        }
        private void btnDelete_Click(object sender, EventArgs e) 
        {
            if (listBox1.SelectedIndex >= 0)
            {
                Flight flight = _airport.GetFlight(activeTickets[listBox1.SelectedIndex].PlaneID,
                    activeTickets[listBox1.SelectedIndex].FlightID);
                switch (activeTickets[listBox1.SelectedIndex].TypeOfTicket)
                {
                    case TypeOfTicket.Economy:
                    {
                        flight.CountOfEachTicket[0]++;
                        _customer.Balance += flight.PriceOfEachTicket[0];
                        _airport.PlusMoney(_customer.Login, _customer.Password, flight.PriceOfEachTicket[0]);
                    }
                        break;
                    case TypeOfTicket.PremiumEconomy:
                    {
                        flight.CountOfEachTicket[1]++;
                        _customer.Balance += flight.PriceOfEachTicket[1];
                        _airport.PlusMoney(_customer.Login, _customer.Password, flight.PriceOfEachTicket[1]);

                    }
                        break;
                    case TypeOfTicket.Business:
                    {
                        flight.CountOfEachTicket[2]++;
                        _customer.Balance += flight.PriceOfEachTicket[2];
                        _airport.PlusMoney(_customer.Login, _customer.Password, flight.PriceOfEachTicket[2]);
                    }
                        break;
                }
                _customer.CustomerTickets.Remove(activeTickets[listBox1.SelectedIndex]);

                _airport.RemoveTicketFromCustomer(_customer.Login, _customer.Password, activeTickets[listBox1.SelectedIndex]);

                MessageBox.Show("Ticket was successfully canceled", "Notification",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);

                PrintTickets();
                Airport.SaveAirport(_airport);
            }
            else
                MessageBox.Show("Choose ticket in list.", "Notification",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
