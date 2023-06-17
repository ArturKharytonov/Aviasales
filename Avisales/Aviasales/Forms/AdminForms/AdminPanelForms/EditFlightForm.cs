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
    public partial class EditFlightForm : Form
    {
        private Airport _airport;
        private List<Flight> _activeFlights;
        private Plane _plane;
        public EditFlightForm(Airport airport)
        {
            InitializeComponent();
            _airport = airport;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            _activeFlights = new List<Flight>();
            _plane = _airport.GetCurrentPlane((int)numericUpDownIndex.Value);
            if (_plane != null && _plane.Flights.Count > 0)
            {
                for (int i = 0; i < _plane.Flights.Count; i++)
                {
                    if (_plane.Flights[i].DepartureTime > DateTime.Now)
                    {
                        _activeFlights.Add(_plane.Flights[i]);
                        listBox1.Items.Add($"Flight's ID: {_plane.Flights[i].ID}." +
                                           $"From: {_plane.Flights[i].From} | " +
                                           $"To: {_plane.Flights[i].To}." +
                                           $"Departure time: {_plane.Flights[i].DepartureTime}.");
                    }
                }
                return;
            }

            MessageBox.Show("Empty list of flights or plane with that index doesn't exsist.", "Notification",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnChooseFlight_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                EditFlightNestedForm editFlight =
                    new EditFlightNestedForm(_airport, _activeFlights[listBox1.SelectedIndex], listBox1.SelectedIndex, _activeFlights);
                editFlight.ShowDialog();

                return;
            }

            MessageBox.Show("Choose flight!", "Notification",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
