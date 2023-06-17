using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aviasales.Forms.AdminForms.AdminPanelForms;
using Aviasales.Forms.CustomerForms.CustomerPanelForms;
using FontAwesome.Sharp;
using LibraryOfUserClasses;
using LibraryOfUserClasses.FlightModels;
using Newtonsoft.Json;

namespace Aviasales.Forms.CustomerForms
{
    public partial class CustomerFunctionalForm : Form
    {
        private int index = 0;
        private const int _tickInterval = 1000;
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form _currentChildForm;
        private JsonSerializerSettings settings = new JsonSerializerSettings();

        private Airport _airport;
        private Customer _currentCustomer;
        public CustomerFunctionalForm(Airport airport, Customer customer)
        {
            InitializeComponent();
            settings.TypeNameHandling = TypeNameHandling.All;
            _airport = airport;
            _currentCustomer = customer;

            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);

            timer.Interval = _tickInterval;
            timer_Elapsed(timer, EventArgs.Empty);
            timer.Start();

            panelMenu.Controls.Add(leftBorderBtn);
        }

        struct RGBColors
        {
            public static Color color1 = Color.FromArgb(255, 255, 102);
            public static Color color2 = Color.FromArgb(249, 118, 17);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(127, 150, 111);
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();

                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(76, 86, 89);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleCenter;

                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.ForeColor = color;
                label.Text = currentBtn.Text.ToUpper();
                label.ForeColor = color;
            }
        }

        private void DisableButton()
         {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(76,86, 89);
                currentBtn.ForeColor = Color.Black;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Black;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
         }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            switch (((IconButton)sender).Name)
            {
                case "iconButton1":
                {
                    ActivateButton(sender, RGBColors.color1);
                    OpenChildForm(new BuyTicket(_airport, _currentCustomer));
                    break;
                }
                case "iconButton2":
                {
                    ActivateButton(sender, RGBColors.color2);
                    OpenChildForm(new ShowTickets(_currentCustomer, _airport));
                    break;
                }
                case "iconButton3":
                {
                    ActivateButton(sender, RGBColors.color3);
                    OpenChildForm(new ReplenishMoneyForm(_airport, _currentCustomer));
                    break;
                }
                case "iconButton4":
                {
                    ActivateButton(sender, RGBColors.color4);
                    OpenChildForm(new CancelTicket(_airport, _currentCustomer));
                    break;
                }
            }
            _airport = JsonConvert.DeserializeObject<Airport>(Airport.LoadAirport(), settings);
        }

        private void OpenChildForm(Form childForm)
        {
            if (_currentChildForm != null)
                _currentChildForm.Close();

            _currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.BringToFront();
            childForm.Show();
        }

        private void logoHome_Click(object sender, EventArgs e)
         {
             if (_currentChildForm != null)
                 _currentChildForm.Close();
             Reset();
         }

        private void Reset()
         {
             DisableButton();
             leftBorderBtn.Visible = false;
             
             iconCurrentChildForm.ForeColor = Color.Cornsilk;
             iconCurrentChildForm.IconChar = IconChar.Home;

             label.ForeColor = Color.Cornsilk;
             label.Text = "HOME";

             JsonSerializerSettings serializerSettings = new JsonSerializerSettings();
             serializerSettings.TypeNameHandling = TypeNameHandling.All;
             _airport = JsonConvert.DeserializeObject<Airport>(Airport.LoadAirport(), serializerSettings);
        }

        private void timer_Elapsed(object sender, EventArgs e)
         {
             
             Color[] colors =
             {
                 RGBColors.color1, RGBColors.color2, RGBColors.color3, RGBColors.color4
             };
             if (index == colors.Length)
                 index = 0;
             lbTime.ForeColor = colors[index];
             lbTime.Text = DateTime.Now.ToString("HH:mm:ss");
             index++;
         }

    }
}
