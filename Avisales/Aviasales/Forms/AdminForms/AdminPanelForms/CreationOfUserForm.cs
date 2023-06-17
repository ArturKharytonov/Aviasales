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
    public partial class CreationOfUserForm : Form
    {
        private Airport _airport;
        public CreationOfUserForm(Airport airport)
        {
            InitializeComponent();
            _airport = airport;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!_airport.DoesUserWithLoginExist(textBoxLogin.Text))
            {
                if (!string.IsNullOrEmpty(textBoxName.Text) &&
                    !string.IsNullOrEmpty(textBoxSurname.Text) &&
                    !string.IsNullOrEmpty(textBoxLogin.Text) &&
                    !string.IsNullOrEmpty(textBoxPassword.Text) &&
                    (int)numericUpDownAge.Value >= 16)
                {
                    if (checkBoxIsAdmin.Checked)
                        _airport.Users.Add(new Admin(textBoxName.Text, textBoxSurname.Text, (int)numericUpDownAge.Value,
                            textBoxLogin.Text,
                            textBoxPassword.Text));
                    else _airport.Users.Add(new Customer(textBoxName.Text, textBoxSurname.Text, (int)numericUpDownAge.Value, textBoxLogin.Text,
                        textBoxPassword.Text));

                    Airport.SaveAirport(_airport);
                    MessageBox.Show("You have created a user.", "Notification",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
                MessageBox.Show("User with that login already exist", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
