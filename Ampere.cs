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
    public partial class Ampere : Form
    {
        public Ampere()
        {
            InitializeComponent();
        }

        private void calcPU_Click(object sender, EventArgs e)
        {
            double watt = Convert.ToDouble(tbWatt.Text);
            double volt = Convert.ToDouble(tbVolt.Text);

            double answer = watt / volt;

            answerPU.Text = "Svar: " + answer + "A";
        }

        private void calcUR_Click(object sender, EventArgs e)
        {
            double volt = Convert.ToDouble(tbVolt1.Text);
            double ohm = Convert.ToDouble(tbOhm.Text);

            double answer = volt / ohm;

            answerUR.Text = "Svar: " + answer + "A";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

            Form1 form = new Form1();
            form.Show();
        }
    }
}
