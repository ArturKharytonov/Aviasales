using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aviasales.Forms.CustomerForms.FiltrationForms
{
    public partial class DestinationsAndPricesForm : Form
    {
        private string _from;
        private string _to;
        private double _minPrice;
        private double _maxPrice;
        public DestinationsAndPricesForm()
        {
            InitializeComponent();
        }

        public (string from, string to, double minPrice, double maxPrice, bool wasLocked) ShowDestinationsAndPrices()
        {
            ShowDialog();

            return (_from, _to, _minPrice, _maxPrice, !checkBox1.Checked);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Enabled = !groupBox1.Enabled;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (numericUpDown1.Value < numericUpDown2.Value)
            {
                _from = textBox1.Text.Trim();
                _to = textBox2.Text.Trim();
                _minPrice = (double)numericUpDown1.Value;
                _maxPrice = (double)numericUpDown2.Value;
                Close();
            }
            else
                MessageBox.Show("Max price cannot be less than min prcie.", "Notification",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
