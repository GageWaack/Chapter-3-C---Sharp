using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestsInteractiveGUI
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
            double test1;
            double test2;
            double test3;
            double test4;
            double test5;
            double answer;
            double convert;

            test1 = Convert.ToDouble(txtTest1.Text);
            test2 = Convert.ToDouble(txtTest2.Text);
            test3 = Convert.ToDouble(txtTest3.Text);
            test4 = Convert.ToDouble(txtTest4.Text);
            test5 = Convert.ToDouble(txtTest5.Text);

            convert = test1 + test2 + test3 + test4 + test5 / 5;

            answer = convert / 100;

            lblResult.Text = "The answer is " + answer + "%";
        }
    }
}
