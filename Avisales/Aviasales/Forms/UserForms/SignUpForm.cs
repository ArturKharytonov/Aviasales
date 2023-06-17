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

namespace Aviasales
{
    public partial class SignUpForm : Form
    {
        private Airport _airport;
        public SignUpForm(Airport airport)
        {
            InitializeComponent();
            _airport = airport;
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxName.Text) &&
                !string.IsNullOrWhiteSpace(textBoxSurname.Text) &&
                !string.IsNullOrWhiteSpace(textBoxLogin.Text) &&
                !string.IsNullOrWhiteSpace(textBoxPassword.Text) &&
                numericUpDownAge.Value >= 16 && numericUpDownAge.Value <= 80)
            {
                if (IsWrittenProperly(textBoxLogin.Text) &&
                    IsWrittenProperly(textBoxPassword.Text))
                {
                    if (!_airport.DoesUserWithLoginExist(textBoxLogin.Text))
                    {
                        _airport.Users.Add(new Customer(textBoxName.Text, textBoxSurname.Text, (int)numericUpDownAge.Value, textBoxLogin.Text, textBoxPassword.Text));
                        MessageBox.Show("You have successfully created an account!", "Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Close();
                    }
                    else
                        MessageBox.Show("User with that login already exist", "Incorrect input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Set login and password properly", "Incorrect input", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else
                MessageBox.Show("Form must be filled in. Age must be more than 16 and less ", "Incorrect input", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private bool IsWrittenProperly(string field)
        {
            for (int i = 0; i < field.Length; i++)
            {
                if (field[i] <= 32 || field[i] >= 127)
                    return false;
            }

            return true;
        }
    }
}
