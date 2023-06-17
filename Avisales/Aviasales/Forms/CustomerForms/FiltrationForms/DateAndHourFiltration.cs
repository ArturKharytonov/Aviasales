using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization.Configuration;

namespace Aviasales.Forms.CustomerForms.FiltrationForms
{
    public partial class DateAndHourFiltration : Form
    {
        private DateTime _dateFrom;
        private DateTime _dateTo;

        public (DateTime, DateTime, bool) ShowDateAndHourFiltration()
        {
            ShowDialog();

            return (_dateFrom, _dateTo, !checkBox1.Checked);
        }

        public DateAndHourFiltration()
        {
            InitializeComponent();

            dateTimePickerFrom.Format = DateTimePickerFormat.Custom;
            dateTimePickerFrom.CustomFormat = "dd/MM/yyyy HH:mm";

            dateTimePickerTo.Format = DateTimePickerFormat.Custom;
            dateTimePickerTo.CustomFormat = "dd/MM/yyyy HH:mm";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxDate.Enabled = !groupBoxDate.Enabled;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                if (dateTimePickerFrom.Value < dateTimePickerTo.Value && dateTimePickerFrom.Value >= DateTime.Today)
                {
                    _dateFrom = dateTimePickerFrom.Value;
                    _dateTo = dateTimePickerTo.Value;
                    Close();
                }
                else MessageBox.Show("Provide correct dates", "Notification",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
