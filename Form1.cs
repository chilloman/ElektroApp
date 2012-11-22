using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElektroApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btVolt_Click(object sender, EventArgs e)
        {
            this.Hide();
            Volt volt = new Volt();
            volt.Show();
        }

        private void btOhm_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ohm ohm = new Ohm();
            ohm.Show();
        }

        private void btAmpere_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ampere ampere = new Ampere();
            ampere.Show();
        }

        private void btWatt_Click(object sender, EventArgs e)
        {
            this.Hide();
            Watt watt = new Watt();
            watt.Show();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
