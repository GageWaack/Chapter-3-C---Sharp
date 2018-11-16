using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarRentalInteractiveGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            double days;
               double miles;
            double convert;

            days = Convert.ToDouble(txtDays.Text);
            miles = Convert.ToDouble(txtMiles.Text);

            convert = days + miles;

            lblTotal.Text = "Your total is " + convert;
        }
    }
}
