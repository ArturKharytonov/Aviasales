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
    public partial class ShowTickets : Form
    {
        private Customer _customer;
        private Airport _airport;
        public ShowTickets(Customer customer, Airport airport)
        {
            InitializeComponent();
            _customer = customer;
            _airport = airport;
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            if (radioButton1.Checked)
            {
                foreach (var t in _customer.CustomerTickets)
                {
                    listBox1.Items.Add($"Plane ID - {t.PlaneID}. " +
                                       $"Flight ID - {t.FlightID}. " +
                                       $"Price - {t.Price}. " +
                                       $"From - {t.From}. " +
                                       $"To - {t.To}. " +
                                       $"Departure time - {t.DepartureTime}." +
                                       $"End time - {t.ArrivingTime}");
                }
            }
            else
            {
                foreach (var t in _customer.CustomerTickets.Where(t => t.DepartureTime >= DateTime.Now))
                {
                    listBox1.Items.Add($"Plane ID - {t.PlaneID}. " +
                                       $"Flight ID - {t.FlightID}. " +
                                       $"Price - {t.Price}. " +
                                       $"From - {t.From}. " +
                                       $"To - {t.To}. " +
                                       $"Departure time - {t.DepartureTime}." +
                                       $"End time - {t.ArrivingTime}");
                }
            }
        }
    }
}
