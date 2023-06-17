using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibraryOfUserClasses.FlightModels;

namespace Aviasales.Forms.AdminForms.AdminPanelForms
{
    public partial class AddFlightForm : Form
    {
        private Airport _airport;
        public AddFlightForm(Airport airport)
        {
            InitializeComponent();
            _airport = airport;

            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "dd/MM/yyyy HH:mm";
            dateTimePicker1.Value = DateTime.Now;

            dateTimePicker2.Format = DateTimePickerFormat.Custom;
            dateTimePicker2.CustomFormat = "dd/MM/yyyy HH:mm";
            dateTimePicker2.Value = DateTime.Now;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (_airport.DoesPlaneWithThatIdExist((int)numericUpDownIndex.Value))
            {
                if (!_airport.DoesFlightWithCurrentIndexExist((int)numericUpDownIndex.Value, (int)numericUpDownIdFlight.Value))
                {
                    if (!string.IsNullOrWhiteSpace(textBox1.Text.Trim()) &&
                        !string.IsNullOrWhiteSpace(textBox2.Text.Trim()) &&
                        dateTimePicker1.Value >= DateTime.Today && dateTimePicker1.Value < dateTimePicker2.Value)
                    {
                        if ((numericBusiness.Value > 0 ||
                            numericEconomy.Value > 0 ||
                            numericPremiumEconomy.Value > 0) &&
                            numericPriceEconom.Value > 0 && numericPricePremiumEc.Value > 0 &&
                            numericPriceBusiness.Value > 0)
                        {
                            try
                            {
                                Plane plane = _airport.GetCurrentPlane((int)numericUpDownIndex.Value);
                                if (plane != null)
                                {
                                    plane.Flights.Add(new Flight(plane.Id,
                                        (int)numericUpDownIdFlight.Value, textBox1.Text, textBox2.Text, dateTimePicker1.Value,dateTimePicker2.Value,
                                        new[] { (int)numericEconomy.Value, (int)numericPremiumEconomy.Value, (int)numericBusiness.Value },
                                        new[] { (double)numericPriceEconom.Value, (double)numericPricePremiumEc.Value, (double)numericPriceBusiness.Value }));


                                    Airport.SaveAirport(_airport);
                                    MessageBox.Show("Flight was successfully added.", "Flight",
                                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                    MessageBox.Show("Add FUTURE dates", "Error",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            catch (Exception exception)
                            {
                                MessageBox.Show("Dude it is not serious...\nFormat of input has to be: HH:mm dd-MM-yyyy.", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                        else MessageBox.Show("Add tickets and prices for them -_-", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                        MessageBox.Show("Cmon input everything properly", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                    MessageBox.Show("Flight with that index already exist.", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
                MessageBox.Show("Plane with that index doesn't exist.", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
