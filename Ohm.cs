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
    public partial class Ohm : Form
    {
        public Ohm()
        {
            InitializeComponent();
        }

        private void calcUI_Click(object sender, EventArgs e)
        {
            double volt = Convert.ToDouble(tbVolt.Text);
            double ampere = Convert.ToDouble(tbAmpere.Text);

            double answer = volt / ampere;

            answerUI.Text = "Svar: " + answer + "Ω";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();

            Form1 form = new Form1();
            form.Show();
        }
    }
}
