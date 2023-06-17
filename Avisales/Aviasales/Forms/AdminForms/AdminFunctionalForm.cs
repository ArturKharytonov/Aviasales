using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aviasales.Forms.AdminForms.AdminPanelForms;
using FontAwesome.Sharp;
using LibraryOfUserClasses.FlightModels;
using Newtonsoft.Json;

namespace Aviasales.Forms
{
    public partial class AdminFunctionalForm : Form
    {
        private int index = 0;
        private const int _tickInterval = 1000;
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form _currentChildForm;
        private Airport _airport;

        private JsonSerializerSettings settings = new JsonSerializerSettings();

        public AdminFunctionalForm()
        {
            InitializeComponent();

            settings = new JsonSerializerSettings();
            settings.TypeNameHandling = TypeNameHandling.All;
            _airport = JsonConvert.DeserializeObject<Airport>(Airport.LoadAirport(), settings);

            
            timer.Interval = _tickInterval;
            timer_Elapsed(timer, EventArgs.Empty);
            timer.Start();

            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);

            panelMenu.Controls.Add(leftBorderBtn);
        }

        struct RGBColors
        {
            public static Color color1 = Color.FromArgb(255, 255, 102);
            public static Color color2 = Color.FromArgb(249, 118, 17);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(127, 0, 255);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
            public static Color color7 = Color.FromArgb(114, 15, 117);
        }

        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();

                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(128, 128, 255);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor =color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleCenter;

                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
                lbCurrentChildForm.Text = "";
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(128, 128, 255);
                currentBtn.ForeColor = Color.Black;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = Color.Black;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleCenter;
            }
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

        private void btnMenu_Click(object sender, EventArgs e)
        {
            switch (((IconButton)sender).Name)
            {
                case "iconButton1":
                {
                    ActivateButton(sender, RGBColors.color1);

                    OpenChildForm(new AddPlaneForm(_airport));
                    break;
                }
                case "iconButton2":
                {
                    ActivateButton(sender, RGBColors.color2);
                    OpenChildForm(new AddFlightForm(_airport));
                    break;
                }
                case "iconButton3":
                {
                    ActivateButton(sender, RGBColors.color3);
                    OpenChildForm(new CancelTickets(_airport));
                    
                    break;
                }
                case "iconButton4":
                {
                    ActivateButton(sender, RGBColors.color4);
                        
                    OpenChildForm(new CreationOfUserForm(_airport));
                    break;
                }
                case "iconButton5":
                {
                    ActivateButton(sender, RGBColors.color5);
                    OpenChildForm(new EditFlightForm(_airport));
                    break;
                }
                case "iconButton6":
                {
                    ActivateButton(sender, RGBColors.color6);
                    OpenChildForm(new EndedFlightsForm(_airport));
                    break;
                }
                case "iconButton7":
                {
                    ActivateButton(sender, RGBColors.color7);
                    OpenChildForm(new CancelFlightForm(_airport));
                    break;
                }
            }
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
            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.Black;
            lbCurrentChildForm.Text = "Home";

            _airport = JsonConvert.DeserializeObject<Airport>(Airport.LoadAirport(), settings);
        }

        private void timer_Elapsed(object sender, EventArgs e)
        {
            Color[] colors =
            {
                RGBColors.color1, RGBColors.color2, RGBColors.color3, RGBColors.color4, RGBColors.color5,
                RGBColors.color6, RGBColors.color7
            };
            if (index == colors.Length)
                index = 0;
            lbTime.ForeColor = colors[index];
            lbTime.Text = DateTime.Now.ToString("HH:mm:ss");
            index++;
        }
    }
}


//[DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
//private static extern void ReleaseCapture();

//[DllImport("user32.DLL", EntryPoint = "SendMessage")]
//private static extern void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);