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

namespace Aviasales.Forms
{
    public partial class Settings : Form
    {
        private User _currentUser;
        private Airport _airport;
        public Settings(User user, Airport airport)
        {
            InitializeComponent();
            _currentUser = user;
            _airport = airport;

            textBoxName.Text = _currentUser.Name;
            textBoxSurname.Text = _currentUser.Surname;
            numericUpDownAge.Value = _currentUser.Age;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxName.Text.Trim()) &&
                !string.IsNullOrWhiteSpace(textBoxSurname.Text.Trim()) &&
                numericUpDownAge.Value >= 16 && numericUpDownAge.Value <= 80 &&
                IsWrittenProperly(textBoxNewPassword.Text))
            {
                _currentUser.Name = textBoxName.Text;
                _currentUser.Surname = textBoxSurname.Text;
                _currentUser.Age = (int)numericUpDownAge.Value;



                if (textBoxPassword.Text.Equals(_currentUser.Password))
                    _currentUser.Password = textBoxNewPassword.Text;
                else if(!string.IsNullOrWhiteSpace(textBoxPassword.Text) &&
                        !string.IsNullOrWhiteSpace(textBoxNewPassword.Text))
                    MessageBox.Show("You have inputed old password incorrectly", "Incorrect input", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
                _airport.SetValueForCurrentUser(_currentUser);

                Close();
            }
            else
                MessageBox.Show("Name and surname can not be empty and age must be more than 18 and less than 80", "Incorrect input", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
