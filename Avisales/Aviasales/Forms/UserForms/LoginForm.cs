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
using Newtonsoft.Json;

namespace Aviasales
{
    public partial class LoginForm : Form
    {
        private bool _passwordOpen = true;
        private Airport _airport { get; set; }
        public LoginForm()
        {
            InitializeComponent();
            if (Airport.LoadAirport() != "")
            {
                JsonSerializerSettings settings = new JsonSerializerSettings();
                settings.TypeNameHandling = TypeNameHandling.All;
                _airport = JsonConvert.DeserializeObject<Airport>(Airport.LoadAirport(), settings);
            }
            else
            {
                _airport = new Airport();
                _airport.Users.Add(new Admin("Artur", "Kharytonov", 18, "artur", "4455"));
                Airport.SaveAirport(_airport);
            }
        }

        private void linkLabelReg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Hide();
            SignUpForm signUpForm = new SignUpForm(_airport);
            signUpForm.ShowDialog();
            Show();

            Airport.SaveAirport(_airport);
        }

        private void buttonLog_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text.Trim() != String.Empty &&
                textBoxPassword.Text.Trim() != String.Empty)
            {
                if (DoesCorrectInput(textBoxLogin.Text, textBoxPassword.Text))
                {
                    Hide();

                    User loggedUser = GetUser(textBoxLogin.Text, textBoxPassword.Text);
                    textBoxLogin.Text = String.Empty;
                    textBoxPassword.Text = String.Empty;
                    string temp = loggedUser.GetType().ToString();

                    if (loggedUser.GetType() == typeof(Customer))
                    {
                        CustomerForm customerForm = new CustomerForm(loggedUser);
                        customerForm.ShowDialog();
                    }
                    else
                    {
                        AdminForm adminForm = new AdminForm(loggedUser, _airport);
                        adminForm.ShowDialog();
                    }

                    //Airport.SaveAirport(_airport);
                    Show();
                }
                else
                    MessageBox.Show("Incorrect login or password", "Incorrect input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Enter login and password correctly", "Incorrect input", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }

        private bool DoesCorrectInput(string login, string password)
        {
            return _airport.Users.Any(user => user.Login == login && user.Password == password);
        }

        private User GetUser(string login, string password)
        {
            return _airport.Users.FirstOrDefault(user => user.Login == login && user.Password == password);
        }

        private void pictureBoxEye_Click(object sender, EventArgs e)
        {
            _passwordOpen = !_passwordOpen;

            if (_passwordOpen)
            {
                textBoxPassword.UseSystemPasswordChar = false;
                pictureBoxEye.Image = Properties.Resources.eyeIcon;
            }

            else
            {
                textBoxPassword.UseSystemPasswordChar = true;
                pictureBoxEye.Image = Properties.Resources.crossedEyeIcon;
            }
        }
    }
}
