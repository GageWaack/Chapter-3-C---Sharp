using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUIcalculator
{
    public partial class GUIcalculator : Form
    {
        public GUIcalculator()
        {
            InitializeComponent();
        }
        
         
          

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnsum_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;
            int total;

            num1 = Convert.ToInt32(txt1.Text);
            num2 = Convert.ToInt32(txt2.Text);

            total = num1 + num2;
            lblResult.Text = "The sum is " + total;
        }

        private void btnsub_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;
            int total;

            num1 = Convert.ToInt32(txt1.Text);
            num2 = Convert.ToInt32(txt2.Text);

            total = num1 - num2;
            lblResult.Text = "The answer is " + total;
        }

        private void btndiv_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;
            int total;

            num1 = Convert.ToInt32(txt1.Text);
            num2 = Convert.ToInt32(txt2.Text);

            total = num1 / num2;
            lblResult.Text = "The difference is " + total;
        }

        private void btnmulti_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;
            int total;

            num1 = Convert.ToInt32(txt1.Text);
            num2 = Convert.ToInt32(txt2.Text);

            total = num1 * num2;
            lblResult.Text = "The answer is " + total;
        }

        private void btnmod_Click(object sender, EventArgs e)
        {
            int num1;
            int num2;
            int total;

            num1 = Convert.ToInt32(txt1.Text);
            num2 = Convert.ToInt32(txt2.Text);

            total = num1 % num2;
            lblResult.Text = "The answer is " + total;
        }

        private void lblResult_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }

        
 }
