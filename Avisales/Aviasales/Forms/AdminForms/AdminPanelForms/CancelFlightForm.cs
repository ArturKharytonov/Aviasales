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

namespace Aviasales.Forms.AdminForms.AdminPanelForms
{
    public partial class CancelFlightForm : Form
    {
        private Airport _airport;
        private Plane _currentPlane;
        public CancelFlightForm(Airport airport)
        {
            InitializeComponent();
            _airport = airport;
        }

        private void btnShowFlights_Click(object sender, EventArgs e)
        {
            if (_airport.DoesPlaneWithThatIdExist((int)numericUpDownIndex.Value))
            {
                listBox1.Items.Clear();

                _currentPlane = _airport.GetCurrentPlane((int)numericUpDownIndex.Value);

                foreach (var flight in _currentPlane.Flights)
                {
                    listBox1.Items.Add($"Flight ID: {flight.ID}." +
                                       $" From - {flight.From} : Destination - {flight.To}." +
                                       $" \nDeparture time: {flight.DepartureTime}");
                }
            }
            else MessageBox.Show("Plane with that index doesn't exist", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                foreach (var user in _airport.Users)
                {
                    if (user.GetType() == typeof(Customer))
                    {
                        foreach (var ticket in ((Customer)user).CustomerTickets.Where(ticket => ticket.PlaneID == _currentPlane.Id && ticket.FlightID == listBox1.SelectedIndex))
                        {
                            ((Customer)user).Balance += ticket.Price;
                            ((Customer)user).CustomerTickets.Remove(ticket);
                        }
                    }
                }

                _currentPlane.Flights.RemoveAt(listBox1.SelectedIndex);
                Airport.SaveAirport(_airport);

                listBox1.Items.Clear();
                MessageBox.Show("You have canceled current flight", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Went wrong!", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
