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
    public partial class CancelTickets : Form
    {
        private Airport _airport;
        private User _user;
        public CancelTickets(Airport airport)
        {
            InitializeComponent();
            _airport = airport;
        }

        private void UpdateList()
        {
            for (int i = 0; i < ((Customer)_user).CustomerTickets.Count; i++)
            {
                listBox1.Items.Add($"Plane ID: {((Customer)_user).CustomerTickets[i].PlaneID}." +
                                   $"Flight ID: {((Customer)_user).CustomerTickets[i].FlightID}." +
                                   $"From: {((Customer)_user).CustomerTickets[i].From}." +
                                   $"To: {((Customer)_user).CustomerTickets[i].To}." +
                                   $"Start: {((Customer)_user).CustomerTickets[i].DepartureTime}." +
                                   $"End: {((Customer)_user).CustomerTickets[i].ArrivingTime}");
            }
        }

        private void btnShowTickets_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox1.Text))
            {
                listBox1.Items.Clear();
                _user = _airport.GetUser(textBox1.Text);
                if (_user != null && _user.GetType() == typeof(Customer))
                {
                    UpdateList();
                }
                else
                    MessageBox.Show("Customer with that login doesn't exist.", "Notification",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                Flight currentFlight = _airport.GetFlight(
                    ((Customer)_user).CustomerTickets[listBox1.SelectedIndex].PlaneID,
                    ((Customer)_user).CustomerTickets[listBox1.SelectedIndex].FlightID);
                if (currentFlight != null)
                {
                    switch (((Customer)_user).CustomerTickets[listBox1.SelectedIndex].TypeOfTicket)
                    {
                        case TypeOfTicket.Economy:
                        {
                            currentFlight.CountOfEachTicket[0] += 1;
                            ((Customer)_user).Balance += currentFlight.PriceOfEachTicket[0];
                        } 
                            break;
                        case TypeOfTicket.PremiumEconomy:
                        {
                            currentFlight.CountOfEachTicket[1] += 1;
                            ((Customer)_user).Balance += currentFlight.PriceOfEachTicket[1];
                        }
                            break;
                        case TypeOfTicket.Business:
                        {
                            currentFlight.CountOfEachTicket[2] += 1;
                            ((Customer)_user).Balance += currentFlight.PriceOfEachTicket[2];
                        }
                            break;
                    }
                    ((Customer)_user).CustomerTickets.RemoveAt(listBox1.SelectedIndex);
                    Airport.SaveAirport(_airport);
                    UpdateList();
                    MessageBox.Show("Ticket was successfully deleted", "Notification",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
                MessageBox.Show("Choose customer's ticket in list", "Notification",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
