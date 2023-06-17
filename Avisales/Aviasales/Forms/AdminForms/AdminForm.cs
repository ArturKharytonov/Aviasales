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
using LibraryOfUserClasses;
using LibraryOfUserClasses.FlightModels;

namespace Aviasales
{
    public partial class AdminForm : Form
    {
        private User _admin;
        private Airport _airport;
        public AdminForm(User admin, Airport airport)
        {
            InitializeComponent();

            pictureBox1.Image = Properties.Resources.admin;
            _admin = admin;
            _airport = airport;

            UpdateLabels();
        }

        private void UpdateLabels()
        {
            lbNameData.Text = "Name: " + _admin.Name;
            lbSurnameData.Text = "Surname: " + _admin.Surname;
            lbAgeData.Text = "Age: " + _admin.Age;
        }

        private void toolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            switch (((ToolStripMenuItem)sender).Text)
            {
                case "Information":
                {
                    Information informationForm = new Information();
                    informationForm.ShowDialog();
                    break;
                }
                case "Settings":
                {
                    Settings settings = new Settings(_admin, _airport);
                    settings.ShowDialog();
                    UpdateLabels();
                    break;
                }
                case "Functional":
                {
                    AdminFunctionalForm adminFunctional = new AdminFunctionalForm();
                    adminFunctional.ShowDialog();
                    break;
                }
            }
            Show();
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
