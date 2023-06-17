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
    public partial class ReplenishMoneyForm : Form
    {
        private Customer _customer;
        private Airport _airport;
        public ReplenishMoneyForm(Airport airport, Customer customer)
        {
            InitializeComponent();
            _airport = airport;
            _customer = customer;
        }
        private void btnDeposit_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value > 10 && _customer.Balance <= int.MaxValue)
            {
                _customer.Balance += (double)numericUpDown1.Value;
                _airport.PlusMoney(_customer.Login, _customer.Password, (double)numericUpDown1.Value);
                Airport.SaveAirport(_airport);
                MessageBox.Show("You have successfully replenished money", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Sum of deposit has to be more than 10 bucks", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
