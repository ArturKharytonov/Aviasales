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
    
    public partial class AddPlaneForm : Form
    {
        private Airport _airport;
        public AddPlaneForm(Airport airport)
        {
            InitializeComponent();
            _airport = airport;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!_airport.DoesPlaneWithThatIdExist((int)numericUpDownIndex.Value) && !string.IsNullOrWhiteSpace(textBox1.Text.Trim()))
            {
                _airport.Planes.Add(new Plane((int)numericUpDownIndex.Value, textBox1.Text));
                
                Airport.SaveAirport(_airport);
                MessageBox.Show("Plane was successfully added.", "Plane", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Plane with that index already exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
