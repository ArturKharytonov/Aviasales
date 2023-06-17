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
    public partial class EditFlightNestedForm : Form
    {
        private Airport _airport;
        private Flight _currentFlight;
        private List<Flight> _acitiveFlights;
        private int _index;
        public EditFlightNestedForm(Airport airport, Flight flight, int index, List<Flight> activeFlights)
        {
            InitializeComponent();
            _airport = airport;
            _currentFlight = flight;
            _index = index;
            _acitiveFlights = activeFlights;

            dateTimePicker.Format = DateTimePickerFormat.Custom;
            dateTimePicker.CustomFormat = "dd/MM/yyyy HH:mm";
            

            dateTimePickerArriving.Format = DateTimePickerFormat.Custom;
            dateTimePickerArriving.CustomFormat = "dd/MM/yyyy HH:mm";
            

            ResetData();
        }

        private void ResetData()
        {
            numericUpDownIdFlight.Value = _currentFlight.ID;
            textBox1.Text = _currentFlight.From;
            textBox2.Text = _currentFlight.To;
            dateTimePicker.Value = _currentFlight.DepartureTime;
            dateTimePickerArriving.Value = _currentFlight.ArrivingTime;
        }
        private bool DoesFlightWithIdExist()
        {
            return _acitiveFlights.Where((t, i) => i != _index && t.ID == (int)numericUpDownIdFlight.Value).Any();
        } // not include flight under current index

        private bool CompareTicketWithFlight(Ticket firstTicket, Flight flight)
        {
            return firstTicket.PlaneID == flight.PlaneID &&
                   firstTicket.FlightID == flight.ID &&
                   firstTicket.From == flight.From &&
                   firstTicket.To == flight.To &&
                   firstTicket.DepartureTime == flight.DepartureTime &&
                   firstTicket.ArrivingTime == flight.ArrivingTime;
        }
        private void ChangeValuesForFlight()
        {
            // change data of tickets in users lists
            for (int i = 0; i < _airport.Users.Count; i++)
            {
                if (_airport.Users[i].GetType() == typeof(Customer))
                {
                    for (int j = 0; j < ((Customer)_airport.Users[i]).CustomerTickets.Count; j++)
                    {
                        if (CompareTicketWithFlight(((Customer)_airport.Users[i]).CustomerTickets[j], _currentFlight))
                        {
                            ((Customer)_airport.Users[i]).CustomerTickets[j].FlightID = (int)numericUpDownIdFlight.Value;
                            ((Customer)_airport.Users[i]).CustomerTickets[j].From = textBox1.Text;
                            ((Customer)_airport.Users[i]).CustomerTickets[j].To = textBox2.Text;
                            ((Customer)_airport.Users[i]).CustomerTickets[j].DepartureTime = dateTimePicker.Value;
                            ((Customer)_airport.Users[i]).CustomerTickets[j].ArrivingTime =
                                dateTimePickerArriving.Value;
                        }
                    }
                }
            }
            _currentFlight.ID = (int)numericUpDownIdFlight.Value;
            _currentFlight.From = textBox1.Text;
            _currentFlight.To = textBox2.Text;
            _currentFlight.DepartureTime = dateTimePicker.Value;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text) &&
                !string.IsNullOrWhiteSpace(textBox2.Text) && 
                !DoesFlightWithIdExist())
            {
                if (dateTimePicker.Value > DateTime.Now && dateTimePicker.Value < dateTimePickerArriving.Value)
                {
                    ChangeValuesForFlight();
                    Airport.SaveAirport(_airport);
                    MessageBox.Show("Flight was successfully edited", "Notification", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    Close();
                }
                else MessageBox.Show("Add FUTURE dates", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else MessageBox.Show("Fill in or maybe index of flight already exist", "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetData();
        }
    }
}
