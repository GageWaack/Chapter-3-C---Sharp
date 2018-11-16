using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilesTokilometersGUI
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
            double miles;
            double kilometer = 1.6;
            double conversion;

            miles= Convert.ToDouble (txtNumMiles.Text);
            conversion = miles * kilometer;



        }

        private void lblAnswer_Click(object sender, EventArgs e)
        {
            double miles;
            double kilometer = 1.6;
            double conversion;

            miles = Convert.ToDouble(txtNumMiles.Text);
            conversion = miles * kilometer;

            lblAnswer.Text = "" + conversion;
            
        }

        private void txtNumMiles_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

