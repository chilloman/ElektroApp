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
    public partial class Volt : Form
    {
        public Volt()
        {

            InitializeComponent();      
        } 

        private void A_Click(object sender, EventArgs e)
        {

        }

        private void tbAmpere_TextChanged(object sender, EventArgs e)
        {

        }

        private void calcIR_Click(object sender, EventArgs e)
        {
            double ampIR = Convert.ToDouble(tbAmpere.Text);
            double ohmIR = Convert.ToDouble(tbOhm.Text);

            double answer = ampIR * ohmIR;

            answerIR.Text = "Svar: " + answer + "V";
        }

        private void calcPI_Click(object sender, EventArgs e)
        {
            double wattPI = Convert.ToDouble(tbWatt.Text);
            double ampPI = Convert.ToDouble(tbAmp.Text);

            double answer = wattPI / ampPI;

            answerPI.Text = "Svar: " + answer + "V";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

            Form1 form = new Form1();
            form.Show();
        }

    }
}
