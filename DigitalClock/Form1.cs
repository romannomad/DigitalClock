using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DigitalClock
{
    public partial class DigitalClock : Form
    {
        public DigitalClock()
        {
            InitializeComponent();
            redButton.FlatStyle = FlatStyle.Flat;
            orangeButton.FlatStyle = FlatStyle.Flat;
            yellowButton.FlatStyle = FlatStyle.Flat;
            greenButton.FlatStyle = FlatStyle.Flat;
            blueButton.FlatStyle = FlatStyle.Flat;
        }

        private void DigitalClock_Load(object sender, EventArgs e)
        {
            clockTimer.Start();
        }

        private void clockTimer_Tick(object sender, EventArgs e)
        {
            clockLabel.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void blueButton_Click(object sender, EventArgs e)
        {
            clockLabel.ForeColor = Color.Blue;
        }

        private void greenButton_Click(object sender, EventArgs e)
        {
            clockLabel.ForeColor = Color.Green;
        }

        private void yellowButton_Click(object sender, EventArgs e)
        {
            clockLabel.ForeColor = Color.Yellow;
        }

        private void orangeButton_Click(object sender, EventArgs e)
        {
            clockLabel.ForeColor = Color.Orange;
        }

        private void redButton_Click(object sender, EventArgs e)
        {
            clockLabel.ForeColor = Color.Red;
        }

        private void styleButton1_Click(object sender, EventArgs e)
        {
            clockLabel.Font = new Font("Microsoft Sans Serif", 90, FontStyle.Regular);
        }

        private void styleButton2_Click(object sender, EventArgs e)
        {
            clockLabel.Font = new Font("Mongolian Baiti", 90, FontStyle.Regular);
        }

        private void styleButton3_Click(object sender, EventArgs e)
        {
            clockLabel.Font = new Font("Nirmala Text", 90, FontStyle.Regular);
        }
    }
}
