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

namespace Aviasales.Forms.CustomerForms.FiltrationForms
{
    public partial class TicketsFiltrationForm : Form
    {
        private Airport _airport;
        private Flight _chosenFlight;
        private Customer _customer;
        public TicketsFiltrationForm(Flight flight, Customer customer, Airport airport)
        {
            InitializeComponent();
            _chosenFlight = flight;
            _customer = customer;
            _airport = airport;
            FillData();

        }

        private void FillData()
        {
            lbPrEconom.Text = "Price econom:" + _chosenFlight.PriceOfEachTicket[0];
            lbPrPremiumEconom.Text = "Price preminum econom:" + _chosenFlight.PriceOfEachTicket[1];
            lbPrBusiness.Text = "Price business:" + _chosenFlight.PriceOfEachTicket[2];

            label1.Text = "Count:" + _chosenFlight.CountOfEachTicket[0];
            label2.Text = "Count:" + _chosenFlight.CountOfEachTicket[1];
            label3.Text = "Count:" + _chosenFlight.CountOfEachTicket[2];

        }

        private double GetPrice()
            => (double)numericUpDown1.Value * _chosenFlight.PriceOfEachTicket[0] +
               (double)numericUpDown2.Value * _chosenFlight.PriceOfEachTicket[1] +
               (double)numericUpDown3.Value * _chosenFlight.PriceOfEachTicket[2];

        private void FillTickets(int count, Ticket ticket)
        {
            for (int i = 0; i < count; i++)
            {
                _customer.CustomerTickets.Add(ticket);
                _airport.AddTicketForCurrentCustomer(_customer.Login, _customer.Password, ticket);
            }
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value <= _chosenFlight.CountOfEachTicket[0] &&
                numericUpDown2.Value <= _chosenFlight.CountOfEachTicket[1] &&
                numericUpDown3.Value <= _chosenFlight.CountOfEachTicket[2] &&
                _customer.Balance >= GetPrice())
            {
                _customer.Balance -= GetPrice();
                _airport.MinusMoneyForTicket(_customer.Login, _customer.Password, GetPrice());


                _chosenFlight.CountOfEachTicket[0] -= (int)numericUpDown1.Value;
                _chosenFlight.CountOfEachTicket[1] -= (int)numericUpDown2.Value;
                _chosenFlight.CountOfEachTicket[2] -= (int)numericUpDown3.Value;

                FillTickets((int)numericUpDown1.Value, new Ticket(_chosenFlight.PlaneID, _chosenFlight.ID, _chosenFlight.PriceOfEachTicket[0],
                    TypeOfTicket.Economy, _chosenFlight.From, _chosenFlight.To, _chosenFlight.DepartureTime, _chosenFlight.ArrivingTime));

                FillTickets((int)numericUpDown2.Value, new Ticket(_chosenFlight.PlaneID, _chosenFlight.ID, _chosenFlight.PriceOfEachTicket[1],
                    TypeOfTicket.PremiumEconomy, _chosenFlight.From, _chosenFlight.To, _chosenFlight.DepartureTime, _chosenFlight.ArrivingTime));

                FillTickets((int)numericUpDown3.Value, new Ticket(_chosenFlight.PlaneID, _chosenFlight.ID, _chosenFlight.PriceOfEachTicket[2],
                    TypeOfTicket.PremiumEconomy, _chosenFlight.From, _chosenFlight.To, _chosenFlight.DepartureTime, _chosenFlight.ArrivingTime));


                Airport.SaveAirport(_airport);
                MessageBox.Show("Tickets were successfully bought.", "Notification", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                FillData();
                return;
            }

            MessageBox.Show("Smth went wrong.", "Notification", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
        }
    }
}
