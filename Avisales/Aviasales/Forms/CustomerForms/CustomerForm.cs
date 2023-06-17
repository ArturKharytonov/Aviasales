using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aviasales.Forms;
using Aviasales.Forms.CustomerForms;
using LibraryOfUserClasses;
using LibraryOfUserClasses.FlightModels;
using Newtonsoft.Json;

namespace Aviasales
{
    public partial class CustomerForm : Form
    {
        private User _currentUser;
        private Airport _airport;
        private JsonSerializerSettings settings = new JsonSerializerSettings();
        public CustomerForm(User user)
        {
            InitializeComponent();

            pictureBox1.Image = Properties.Resources.customer;
            settings.TypeNameHandling = TypeNameHandling.All;
            _airport = JsonConvert.DeserializeObject<Airport>(Airport.LoadAirport(), settings);


            _currentUser = user;

            UpdateData();
        }

        private void UpdateData()
        {
            lbNameData.Text = "Name: " + _currentUser.Name;
            lbSurnameData.Text = "Surname: " + _currentUser.Surname;
            lbAgeData.Text = "Age: " + _currentUser.Age;
            lbBalanceData.Text = "Balance: " + ((Customer)_currentUser).Balance;
        }

        private void btnLogOut_Click(object sender, EventArgs e) 
            =>Close();
        private void btn_Click(object sender, EventArgs e)
        {
            Hide();
            switch (((Button)sender).Text)
            {
                case "Information":
                {
                    Information information = new Information();
                    information.ShowDialog();
                    break;
                }
                case "Settings":
                {
                    Settings settings = new Settings(_currentUser, _airport);
                    settings.ShowDialog();
                    Airport.SaveAirport(_airport);
                    break;
                }
                case "Functional":
                {
                    CustomerFunctionalForm customerFuctionalForm = new CustomerFunctionalForm(_airport, ((Customer)_currentUser));
                    customerFuctionalForm.ShowDialog();
                    break;
                }
            }
            UpdateData();
            Show();

            _airport = JsonConvert.DeserializeObject<Airport>(Airport.LoadAirport(), settings);
        }
    }
}
